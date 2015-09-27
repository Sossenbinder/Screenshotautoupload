using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshotautoupload
{
    class AutostartHandler
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private void registerAutoStart()
        {
            rkApp.SetValue("Screenshotautoupload", Application.ExecutablePath.ToString());
        }

        private void unregisterAutoStart()
        {
            rkApp.DeleteValue("Screenshotautoupload", false);
        }

        public void handleAutoStartState(bool autoStartState)
        {
            Properties.Settings.Default.autoStart = autoStartState;
            Properties.Settings.Default.Save();

            if (autoStartState)
            {
                registerAutoStart();
            }
            else
            {
                unregisterAutoStart();
            }
        }
    }
}
