namespace SM_FlickShoot
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.customAngle = new System.Windows.Forms.NumericUpDown();
            this.cbShootBefore = new System.Windows.Forms.CheckBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(12, 12);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Location = new System.Drawing.Point(115, 12);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.lblAngle);
            this.gbSettings.Controls.Add(this.txtKey);
            this.gbSettings.Controls.Add(this.cbShootBefore);
            this.gbSettings.Controls.Add(this.customAngle);
            this.gbSettings.Enabled = false;
            this.gbSettings.Location = new System.Drawing.Point(12, 41);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(178, 95);
            this.gbSettings.TabIndex = 3;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // customAngle
            // 
            this.customAngle.Location = new System.Drawing.Point(49, 18);
            this.customAngle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.customAngle.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.customAngle.Name = "customAngle";
            this.customAngle.Size = new System.Drawing.Size(57, 20);
            this.customAngle.TabIndex = 3;
            this.customAngle.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // cbShootBefore
            // 
            this.cbShootBefore.AutoSize = true;
            this.cbShootBefore.Location = new System.Drawing.Point(6, 44);
            this.cbShootBefore.Name = "cbShootBefore";
            this.cbShootBefore.Size = new System.Drawing.Size(163, 17);
            this.cbShootBefore.TabIndex = 4;
            this.cbShootBefore.Text = "Shoot before changing angle";
            this.cbShootBefore.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtKey.Location = new System.Drawing.Point(6, 67);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(166, 20);
            this.txtKey.TabIndex = 5;
            this.txtKey.Text = "Q";
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_KeyDown);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(6, 20);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(37, 13);
            this.lblAngle.TabIndex = 6;
            this.lblAngle.Text = "Angle:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 141);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM FS Hack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbShootBefore;
        private System.Windows.Forms.NumericUpDown customAngle;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblAngle;
    }
}

