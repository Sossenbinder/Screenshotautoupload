using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkeys;
using System.Threading;

namespace Screenshotautoupload
{
    public partial class ScreenshotAutoupload : Form
    {
        private Hotkeys.GlobalHotkey ghk;
        private ScreenshotCreator screen;
        private ScreenshotUploader upload;

        private bool sicEnabled = false;

        public ScreenshotAutoupload()
        {
            InitializeComponent();
            initSettings();

            screen = new ScreenshotCreator();
            upload = new ScreenshotUploader();
        }

        private void initSettings()
        {

            this.imgurCheckBox.Checked = Properties.Settings.Default.imgurAutoupload;

            List<Keys> itemSource = new List<Keys> { Keys.A, Keys.B, Keys.C, Keys.D, Keys.E,
                                                     Keys.F, Keys.G, Keys.H, Keys.I, Keys.J,
                                                     Keys.K, Keys.L, Keys.M, Keys.N, Keys.O,
                                                     Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T,
                                                     Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y,
                                                     Keys.Z,};
            this.keyChoiceBox.DataSource = itemSource;
            this.keyChoiceBox.SelectedItem = Properties.Settings.Default.activationKey;

            ghk = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, (Keys)this.keyChoiceBox.SelectedItem, this);
            ghk.Register();

            sicEnabled = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
            {
                Thread handleHotkeyThread = new Thread(HandleHotkey);
                handleHotkeyThread.Start();
            }
            base.WndProc(ref m);
        }

        public void HandleHotkey()
        {
            string screenshotPath = screen.makeScreenshot();

            if (this.imgurCheckBox.Checked)
            {
                ImgurResponseModel imgurResponse = upload.uploadScreenshot(screenshotPath);
                this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Clear()));
                this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Text = imgurResponse.link));
            }
        }

        private void imgurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.imgurAutoupload = this.imgurCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void imgurLinkTextbox_DoubleClick(object sender, EventArgs e)
        {
            this.imgurLinkTextbox.SelectAll();
        }

        private void imgurLinkTextbox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void keyChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sicEnabled)
            {

                ghk.Unregiser();
                ghk = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, (Keys)this.keyChoiceBox.SelectedItem, this);
                ghk.Register();

                Properties.Settings.Default.activationKey = (Keys)this.keyChoiceBox.SelectedItem;
                Properties.Settings.Default.Save();
            }
        }
    }
}
