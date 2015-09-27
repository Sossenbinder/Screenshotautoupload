namespace Screenshotautoupload
{
    partial class ScreenshotAutoupload
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotAutoupload));
            this.imgurCheckBox = new System.Windows.Forms.CheckBox();
            this.keyChoiceBox = new System.Windows.Forms.ComboBox();
            this.keyChoiceLabel = new System.Windows.Forms.Label();
            this.imgurLinkLabel = new System.Windows.Forms.Label();
            this.imgurLinkTextbox = new System.Windows.Forms.RichTextBox();
            this.activationAltLabel = new System.Windows.Forms.Label();
            this.activationShiftLabel = new System.Windows.Forms.Label();
            this.clipBoardCheckBox = new System.Windows.Forms.CheckBox();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // imgurCheckBox
            // 
            this.imgurCheckBox.AutoSize = true;
            this.imgurCheckBox.Location = new System.Drawing.Point(9, 44);
            this.imgurCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgurCheckBox.Name = "imgurCheckBox";
            this.imgurCheckBox.Size = new System.Drawing.Size(192, 19);
            this.imgurCheckBox.TabIndex = 0;
            this.imgurCheckBox.Text = "Upload to Imgur automatically";
            this.imgurCheckBox.UseVisualStyleBackColor = true;
            this.imgurCheckBox.CheckedChanged += new System.EventHandler(this.imgurCheckBox_CheckedChanged);
            // 
            // keyChoiceBox
            // 
            this.keyChoiceBox.FormattingEnabled = true;
            this.keyChoiceBox.Location = new System.Drawing.Point(86, 5);
            this.keyChoiceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyChoiceBox.Name = "keyChoiceBox";
            this.keyChoiceBox.Size = new System.Drawing.Size(92, 21);
            this.keyChoiceBox.TabIndex = 1;
            this.keyChoiceBox.SelectedIndexChanged += new System.EventHandler(this.keyChoiceBox_SelectedIndexChanged);
            // 
            // keyChoiceLabel
            // 
            this.keyChoiceLabel.AutoSize = true;
            this.keyChoiceLabel.Location = new System.Drawing.Point(3, 7);
            this.keyChoiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyChoiceLabel.Name = "keyChoiceLabel";
            this.keyChoiceLabel.Size = new System.Drawing.Size(81, 15);
            this.keyChoiceLabel.TabIndex = 2;
            this.keyChoiceLabel.Text = "Activation Key";
            // 
            // imgurLinkLabel
            // 
            this.imgurLinkLabel.AutoSize = true;
            this.imgurLinkLabel.Location = new System.Drawing.Point(7, 162);
            this.imgurLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imgurLinkLabel.Name = "imgurLinkLabel";
            this.imgurLinkLabel.Size = new System.Drawing.Size(33, 15);
            this.imgurLinkLabel.TabIndex = 4;
            this.imgurLinkLabel.Text = "Link:";
            // 
            // imgurLinkTextbox
            // 
            this.imgurLinkTextbox.Location = new System.Drawing.Point(38, 160);
            this.imgurLinkTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgurLinkTextbox.Name = "imgurLinkTextbox";
            this.imgurLinkTextbox.Size = new System.Drawing.Size(220, 36);
            this.imgurLinkTextbox.TabIndex = 5;
            this.imgurLinkTextbox.Text = "";
            this.imgurLinkTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.imgurLinkTextbox_LinkClicked);
            this.imgurLinkTextbox.DoubleClick += new System.EventHandler(this.imgurLinkTextbox_DoubleClick);
            // 
            // activationAltLabel
            // 
            this.activationAltLabel.AutoSize = true;
            this.activationAltLabel.Location = new System.Drawing.Point(179, 7);
            this.activationAltLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activationAltLabel.Name = "activationAltLabel";
            this.activationAltLabel.Size = new System.Drawing.Size(38, 15);
            this.activationAltLabel.TabIndex = 6;
            this.activationAltLabel.Text = "+ ALT";
            // 
            // activationShiftLabel
            // 
            this.activationShiftLabel.AutoSize = true;
            this.activationShiftLabel.Location = new System.Drawing.Point(211, 7);
            this.activationShiftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activationShiftLabel.Name = "activationShiftLabel";
            this.activationShiftLabel.Size = new System.Drawing.Size(51, 15);
            this.activationShiftLabel.TabIndex = 7;
            this.activationShiftLabel.Text = "+ SHIFT";
            // 
            // clipBoardCheckBox
            // 
            this.clipBoardCheckBox.AutoSize = true;
            this.clipBoardCheckBox.Location = new System.Drawing.Point(9, 66);
            this.clipBoardCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clipBoardCheckBox.Name = "clipBoardCheckBox";
            this.clipBoardCheckBox.Size = new System.Drawing.Size(220, 19);
            this.clipBoardCheckBox.TabIndex = 8;
            this.clipBoardCheckBox.Text = "Copy link to clipboard automatically";
            this.clipBoardCheckBox.UseVisualStyleBackColor = true;
            this.clipBoardCheckBox.CheckedChanged += new System.EventHandler(this.clipBoardCheckBox_CheckedChanged);
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(9, 89);
            this.autoStartCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(191, 19);
            this.autoStartCheckBox.TabIndex = 9;
            this.autoStartCheckBox.Text = "Start this applet with Windows";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            this.autoStartCheckBox.CheckedChanged += new System.EventHandler(this.autoStartCheckBox_CheckedChanged);
            // 
            // ScreenshotAutoupload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 206);
            this.Controls.Add(this.autoStartCheckBox);
            this.Controls.Add(this.clipBoardCheckBox);
            this.Controls.Add(this.activationShiftLabel);
            this.Controls.Add(this.activationAltLabel);
            this.Controls.Add(this.imgurLinkTextbox);
            this.Controls.Add(this.imgurLinkLabel);
            this.Controls.Add(this.keyChoiceLabel);
            this.Controls.Add(this.keyChoiceBox);
            this.Controls.Add(this.imgurCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScreenshotAutoupload";
            this.Text = "ScreenshotAutoupload";
            this.Resize += new System.EventHandler(this.ScreenshotAutoupload_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox imgurCheckBox;
        private System.Windows.Forms.ComboBox keyChoiceBox;
        private System.Windows.Forms.Label keyChoiceLabel;
        private System.Windows.Forms.Label imgurLinkLabel;
        private System.Windows.Forms.RichTextBox imgurLinkTextbox;
        private System.Windows.Forms.Label activationAltLabel;
        private System.Windows.Forms.Label activationShiftLabel;
        private System.Windows.Forms.CheckBox clipBoardCheckBox;
        private System.Windows.Forms.CheckBox autoStartCheckBox;

    }
}

