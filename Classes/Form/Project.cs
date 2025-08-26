using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            public ushort Navi_MajorID = 0;
            public ushort Navi_MinorID = 0;
            public ushort Navi_SubID = 0;
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
                foreach (var importBup in importNamesProj.Bustups.Where(x => x.MajorID == bup.MajorID && x.MinorID == bup.MinorID))
                {
                    bup.CharaName = importBup.CharaName.Copy();
                    bup.Navi_MajorID = importBup.Navi_MajorID.Copy();

                    bup.ExpressionName = importBup.ExpressionName.Copy();
                    bup.Navi_MinorID = importBup.Navi_MinorID.Copy();

                    if (bup.SubID == importBup.SubID)
                        bup.OutfitName = importBup.OutfitName.Copy();
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
                {
                    bup.CharaName = charaName.Copy();

                    if (bup.MinorID == minorId)
                    {
                        bup.ExpressionName = expressionName.Copy();

                        if (bup.SubID == subId)
                            bup.OutfitName = outfitName.Copy();
                    }
                }
            }

            MessageBox.Show("Done importing names from Wiki Table.");
            bindingSource_ListBox.ResetBindings(false);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            //ApplyNaviIDs();
            bindingSource_ListBox.ResetBindings(false);
        }

        private void ApplyNaviIDs()
        {
            // Only apply to main party members
            foreach (var bup in bustupProject.Bustups.Where(x => x.MajorID <= 10))
            {
                // Set bustups for main party phantom thieves
                if ((bup.MinorID > 100 && bup.MinorID < 200) 
                    || (bup.MinorID > 800 && bup.MinorID < 814))
                ApplyNaviToMajorID_PhantomThief(bup);

                // Ryuji MidWinter
                if (bup.MajorID == 2 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 12);
                // Morgana Midwinter (not exist)
                // Ann MidWinter
                if (bup.MajorID == 4 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 14);
                // Yusuke MidWinter
                if (bup.MajorID == 5 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 15);
                // Makoto Midwinter
                if (bup.MajorID == 6 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 16);
                // Haru Midwinter
                if (bup.MajorID == 7 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 17);
                // Futaba Midwinter (not exist)
                // Akechi Midwinter
                if (bup.MajorID == 9 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 19);
                // Sumire MidWinter
                if (bup.MajorID == 10 && bup.SubID == 2)
                    ApplyNaviToMajorID(bup, 20);

                // Ryuji Summer
                if (bup.MajorID == 2 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 22);
                // Morgana Summer (not exist)
                // Ann Summer
                if (bup.MajorID == 4 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 24);
                // Yusuke Summer
                if (bup.MajorID == 5 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 25);
                // Makoto Summer
                if (bup.MajorID == 6 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 26);
                // Haru Summer
                if (bup.MajorID == 7 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 27);
                // Futaba Summer (not exist)
                // Akechi Summer
                if (bup.MajorID == 9 && bup.SubID == 1)
                    ApplyNaviToMajorID(bup, 29);
                // Sumire Summer (not exist)

                // Ryuji WinterCasual
                if (bup.MajorID == 2 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 32);
                // Morgana WinterCasual (not exist)
                // Ann WinterCasual
                if (bup.MajorID == 4 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 34);
                // Yusuke WinterCasual
                if (bup.MajorID == 5 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 35);
                // Makoto WinterCasual
                if (bup.MajorID == 6 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 36);
                // Haru WinterCasual
                if (bup.MajorID == 7 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 37);
                // Futaba WinterCasual
                if (bup.MajorID == 8 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 38);
                // Akechi WinterCasual
                if (bup.MajorID == 9 && bup.SubID == 4)
                    ApplyNaviToMajorID(bup, 39);
                // Sumire WinterCasual (not exist)

                // Ryuji SummerCasual
                if (bup.MajorID == 2 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 42);
                // Morgana SummerCasual (not exist)
                // Ann SummerCasual
                if (bup.MajorID == 4 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 44);
                // Yusuke SummerCasual
                if (bup.MajorID == 5 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 45);
                // Makoto SummerCasual
                if (bup.MajorID == 6 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 46);
                // Haru SummerCasual
                if (bup.MajorID == 7 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 47);
                // Futaba SummerCasual
                if (bup.MajorID == 8 && bup.SubID == 3)
                    ApplyNaviToMajorID(bup, 48);
                // Akechi SummerCasual (not exist)
                // Sumire SummerCasual (not exist)

                // Ryuji 3rdSemWinterUniform
                if (bup.MajorID == 2 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 52);
                // Morgana 3rdSemWinterUniform (not exist)
                // Ann 3rdSemWinterUniform
                if (bup.MajorID == 4 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 54);
                // Yusuke 3rdSemWinterUniform
                if (bup.MajorID == 5 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 55);
                // Makoto 3rdSemWinterUniform
                if (bup.MajorID == 6 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 56);
                // Haru 3rdSemWinterUniform
                if (bup.MajorID == 7 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 57);
                // Futaba 3rdSemWinterUniform
                if (bup.MajorID == 8 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 58);
                // Akechi 3rdSemWinterUniform
                if (bup.MajorID == 9 && bup.SubID == 5)
                    ApplyNaviToMajorID(bup, 59);
                // Sumire 3rdSemWinterUniform
                if (bup.MajorID == 10 && bup.SubID == 5)
                {
                    ApplyNaviToMajorID(bup, 60, 900, 100); // hair up
                    ApplyNaviToMajorID(bup, 60); // hair down
                }

                // Ryuji 3rdSemWinterCasual
                if (bup.MajorID == 2 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 62);
                // Morgana 3rdSemWinterUniform (not exist)
                // Ann 3rdSemWinterUniform
                if (bup.MajorID == 4 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 64);
                // Yusuke 3rdSemWinterUniform
                if (bup.MajorID == 5 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 65);
                // Makoto 3rdSemWinterUniform
                if (bup.MajorID == 6 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 66);
                // Haru 3rdSemWinterUniform
                if (bup.MajorID == 7 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 67);
                // Futaba 3rdSemWinterUniform
                if (bup.MajorID == 8 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 68);
                // Akechi 3rdSemWinterUniform
                if (bup.MajorID == 9 && bup.SubID == 6)
                    ApplyNaviToMajorID(bup, 69);
                // Sumire 3rdSemWinterUniform
                if (bup.MajorID == 10 && bup.SubID == 6)
                {
                    ApplyNaviToMajorID(bup, 70, 900, 100); // hair up
                    ApplyNaviToMajorID(bup, 70); // hair down
                }
            }
        }

        private void ApplyNaviToMajorID(Bustup bup, ushort majorID, int bupminor_add = 0, int navi_add = 0)
        {
            // Set Navi majorID to whatever value is passed in
            bup.Navi_MajorID = majorID;

            switch (bup.MinorID + bupminor_add)
            {
                case 0:
                    // Neutral
                    bup.Navi_MinorID = Convert.ToUInt16(1 + navi_add);
                    break;
                case 1:
                    // Smiling
                    bup.Navi_MinorID = Convert.ToUInt16(2 + navi_add);
                    break;
                case 3:
                    // Sad
                    bup.Navi_MinorID = Convert.ToUInt16(7 + navi_add);
                    break;
            }
        }

        private void ApplyNaviToMajorID_PhantomThief(Bustup bup)
        {
            bup.Navi_MajorID = bup.MajorID.Copy();

            switch (bup.MinorID)
            {
                case 100:
                    // If Event bustup's minorID is 100, set navi minorID to 1
                    bup.Navi_MinorID = 1;
                    break;
                case 101:
                    bup.Navi_MinorID = 2;
                    break;
                case 102:
                    bup.Navi_MinorID = 3;
                    break;
                case 103:
                    bup.Navi_MinorID = 7;
                    break;
                case 104:
                    bup.Navi_MinorID = 4;
                    break;
                case 105:
                    bup.Navi_MinorID = 4;
                    break;
                case 150:
                    bup.Navi_MinorID = 6;
                    break;
                case 800:
                    bup.Navi_MinorID = 1;
                    break;
                case 801:
                    bup.Navi_MinorID = 2;
                    break;
                case 802:
                    bup.Navi_MinorID = 3;
                    break;
                case 803:
                    bup.Navi_MinorID = 7;
                    break;
                case 804:
                    bup.Navi_MinorID = 4;
                    break;
                case 805:
                    bup.Navi_MinorID = 4;
                    break;
            }
        }

        private void ConvertToNaviProject_Click(object sender, EventArgs e)
        {
            string convBupDir = "./Converted";

            bustupProject.Scale = 50;

            Directory.CreateDirectory(convBupDir);
            string[] bupParts = new string[] { "", "_e1", "_e2", "_m1", "_m2", "_m3" };
            var newProject = JsonConvert.DeserializeObject<BustupProject>(File.ReadAllText("./Dependencies/Json/p5r_navi.json"));

            foreach (var bup in bustupProject.Bustups.Where(x => x.Navi_MinorID != 0))
            {
                string eventBupName = $"B{bup.MajorID.ToString("D3")}_{bup.MinorID.ToString("D3")}_{bup.SubID.ToString("D2")}";
                string eventBupDir = Path.Combine(bustupProject.ImagesPath, eventBupName);
                eventBupName = eventBupName.ToLower();

                if (newProject.Bustups.Any(x => x.MajorID == bup.Navi_MajorID
                        && x.MinorID == bup.Navi_MinorID))
                {
                    if (Directory.Exists(eventBupDir) || File.Exists(bup.BaseImgPath))
                    {
                        // Set Event bustup properties to new Navi bustup project
                        var newNaviBup = newProject.Bustups.First(x => x.MajorID == bup.Navi_MajorID && x.MinorID == bup.Navi_MinorID);

                        string bupName = $"B{bup.Navi_MajorID.ToString("D3")}_{bup.Navi_MinorID.ToString("D3")}";
                        string bupDir = Path.Combine(convBupDir, bupName);
                        bupName = bupName.ToLower();

                        foreach (var part in bupParts)
                        {
                            string eventBupImage = "";
                            string outImage = Path.Combine(bupDir, bupName + part + ".png");


                            if (part == "")
                            {
                                if (File.Exists(bup.BaseImgPath))
                                    eventBupImage = bup.BaseImgPath.Copy();
                                else
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.BaseImgPath = outImage.Copy();
                            }
                            if (part == "_e1")
                            {
                                if (File.Exists(bup.BlinkImg1Path))
                                    eventBupImage = bup.BlinkImg1Path.Copy();
                                else if (!File.Exists(bup.BaseImgPath))
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.BlinkImg1Path = outImage.Copy();
                            }
                            if (part == "_e2")
                            {
                                if (File.Exists(bup.BlinkImg2Path))
                                    eventBupImage = bup.BlinkImg2Path.Copy();
                                else if (!File.Exists(bup.BaseImgPath))
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.BlinkImg2Path = outImage.Copy();
                            }
                            if (part == "_m1")
                            {
                                if (File.Exists(bup.MouthImg1Path))
                                    eventBupImage = bup.MouthImg1Path.Copy();
                                else if (!File.Exists(bup.BaseImgPath))
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.MouthImg1Path = outImage.Copy();
                            }
                            if (part == "_m2")
                            {
                                if (File.Exists(bup.MouthImg2Path))
                                    eventBupImage = bup.MouthImg2Path.Copy();
                                else if (!File.Exists(bup.BaseImgPath))
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.MouthImg2Path = outImage.Copy();
                            }
                            if (part == "_m3")
                            {
                                if (File.Exists(bup.MouthImg3Path))
                                    eventBupImage = bup.MouthImg3Path.Copy();
                                else if (!File.Exists(bup.BaseImgPath))
                                    eventBupImage = Path.Combine(eventBupDir, eventBupName + part + ".dds");

                                newNaviBup.MouthImg3Path = outImage.Copy();
                            }

                            if (File.Exists(eventBupImage))
                            {
                                // Shrink image by 50% and flip vertically
                                if (Path.GetExtension(eventBupImage).ToUpper() == ".DDS")
                                {
                                    Bitmap bmp = ScaleBitmap(ConvertDDSToBitmap(File.ReadAllBytes(eventBupImage)));
                                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

                                    // Save as PNG
                                    Directory.CreateDirectory(Path.GetDirectoryName(outImage));
                                    bmp.Save(outImage);
                                }
                                else
                                {
                                    Bitmap bmp = ScaleBitmap(new Bitmap(eventBupImage));
                                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

                                    // Save as PNG
                                    Directory.CreateDirectory(Path.GetDirectoryName(outImage));
                                    bmp.Save(outImage);
                                }
                            }
                        }


                        var basePos = ScalePoint(Convert.ToDouble(bup.BasePos_X), Convert.ToDouble(bup.BasePos_Y));
                        newNaviBup.BasePos_X = basePos.X.Copy(); newNaviBup.BasePos_Y = basePos.Y.Copy();

                        var mouthPos = ScalePoint(Convert.ToDouble(bup.MouthPos_X), Convert.ToDouble(bup.MouthPos_Y));
                        newNaviBup.MouthPos_X = mouthPos.X.Copy(); newNaviBup.MouthPos_Y = mouthPos.Y.Copy();

                        var eyePos = ScalePoint(Convert.ToDouble(bup.EyePos_X), Convert.ToDouble(bup.EyePos_Y));
                        newNaviBup.EyePos_X = eyePos.X.Copy(); newNaviBup.EyePos_Y = eyePos.Y.Copy();

                        newNaviBup.CharaName = bup.CharaName.Copy();
                        newNaviBup.ExpressionName = bup.ExpressionName.Copy();
                        newNaviBup.OutfitName = bup.OutfitName.Copy();
                        newNaviBup.AnimType = bup.AnimType.Copy();

                        newProject.ImagesPath = convBupDir.Copy();
                    }
                }
            }

            bustupProject = newProject;
            UpdateSpriteList();

            MessageBox.Show("Done converting project to navi project!");
        }
    }
}
