﻿/*
 * FaDaAd - FastDateAdjust
 * 
 * Copyright:   Oliver Kind - 2021
 * License:     LGPL
 * 
 * Desctiption:
 * Root object of the application
 * 
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the LGPL General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * LGPL General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not check the GitHub-Repository.
 * 
 * */

using System;
using System.Windows.Forms;

namespace OLKI.Programme.FaDaAd.src
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
            AboutForm AboutForm = new AboutForm();
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
            if (!FaDaAd.Properties.Settings.Default.SettingsUpgradet)
            {
                FaDaAd.Properties.Settings.Default.Upgrade();
                FaDaAd.Properties.Settings.Default.SettingsUpgradet = true;
                FaDaAd.Properties.Settings.Default.Save();
            }

            // Show MainForm
            Application.Run(new MainForm());
        }
        #endregion
    }
}