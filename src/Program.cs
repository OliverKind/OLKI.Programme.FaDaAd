/*
 * Filename:      Program.cs
 * Created:       2018-12-24
 * Last modified: 2018-12-24
 * Copyright:     Oliver Kind - 2018
 * 
 * File Content:
 * - Methodes
 *  1. Main - Application entry point
 * 
 * Desctiption:
 * Root object of the application
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.FDA
{
    /// <summary>
    /// Root object of the application
    /// </summary>
    static class Program
    {
        #region Constants
        /// <summary>
        /// Root path in registry HKEY_CURRENT_USER
        /// </summary>
        const string REGISTRY_USER_ROOT = "HKEY_CURRENT_USER";
        /// <summary>
        /// Key where the settings file path should been stored in registry
        /// </summary>
        const string REGISTRY_SETTINGS_DIRECTORY_KEY = "SettingDir";
        #endregion

        #region Methodes
        /// <summary>
        /// Main entry point of the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Start Application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Save settings directory to registry
            FDA.AboutForm AboutForm = new FDA.AboutForm();
            string RegistryPath = string.Empty;

            System.Configuration.Configuration Config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoaming);
            string[] FilePathSplit = Config.FilePath.Split('\\');
            string ConigFilePathRootDir = string.Empty;
            for (int i = 0; i < FilePathSplit.Length - 2; i++)
            {
                ConigFilePathRootDir += FilePathSplit[i];
                ConigFilePathRootDir += '\\';
            }
            RegistryPath += REGISTRY_USER_ROOT + '\\';
            RegistryPath += "Software" + '\\';
            RegistryPath += AboutForm.CompanyName + '\\';
            RegistryPath += AboutForm.ProductName + '\\';
            Microsoft.Win32.Registry.SetValue(RegistryPath, REGISTRY_SETTINGS_DIRECTORY_KEY, ConigFilePathRootDir);

            // Upgrade Settings
            if (!FDA.Properties.Settings.Default.SettingsUpgradet)
            {
                FDA.Properties.Settings.Default.Upgrade();
                FDA.Properties.Settings.Default.SettingsUpgradet = true;
                FDA.Properties.Settings.Default.Save();
            }

            // Show MainForm
            Application.Run(new MainForm());
        }
        #endregion
    }
}