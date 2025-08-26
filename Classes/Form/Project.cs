using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BustupEditor.MainForm;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        BustupProject bustupProject = new BustupProject();

        public class BustupProject
        {
            public string Name = "Untitled";
            public string ImagesPath = "./Images";
            public List<Bustup> Bustups = new List<Bustup>();
            public BustupType Type = BustupType.Unknown;
            public PlatformType Platform = PlatformType.Unknown;
            public int Scale = 50;
        }

        public class Bustup
        {
            public string Name = "Untitled";
            public string CharaName = "";
            public string ExpressionName = "";
            public string OutfitName = "";
            public ushort MajorID = 0;
            public ushort MinorID = 0;
            public ushort SubID = 0;
            public float BasePos_X = 0;
            public float BasePos_Y = 0;
            public float EyePos_X = 0;
            public float EyePos_Y = 0;
            public float MouthPos_X = 0;
            public float MouthPos_Y = 0;
            public AnimationType AnimType = AnimationType.None;
            public string BaseImgPath = "";
            public string BlinkImg1Path = "";
            public string BlinkImg2Path = "";
            public string MouthImg1Path = "";
            public string MouthImg2Path = "";
            public string MouthImg3Path = "";
            public bool AutoScaleImg = false;
        }

        public enum PlatformType
        {
            PS3,
            PS4,
            PC,
            Unknown
        }

        public enum BustupType
        {
            Unknown,
            Portrait,
            Navigator
        }

        public enum AnimationType
        {
            None,
            Eyes,
            Mouth,
            Eyes_Mouth,
            Eyes_Mouth_ExcludeAlpha = 11,
            Unknown = 15
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Save project file...", true, new string[] { "json (.json)" }, true);
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            string outPath = selection.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath = outPath + ".json";

            File.WriteAllText(outPath, JsonConvert.SerializeObject(bustupProject, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved Successfully");
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Load project file...", true, new string[] { "json (.json)" });
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            LoadJson(selection.First());
        }

        private void LoadJson(string jsonPath)
        {
            bustupProject = JsonConvert.DeserializeObject<BustupProject>(File.ReadAllText(jsonPath));
            
            UpdateSpriteList();
        }

        private void NewProj_P5R_Event_Click(object sender, EventArgs e)
        {
            LoadJson("./Dependencies/Json/p5r_event.json");
        }

        private void NewProj_P5R_Navi_Click(object sender, EventArgs e)
        {
            LoadJson("./Dependencies/Json/p5r_navi.json");
        }

        private void NewProj_P5_PS3_Event_Click(object sender, EventArgs e)
        {
            LoadJson("./Dependencies/Json/ps3_event.json");
        }

        private void NewProj_P5_PS3_Navi_Click(object sender, EventArgs e)
        {
            LoadJson("./Dependencies/Json/ps3_navi.json");
        }

        private void importNamesFromJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Get Names from project file...", true, new string[] { "json (.json)" });
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            var importNamesProj = JsonConvert.DeserializeObject<BustupProject>(File.ReadAllText(selection.First()));

            foreach (var bup in bustupProject.Bustups) 
            {
                foreach (var importBup in importNamesProj.Bustups)
                {
                    if (bup.MajorID == importBup.MajorID)
                    {
                        bup.CharaName = importBup.CharaName.Copy();

                        if (bup.MinorID == importBup.MinorID)
                        {
                            bup.ExpressionName = importBup.ExpressionName.Copy();

                            if (bup.SubID == importBup.SubID)
                                bup.OutfitName = importBup.OutfitName.Copy();
                        }
                    }
                }
            }

            bindingSource_ListBox.ResetBindings(false);
            MessageBox.Show("Done importing names from JSON.");
        }

        private void ApplyNamesToSameIDs_Click(object sender, EventArgs e)
        {
            ApplyNamesToSameIDs(false);
        }

        private void ApplyNamesToSameIDs_ThisCharaOnly_Click(object sender, EventArgs e)
        {
            ApplyNamesToSameIDs(true);
        }

        private void ApplyNamesToSameIDs(bool thisCharaOnly)
        {
            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            if (listBox_Sprites.SelectedIndex == -1 || listBox_Sprites.SelectedIndex == 0)
                return;

            var bups = bustupProject.Bustups;
            if (thisCharaOnly)
                bups = bups.Where(x => x.MajorID == selectedBustup.MajorID).ToList();

            foreach (var bup in bups)
            {
                if (bup.MinorID == selectedBustup.MinorID)
                    bup.ExpressionName = selectedBustup.ExpressionName.Copy();
                if (bup.SubID == selectedBustup.SubID)
                    bup.OutfitName = selectedBustup.OutfitName.Copy();
            }

            bindingSource_ListBox.ResetBindings(false);
        }

        private void ImportNamesFromWiki_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Get Names from Wiki Table...", true, new string[] { "txt (.txt)" });
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            var wikiText = File.ReadAllLines(selection.First());
            var bups = bustupProject.Bustups;

            foreach (var line in wikiText.Where(x => x.StartsWith("| b")))
            {
                var splitLine = line.Split("||");
                var splitId = splitLine[0].Split("_");
                ushort majorId = ushort.Parse(splitId[0].Replace("| b",""));
                ushort minorId = ushort.Parse(splitId[1]);
                ushort subId = ushort.Parse(splitId[2].Trim());

                string charaName = splitLine[1].Trim();
                string expressionName = splitLine[2].Trim();
                string outfitName = splitLine[3].Trim();

                foreach(var bup in bups.Where(x => x.MajorID == majorId))
                    bup.CharaName = charaName.Copy();

                foreach (var bup in bups.Where(x => x.MinorID == minorId))
                    bup.ExpressionName = expressionName.Copy();

                foreach (var bup in bups.Where(x => x.SubID == subId))
                    bup.OutfitName = outfitName.Copy();
            }

            MessageBox.Show("Done importing names from Wiki Table.");
            bindingSource_ListBox.ResetBindings(false);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            bindingSource_ListBox.ResetBindings(false);
        }
    }
}
