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

            File.WriteAllText(selection.First(), JsonConvert.SerializeObject(bustupProject, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show($"Saved project file to:\n{selection.First()}", "Project Saved Successfully");
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
    }
}
