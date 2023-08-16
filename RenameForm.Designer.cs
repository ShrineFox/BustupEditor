using DarkUI.Controls;
using DarkUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace BustupEditor
{
    partial class RenameForm : DarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameForm));
            this.metroSetLabel_ProjectName = new DarkUI.Controls.DarkLabel();
            this.metroSetTextBox_NewName = new DarkUI.Controls.DarkTextBox();
            this.tableLayoutPanel_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProjectName = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetButton_Cancel = new DarkUI.Controls.DarkButton();
            this.metroSetButton_Save = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel_Settings.SuspendLayout();
            this.tableLayoutPanel_ProjectName.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetLabel_ProjectName
            // 
            this.metroSetLabel_ProjectName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroSetLabel_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_ProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.metroSetLabel_ProjectName.Location = new System.Drawing.Point(2, 36);
            this.metroSetLabel_ProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel_ProjectName.Name = "metroSetLabel_ProjectName";
            this.metroSetLabel_ProjectName.Size = new System.Drawing.Size(93, 25);
            this.metroSetLabel_ProjectName.TabIndex = 25;
            this.metroSetLabel_ProjectName.Text = "New Name:";
            this.metroSetLabel_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroSetTextBox_NewName
            // 
            this.metroSetTextBox_NewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetTextBox_NewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.metroSetTextBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroSetTextBox_NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_NewName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.metroSetTextBox_NewName.Location = new System.Drawing.Point(99, 35);
            this.metroSetTextBox_NewName.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetTextBox_NewName.Name = "metroSetTextBox_NewName";
            this.metroSetTextBox_NewName.Size = new System.Drawing.Size(388, 26);
            this.metroSetTextBox_NewName.TabIndex = 26;
            // 
            // tableLayoutPanel_Settings
            // 
            this.tableLayoutPanel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel_Settings.ColumnCount = 1;
            this.tableLayoutPanel_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Settings.Controls.Add(this.tableLayoutPanel_ProjectName, 0, 0);
            this.tableLayoutPanel_Settings.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel_Settings.Location = new System.Drawing.Point(8, 9);
            this.tableLayoutPanel_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Settings.Name = "tableLayoutPanel_Settings";
            this.tableLayoutPanel_Settings.RowCount = 4;
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Settings.Size = new System.Drawing.Size(493, 156);
            this.tableLayoutPanel_Settings.TabIndex = 28;
            // 
            // tableLayoutPanel_ProjectName
            // 
            this.tableLayoutPanel_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel_ProjectName.ColumnCount = 2;
            this.tableLayoutPanel_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetTextBox_NewName, 1, 0);
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetLabel_ProjectName, 0, 0);
            this.tableLayoutPanel_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProjectName.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_ProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_ProjectName.Name = "tableLayoutPanel_ProjectName";
            this.tableLayoutPanel_ProjectName.RowCount = 1;
            this.tableLayoutPanel_ProjectName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProjectName.Size = new System.Drawing.Size(489, 97);
            this.tableLayoutPanel_ProjectName.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.metroSetButton_Cancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroSetButton_Save, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 103);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(489, 51);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // metroSetButton_Cancel
            // 
            this.metroSetButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroSetButton_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Cancel.Location = new System.Drawing.Point(295, 2);
            this.metroSetButton_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_Cancel.Name = "metroSetButton_Cancel";
            this.metroSetButton_Cancel.Padding = new System.Windows.Forms.Padding(3);
            this.metroSetButton_Cancel.Size = new System.Drawing.Size(93, 47);
            this.metroSetButton_Cancel.TabIndex = 0;
            this.metroSetButton_Cancel.Text = "Cancel";
            this.metroSetButton_Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // metroSetButton_Save
            // 
            this.metroSetButton_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Save.Location = new System.Drawing.Point(392, 2);
            this.metroSetButton_Save.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetButton_Save.Name = "metroSetButton_Save";
            this.metroSetButton_Save.Padding = new System.Windows.Forms.Padding(3);
            this.metroSetButton_Save.Size = new System.Drawing.Size(95, 47);
            this.metroSetButton_Save.TabIndex = 1;
            this.metroSetButton_Save.Text = "Save";
            this.metroSetButton_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RenameForm
            // 
            this.AcceptButton = this.metroSetButton_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroSetButton_Cancel;
            this.ClientSize = new System.Drawing.Size(509, 179);
            this.Controls.Add(this.tableLayoutPanel_Settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RenameForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BustupEditor - Set New Name";
            this.tableLayoutPanel_Settings.ResumeLayout(false);
            this.tableLayoutPanel_ProjectName.ResumeLayout(false);
            this.tableLayoutPanel_ProjectName.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkLabel metroSetLabel_ProjectName;
        private DarkTextBox metroSetTextBox_NewName;
        private TableLayoutPanel tableLayoutPanel_Settings;
        private TableLayoutPanel tableLayoutPanel_ProjectName;
        private TableLayoutPanel tableLayoutPanel3;
        private DarkButton metroSetButton_Cancel;
        private DarkButton metroSetButton_Save;
    }
}