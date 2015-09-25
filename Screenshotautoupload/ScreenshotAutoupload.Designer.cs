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
            this.SuspendLayout();
            // 
            // imgurCheckBox
            // 
            this.imgurCheckBox.AutoSize = true;
            this.imgurCheckBox.Location = new System.Drawing.Point(401, 12);
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
            this.keyChoiceBox.Location = new System.Drawing.Point(112, 217);
            this.keyChoiceBox.Name = "keyChoiceBox";
            this.keyChoiceBox.Size = new System.Drawing.Size(121, 24);
            this.keyChoiceBox.TabIndex = 1;
            // 
            // keyChoiceLabel
            // 
            this.keyChoiceLabel.AutoSize = true;
            this.keyChoiceLabel.Location = new System.Drawing.Point(9, 220);
            this.keyChoiceLabel.Name = "keyChoiceLabel";
            this.keyChoiceLabel.Size = new System.Drawing.Size(97, 17);
            this.keyChoiceLabel.TabIndex = 2;
            this.keyChoiceLabel.Text = "Activation Key";
            // 
            // ScreenshotAutoupload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 253);
            this.Controls.Add(this.keyChoiceLabel);
            this.Controls.Add(this.keyChoiceBox);
            this.Controls.Add(this.imgurCheckBox);
            this.Name = "ScreenshotAutoupload";
            this.Text = "ScreenshotAutoupload";
            this.Load += new System.EventHandler(this.ScreenshotAutoupload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox imgurCheckBox;
        private System.Windows.Forms.ComboBox keyChoiceBox;
        private System.Windows.Forms.Label keyChoiceLabel;

    }
}

