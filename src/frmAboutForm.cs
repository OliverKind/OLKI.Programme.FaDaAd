﻿/*
 * FaDaAd - FastDateAdjust
 * 
 * Copyright:   Oliver Kind - 2021
 * License:     LGPL
 * 
 * Desctiption:
 * A form to show informations about the application
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
using System.Reflection;
using System.Windows.Forms;

namespace OLKI.Programme.FaDaAd.src
{
    /// <summary>
    /// A form to show informations about the application
    /// </summary>
    internal partial class AboutForm : Form
    {
        #region Constants
        /// <summary>
        /// Specifies the name of the application version
        /// </summary>
        private const string VERSION_NAME = "Peter";
        #endregion

        #region Properties
        /// <summary>
        /// Get the title information from assembly settiongs
        /// </summary>
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Get the version information from assembly settiongs
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Get the description from assembly settiongs
        /// </summary>
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        /// <summary>
        /// Get the product information from assembly settiongs
        /// </summary>
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        /// <summary>
        /// Get the copyright information from assembly settiongs
        /// </summary>
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /// <summary>
        /// Get the company information from assembly settiongs
        /// </summary>
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region Methods
        internal AboutForm()
        {
            InitializeComponent();
            this.Text = String.Format(this.Text, AssemblyTitle);
            this.LblProductName.Text = string.Format(this.LblProductName.Text, AssemblyProduct);
            this.LblVersion.Text = String.Format(this.LblVersion.Text, new object[] { this.AssemblyVersion, VERSION_NAME });
            this.LblCopyright.Text = string.Format(this.LblCopyright.Text, AssemblyCopyright);
            this.LblCompanyName.Text = string.Format(this.LblCompanyName.Text, AssemblyCompany);
            this.textBoxDescription.Text = AssemblyDescription;
        }

        private void BtnGoToLicenses_Click(object sender, EventArgs e)
        {
            Toolbox.DirectoryAndFile.Directory.Open(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Licenses\", false);
        }
        #endregion
    }
}