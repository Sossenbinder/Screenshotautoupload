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
            this.imgurCheckBox = new System.Windows.Forms.CheckBox();
            this.keyChoiceBox = new System.Windows.Forms.ComboBox();
            this.keyChoiceLabel = new System.Windows.Forms.Label();
            this.imgurLinkLabel = new System.Windows.Forms.Label();
            this.imgurLinkTextbox = new System.Windows.Forms.RichTextBox();
            this.activationAltLabel = new System.Windows.Forms.Label();
            this.activationShiftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgurCheckBox
            // 
            this.imgurCheckBox.AutoSize = true;
            this.imgurCheckBox.Location = new System.Drawing.Point(12, 54);
            this.imgurCheckBox.Name = "imgurCheckBox";
            this.imgurCheckBox.Size = new System.Drawing.Size(216, 21);
            this.imgurCheckBox.TabIndex = 0;
            this.imgurCheckBox.Text = "Upload to Imgur automatically";
            this.imgurCheckBox.UseVisualStyleBackColor = true;
            this.imgurCheckBox.CheckedChanged += new System.EventHandler(this.imgurCheckBox_CheckedChanged);
            // 
            // keyChoiceBox
            // 
            this.keyChoiceBox.FormattingEnabled = true;
            this.keyChoiceBox.Location = new System.Drawing.Point(115, 6);
            this.keyChoiceBox.Name = "keyChoiceBox";
            this.keyChoiceBox.Size = new System.Drawing.Size(121, 24);
            this.keyChoiceBox.TabIndex = 1;
            this.keyChoiceBox.SelectedIndexChanged += new System.EventHandler(this.keyChoiceBox_SelectedIndexChanged);
            // 
            // keyChoiceLabel
            // 
            this.keyChoiceLabel.AutoSize = true;
            this.keyChoiceLabel.Location = new System.Drawing.Point(12, 9);
            this.keyChoiceLabel.Name = "keyChoiceLabel";
            this.keyChoiceLabel.Size = new System.Drawing.Size(97, 17);
            this.keyChoiceLabel.TabIndex = 2;
            this.keyChoiceLabel.Text = "Activation Key";
            // 
            // imgurLinkLabel
            // 
            this.imgurLinkLabel.AutoSize = true;
            this.imgurLinkLabel.Location = new System.Drawing.Point(9, 200);
            this.imgurLinkLabel.Name = "imgurLinkLabel";
            this.imgurLinkLabel.Size = new System.Drawing.Size(38, 17);
            this.imgurLinkLabel.TabIndex = 4;
            this.imgurLinkLabel.Text = "Link:";
            // 
            // imgurLinkTextbox
            // 
            this.imgurLinkTextbox.Location = new System.Drawing.Point(50, 197);
            this.imgurLinkTextbox.Name = "imgurLinkTextbox";
            this.imgurLinkTextbox.Size = new System.Drawing.Size(292, 44);
            this.imgurLinkTextbox.TabIndex = 5;
            this.imgurLinkTextbox.Text = "";
            this.imgurLinkTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.imgurLinkTextbox_LinkClicked);
            this.imgurLinkTextbox.DoubleClick += new System.EventHandler(this.imgurLinkTextbox_DoubleClick);
            // 
            // activationAltLabel
            // 
            this.activationAltLabel.AutoSize = true;
            this.activationAltLabel.Location = new System.Drawing.Point(239, 9);
            this.activationAltLabel.Name = "activationAltLabel";
            this.activationAltLabel.Size = new System.Drawing.Size(46, 17);
            this.activationAltLabel.TabIndex = 6;
            this.activationAltLabel.Text = "+ ALT";
            // 
            // activationShiftLabel
            // 
            this.activationShiftLabel.AutoSize = true;
            this.activationShiftLabel.Location = new System.Drawing.Point(281, 9);
            this.activationShiftLabel.Name = "activationShiftLabel";
            this.activationShiftLabel.Size = new System.Drawing.Size(59, 17);
            this.activationShiftLabel.TabIndex = 7;
            this.activationShiftLabel.Text = "+ SHIFT";
            // 
            // ScreenshotAutoupload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.activationShiftLabel);
            this.Controls.Add(this.activationAltLabel);
            this.Controls.Add(this.imgurLinkTextbox);
            this.Controls.Add(this.imgurLinkLabel);
            this.Controls.Add(this.keyChoiceLabel);
            this.Controls.Add(this.keyChoiceBox);
            this.Controls.Add(this.imgurCheckBox);
            this.Name = "ScreenshotAutoupload";
            this.Text = "ScreenshotAutoupload";
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

    }
}

