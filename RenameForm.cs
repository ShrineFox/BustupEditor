using DarkUI.Forms;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class RenameForm : DarkForm
    {
        public string RenameText
        {
            get;
            private set;
        }

        public RenameForm(string text)
        {
            InitializeComponent();
            this.metroSetTextBox_NewName.Text = text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            RenameText = metroSetTextBox_NewName.Text;
            this.DialogResult = DialogResult.OK;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}