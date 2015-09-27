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
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private NotifyIcon icon;
        private AutostartHandler autostart;

        private bool sicEnabled = false;

        public ScreenshotAutoupload()
        {
            InitializeComponent();

            screen = new ScreenshotCreator();
            upload = new ScreenshotUploader();
            autostart = new AutostartHandler();  

            initSettings();
        }

        private void initSettings()
        {
            this.trayIcon = generateNotifyIcon();

            this.imgurCheckBox.Checked = Properties.Settings.Default.imgurAutoupload;
            this.clipBoardCheckBox.Checked = Properties.Settings.Default.clipBoardAutoCopySettings;
            this.autoStartCheckBox.Checked = Properties.Settings.Default.autoStart;

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

        private ContextMenu generateContextMenu()
        {
            ContextMenu trayMenu = new ContextMenu();

            trayMenu.MenuItems.Add("Open", focusApplication);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Exit", exitProgram);

            return trayMenu;
        }

        private void focusApplication(object sender, EventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
            this.Focus();
            icon.Visible = false;
        }

        private void exitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private NotifyIcon generateNotifyIcon()
        {
            icon = new NotifyIcon();

            icon.Text = "ScreenshotAutoupload";
            icon.Icon = new Icon(Properties.Resources.imgur, 40, 40);

            icon.ContextMenu = generateContextMenu();
            icon.DoubleClick += new System.EventHandler(focusApplication);

            icon.Visible = false;

            return icon;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
            {
                Thread handleHotkeyThread = new Thread(HandleHotkey);
                handleHotkeyThread.SetApartmentState(ApartmentState.STA);
                handleHotkeyThread.Start();
            }
            base.WndProc(ref m);
        }

        public void HandleHotkey()
        {
            ImgurResponseModel imgurResponse = null;
            Thread loadingProgress = new Thread(loadingProgressNotification);
            loadingProgress.Start();

            string screenshotPath = screen.makeScreenshot();

            if (this.imgurCheckBox.Checked)
            {
                imgurResponse = upload.uploadScreenshot(screenshotPath);
            }

            loadingProgress.Abort();

            this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Clear()));

            if (this.imgurCheckBox.Checked)
            {
                this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Text = imgurResponse.link));

                if (this.clipBoardCheckBox.Checked)
                {
                    Clipboard.SetText(imgurResponse.link);
                }
            }
            else
            {
                this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Text = "Not available"));
            }
        }

        private void loadingProgressNotification()
        {
            while (true)
            {
                for (int i = 1; i <= 5; i++)
                {
                    this.imgurLinkTextbox.Invoke(new Action(() => this.imgurLinkTextbox.Text = "Loading " + String.Concat(Enumerable.Repeat(".", i))));
                    Thread.Sleep(500);
                }
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

        private void clipBoardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.clipBoardAutoCopySettings = this.clipBoardCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ScreenshotAutoupload_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                icon.Visible = true;
            }
        }

        private void autoStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            autostart.handleAutoStartState(this.autoStartCheckBox.Checked);
        }
    }
}
