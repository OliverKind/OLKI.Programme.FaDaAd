/*
 * FaDaAd - FastDateAdjust
 * 
 * Copyright:   Oliver Kind - 2021
 * License:     LGPL
 * 
 * Desctiption:
 * The MainForm of the application
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

using OLKI.Programme.FaDaAd.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace OLKI.Programme.FaDaAd.src
{
    /// <summary>
    /// The MainForm of the application
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constants
        /// <summary>
        /// Seperator behind original filname and random extension, to make a temporary copy of a file during changing date in exif data
        /// </summary>
        private const string TEMP_FILE_SEPERATOR = "__FaDaAd__";
        #endregion

        #region Methodes
        /// <summary>
        /// Initialise a new application MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.cboBase.SelectedIndex = 0;
            this.dtpReference_ValueChanged__dtpCorrect_ValueChanged(this, new EventArgs());
            this.chkCheckForAdminRightsOnStartup.Checked = Properties.Settings.Default.CheckForAdminRights;
        }

        /// <summary>
        /// Refresh the line of the selected item or items in ListView after item was changed manualy or by the batch process. Set CreationTime, LastWriteTime and Length. The Information will come prom the Tag, set bevor with the FileInfo in the calling method
        /// </summary>
        /// <param name="index">Index of the ListView Item to refresh</param>
        private void RefreshLine(int index)
        {
            FileInfo FileInfo = (FileInfo)this.slvItems.Items[index].Tag;

            this.slvItems.Items[index].SubItems[1].Text = FileInfo.CreationTime.ToString();
            this.slvItems.Items[index].SubItems[1].Tag = FileInfo.CreationTime.ToString();

            this.slvItems.Items[index].SubItems[2].Text = FileInfo.LastWriteTime.ToString();
            this.slvItems.Items[index].SubItems[2].Tag = FileInfo.LastWriteTime.ToString();

            this.slvItems.Items[index].SubItems[4].Text = Tools.CommonTools.DirectoryAndFile.FileSize.Convert(FileInfo.Length);
            this.slvItems.Items[index].SubItems[4].Tag = FileInfo.Length;
        }

        /// <summary>
        /// Set the specified Time to CreationTime in EXIF-Data of an specified file
        /// </summary>
        /// <param name="path">The address of a null-terminated string that specifies the path of the file to set CreationTime</param>
        /// <param name="creationTime">The time to set to CreationTime in EXIF-Data</param>
        /// <returns>True if the EXIF-Data was set successfully, otherwise false</returns>
        private bool SetExifData_CreationTime(string path, DateTime creationTime)
        {
            return this.SetExifData_CreationTime(path, creationTime.ToString("yyyy:MM:dd HH:mm:ss"));
        }
        /// <summary>
        /// Set the specified Time to CreationTime in EXIF-Data of an specified file
        /// </summary>
        /// <param name="path">The address of a null-terminated string that specifies the path of the file to set CreationTime</param>
        /// <param name="creationTime">The time to set to CreationTime in EXIF-Data</param>
        /// <returns>True if the EXIF-Data was set successfully, otherwise false</returns>
        private bool SetExifData_CreationTime(string path, string creationTime)
        {
            //http://www.awaresystems.be/imaging/tiff/tifftags/privateifd/exif.html
            creationTime += '\0';

            Encoding Encoding = Encoding.UTF8;
            //Create Temp File to read Data
            string TempFile = path + TEMP_FILE_SEPERATOR + Path.GetRandomFileName();
            Tools.CommonTools.DirectoryAndFile.File.Copy(path, TempFile);

            Image theImage = new Bitmap(1, 1);
            try
            {
                theImage = new Bitmap(TempFile);
                PropertyItem propItem__0x9003 = theImage.GetPropertyItem(0x9003);
                propItem__0x9003.Value = Encoding.GetBytes(creationTime);
                theImage.SetPropertyItem(propItem__0x9003);
                theImage.Save(path);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return false;
            }
            finally
            {
                theImage.Dispose();

                Tools.CommonTools.DirectoryAndFile.File.Delete(TempFile, false);
            }
            return true;
        }

        /// <summary>
        /// The the specified picture to specified PictureBox to show
        /// </summary>
        /// <param name="path">The address of a null-terminated string that specifies the path of the file to show in PictureBox</param>
        /// <param name="pictureBox">The PictureBox to show the picture in</param>
        private void SetPictureBoxImage(string picturePath, PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            try
            {
                FileStream fs = new System.IO.FileStream(picturePath, FileMode.Open, FileAccess.Read);
                try
                {
                    pictureBox.Image = Image.FromStream(fs);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print(ex.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
        }

        #region Form User Events
        #region Form Events
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckForAdminRights)
            {
                this.btnCheckForAdminRights_Click(sender, e, false);
            }
        }
        #endregion

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm AboutForm = new AboutForm();
            AboutForm.ShowDialog(this);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog()
            {
                FileName = string.Empty,
                Multiselect = true
            };

            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.btnClear_Click(sender, e);

                foreach (string Path in OpenFileDialog.FileNames)
                {
                    FileInfo FileInfo = new FileInfo(Path);

                    ListViewItem NewItem = new ListViewItem();

                    NewItem.SubItems.Add(FileInfo.CreationTime.ToString());
                    NewItem.SubItems[1].Tag = FileInfo.CreationTime;
                    NewItem.SubItems.Add(FileInfo.LastWriteTime.ToString());
                    NewItem.SubItems[2].Tag = FileInfo.LastWriteTime;
                    NewItem.SubItems.Add(FileInfo.Extension + "-Datei");
                    NewItem.SubItems.Add(OLKI.Tools.CommonTools.DirectoryAndFile.FileSize.Convert(FileInfo.Length));
                    NewItem.SubItems[4].Tag = FileInfo.Length;
                    NewItem.Tag = FileInfo;
                    NewItem.Text = FileInfo.Name;

                    this.slvItems.Items.Add(NewItem);
                }
            }
        }

        private void btnCheckForAdminRights_Click(object sender, EventArgs e)
        {
            this.btnCheckForAdminRights_Click(sender, e, true);
        }

        private void btnCheckForAdminRights_Click(object sender, EventArgs e, bool showMessageIfAdmin)
        {
            // Check for Admin Rights
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show(Stringtable._0x0003m, Stringtable._0x0003c, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (showMessageIfAdmin)
            {
                MessageBox.Show(Stringtable._0x0002m, Stringtable._0x0002c, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.slvItems.Items.Clear();
        }

        private void btnBatchStart_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                Cursor = Cursors.WaitCursor;
                this.txtExceptions.Text = string.Empty;
                this.pbaBatchProgress.Value = pbaBatchProgress.Minimum;
                this.pbaBatchProgress.Maximum = this.slvItems.Items.Count;

                this.pbaBatchProgress.Refresh();
                this.slvItems.Refresh();
                this.picPreview.Refresh();

                // Batch process
                for (int i = 0; i < this.slvItems.Items.Count; i++)
                {
                    FileInfo FileInfoC = ((FileInfo)slvItems.Items[i].Tag);
                    this.SetPictureBoxImage(FileInfoC.FullName, this.picPreview);

                    try
                    {
                        DateTime BaseTime = new DateTime();
                        switch (this.cboBase.SelectedIndex)
                        {
                            case 0:
                                BaseTime = FileInfoC.CreationTime;
                                break;
                            case 1:
                                BaseTime = FileInfoC.LastWriteTime;
                                break;
                            default:
                                break;
                        }

                        DateTime NewCreationTime = BaseTime.Add(dtpCorrect.Value - dtpReference.Value);
                        FileInfoC.CreationTime = NewCreationTime;

                        this.SetExifData_CreationTime(FileInfoC.FullName, FileInfoC.CreationTime);

                        FileInfoC.LastWriteTime = NewCreationTime;
                        this.RefreshLine(i);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print(ex.Message);
                        this.txtExceptions.Text += FileInfoC.FullName + "\r\n";
                    }
                    finally
                    {
                        this.pbaBatchProgress.Value = pbaBatchProgress.Value + 1;
                        this.pbaBatchProgress.Refresh();
                        this.slvItems.Refresh();
                        this.picPreview.Refresh();
                        Application.DoEvents();
                        Cursor = Cursors.WaitCursor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Stringtable._0x0001m, new object[] { ex.Message }), Stringtable._0x0001c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.picPreview.Image = null;
                Cursor = Cursors.Default;
                this.Enabled = true;
            }
        }

        private void cboBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.cboBase.SelectedIndex)
                {
                    case 0:
                        this.dtpReference.Value = ((FileInfo)this.dtpReference.Tag).CreationTime;
                        break;
                    case 1:
                        this.dtpReference.Value = ((FileInfo)this.dtpReference.Tag).LastWriteTime;
                        break;
                    default:
                        break;
                }
                this.dtpReference.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
        }

        private void chkCheckForAdminRightsOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckForAdminRights = this.chkCheckForAdminRightsOnStartup.Checked;
            Properties.Settings.Default.Save();
        }

        private void dtpReference_ValueChanged__dtpCorrect_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan TimeSpan = dtpCorrect.Value - dtpReference.Value;
            this.txtCorrection.Text = (this.dtpCorrect.Value - this.dtpReference.Value).ToString();
        }

        private void prgSingleMode_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (e.ChangedItem.Label.Equals("CreationTime", StringComparison.OrdinalIgnoreCase))
            {
                // Change JPEG-Attributes
                for (int i = 0; i < this.slvItems.Items.Count; i++)
                {
                    if (this.slvItems.Items[i].Selected)
                    {
                        FileInfo FileInfoC = ((FileInfo)this.slvItems.Items[i].Tag);

                        this.SetExifData_CreationTime(FileInfoC.FullName, (DateTime)e.ChangedItem.Value);
                        this.RefreshLine(i);
                    }
                }
            }
            this.prgSingleMode.Refresh();
        }

        private void slvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo[] FileInfoC = new FileInfo[slvItems.SelectedItems.Count];
            for (int i = 0; i < slvItems.SelectedItems.Count; i++)
            {
                FileInfoC[i] = (FileInfo)slvItems.SelectedItems[i].Tag;

                if (i == 0)
                {
                    this.dtpReference.Tag = FileInfoC[i];
                    this.cboBase_SelectedIndexChanged(sender, e);
                }
            }
            this.prgSingleMode.SelectedObjects = FileInfoC;

            if (slvItems.SelectedItems.Count == 1)
            {
                this.SetPictureBoxImage(((FileInfo)slvItems.SelectedItems[0].Tag).FullName, this.picPreview);
            }
            else
            {
                this.picPreview.Image = null;
            }
        }
        #endregion
        #endregion
    }
}