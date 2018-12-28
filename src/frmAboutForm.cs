/*
 * Filename:      frmAboutForm.cs
 * Created:       2018-12-24
 * Last modified: 2018-12-24
 * Copyright:     Oliver Kind - 2018
 * 
 * File Content:
 * - Constants
 * - Properties
 * - Methodes
 *  1. AboutForm - Constructor
 * 
 * Desctiption:
 * A form to show informations about the application
 * 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OLKI.Programme.FDA
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
        #region Assemblyattributaccessoren
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
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
            OLKI.Tools.CommonTools.DirectoryAndFile.Directory.Open(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Licenses\", false);
        }
        #endregion
    }
}