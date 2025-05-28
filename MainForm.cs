using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetMenuStripIcons();
            SetOverlayImages();
        }

        public Bustup copiedParams = new Bustup(); // holds parameters for the last copied bustup

        private void SetMenuStripIcons()
        {
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("./Dependencies/Icons.txt"), this);
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<Control> FlattenChildren<T>(this Control control)
        {
            return control.FlattenChildren().OfType<T>().Cast<Control>();
        }

        public static IEnumerable<Control> FlattenChildren(this Control control)
        {
            var children = control.Controls.Cast<Control>();
            return children.SelectMany(c => FlattenChildren(c)).Concat(children);
        }
    }
}
