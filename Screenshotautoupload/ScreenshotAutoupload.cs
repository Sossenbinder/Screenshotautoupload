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

namespace Screenshotautoupload
{
    public partial class ScreenshotAutoupload : Form
    {
        private Hotkeys.GlobalHotkey ghk;
        private ScreenshotCreator screen;
        private ScreenshotUploader upload;

        public ScreenshotAutoupload()
        {
            InitializeComponent();

            ghk = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.O, this);
            screen = new ScreenshotCreator();
            upload = new ScreenshotUploader();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        public void HandleHotkey()
        {
            string screenshotPath = screen.makeScreenshot();

            if (this.imgurCheckBox.Checked)
            {
                ImgurResponseModel imgurResponse = upload.uploadScreenshot(screenshotPath);
            }
        }

        private void ScreenshotAutoupload_Load(object sender, EventArgs e)
        {
            ghk.Register();
        }

        private void imgurCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
