namespace BustupParamEditorGUI
{
    partial class AddParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParam));
            this.numUpDwn_CharaID = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_ExpressionID = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_OutfitID = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_CharaID = new System.Windows.Forms.Label();
            this.lbl_ExpressionID = new System.Windows.Forms.Label();
            this.lbl_OutfitID = new System.Windows.Forms.Label();
            this.checkBox_CreateBin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CharaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_ExpressionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OutfitID)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDwn_CharaID
            // 
            this.numUpDwn_CharaID.Location = new System.Drawing.Point(12, 26);
            this.numUpDwn_CharaID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_CharaID.Name = "numUpDwn_CharaID";
            this.numUpDwn_CharaID.Size = new System.Drawing.Size(62, 20);
            this.numUpDwn_CharaID.TabIndex = 0;
            this.numUpDwn_CharaID.ValueChanged += new System.EventHandler(this.CharacterID_ValueChanged);
            // 
            // numUpDwn_ExpressionID
            // 
            this.numUpDwn_ExpressionID.Location = new System.Drawing.Point(102, 26);
            this.numUpDwn_ExpressionID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_ExpressionID.Name = "numUpDwn_ExpressionID";
            this.numUpDwn_ExpressionID.Size = new System.Drawing.Size(62, 20);
            this.numUpDwn_ExpressionID.TabIndex = 1;
            this.numUpDwn_ExpressionID.ValueChanged += new System.EventHandler(this.ExpressionID_ValueChanged);
            // 
            // numUpDwn_OutfitID
            // 
            this.numUpDwn_OutfitID.Location = new System.Drawing.Point(189, 26);
            this.numUpDwn_OutfitID.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDwn_OutfitID.Name = "numUpDwn_OutfitID";
            this.numUpDwn_OutfitID.Size = new System.Drawing.Size(62, 20);
            this.numUpDwn_OutfitID.TabIndex = 2;
            this.numUpDwn_OutfitID.ValueChanged += new System.EventHandler(this.OutfitID_ValueChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Add.Location = new System.Drawing.Point(176, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add Entry";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.AddEntry);
            // 
            // lbl_CharaID
            // 
            this.lbl_CharaID.AutoSize = true;
            this.lbl_CharaID.Location = new System.Drawing.Point(7, 9);
            this.lbl_CharaID.Name = "lbl_CharaID";
            this.lbl_CharaID.Size = new System.Drawing.Size(67, 13);
            this.lbl_CharaID.TabIndex = 4;
            this.lbl_CharaID.Text = "Character ID";
            // 
            // lbl_ExpressionID
            // 
            this.lbl_ExpressionID.AutoSize = true;
            this.lbl_ExpressionID.Location = new System.Drawing.Point(97, 9);
            this.lbl_ExpressionID.Name = "lbl_ExpressionID";
            this.lbl_ExpressionID.Size = new System.Drawing.Size(72, 13);
            this.lbl_ExpressionID.TabIndex = 5;
            this.lbl_ExpressionID.Text = "Expression ID";
            // 
            // lbl_OutfitID
            // 
            this.lbl_OutfitID.AutoSize = true;
            this.lbl_OutfitID.Location = new System.Drawing.Point(184, 9);
            this.lbl_OutfitID.Name = "lbl_OutfitID";
            this.lbl_OutfitID.Size = new System.Drawing.Size(46, 13);
            this.lbl_OutfitID.TabIndex = 6;
            this.lbl_OutfitID.Text = "Outfit ID";
            // 
            // checkBox_CreateBin
            // 
            this.checkBox_CreateBin.AutoSize = true;
            this.checkBox_CreateBin.Checked = true;
            this.checkBox_CreateBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CreateBin.Location = new System.Drawing.Point(10, 58);
            this.checkBox_CreateBin.Name = "checkBox_CreateBin";
            this.checkBox_CreateBin.Size = new System.Drawing.Size(143, 17);
            this.checkBox_CreateBin.TabIndex = 7;
            this.checkBox_CreateBin.Text = "Create b000_000_00.bin";
            this.checkBox_CreateBin.UseVisualStyleBackColor = true;
            // 
            // AddParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 89);
            this.Controls.Add(this.checkBox_CreateBin);
            this.Controls.Add(this.lbl_OutfitID);
            this.Controls.Add(this.lbl_ExpressionID);
            this.Controls.Add(this.lbl_CharaID);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.numUpDwn_OutfitID);
            this.Controls.Add(this.numUpDwn_ExpressionID);
            this.Controls.Add(this.numUpDwn_CharaID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddParam";
            this.Text = "Add Parameter Entry...";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CharaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_ExpressionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OutfitID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDwn_CharaID;
        private System.Windows.Forms.NumericUpDown numUpDwn_ExpressionID;
        private System.Windows.Forms.NumericUpDown numUpDwn_OutfitID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_CharaID;
        private System.Windows.Forms.Label lbl_ExpressionID;
        private System.Windows.Forms.Label lbl_OutfitID;
        private System.Windows.Forms.CheckBox checkBox_CreateBin;
    }
}