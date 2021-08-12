namespace OLKI.Programme.FaDaAd.src
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grbExplorer = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.slvItems = new OLKI.Toolbox.Widgets.SortListView();
            this.Dateiname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tabpBatchMode = new System.Windows.Forms.TabPage();
            this.pbaBatchProgress = new System.Windows.Forms.ProgressBar();
            this.txtExceptions = new System.Windows.Forms.TextBox();
            this.lblExceptions = new System.Windows.Forms.Label();
            this.btnBatchStart = new System.Windows.Forms.Button();
            this.grbMoveData = new System.Windows.Forms.GroupBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.cboBase = new System.Windows.Forms.ComboBox();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.txtCorrection = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.dtpCorrect = new System.Windows.Forms.DateTimePicker();
            this.lblReference = new System.Windows.Forms.Label();
            this.dtpReference = new System.Windows.Forms.DateTimePicker();
            this.tabpSingleMode = new System.Windows.Forms.TabPage();
            this.prgSingleMode = new OLKI.Toolbox.Widgets.ReadOnlyPropertyGrid();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkCheckForAdminRightsOnStartup = new System.Windows.Forms.CheckBox();
            this.BTNCheckForAdminRights = new System.Windows.Forms.Button();
            this.grbExplorer.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tabpBatchMode.SuspendLayout();
            this.grbMoveData.SuspendLayout();
            this.tabpSingleMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // grbExplorer
            // 
            this.grbExplorer.Controls.Add(this.btnClear);
            this.grbExplorer.Controls.Add(this.btnBrowse);
            this.grbExplorer.Controls.Add(this.slvItems);
            this.grbExplorer.Location = new System.Drawing.Point(12, 12);
            this.grbExplorer.Name = "grbExplorer";
            this.grbExplorer.Size = new System.Drawing.Size(598, 627);
            this.grbExplorer.TabIndex = 0;
            this.grbExplorer.TabStop = false;
            this.grbExplorer.Text = "Dateien auswählen";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(471, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Liste leeren";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Bilder laden";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // slvItems
            // 
            this.slvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dateiname,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.slvItems.FullRowSelect = true;
            this.slvItems.GridLines = true;
            this.slvItems.HideSelection = false;
            this.slvItems.Location = new System.Drawing.Point(6, 54);
            this.slvItems.Name = "slvItems";
            this.slvItems.ShowGroups = false;
            this.slvItems.Size = new System.Drawing.Size(586, 567);
            this.slvItems.TabIndex = 2;
            this.slvItems.UseCompatibleStateImageBehavior = false;
            this.slvItems.View = System.Windows.Forms.View.Details;
            this.slvItems.SelectedIndexChanged += new System.EventHandler(this.slvItems_SelectedIndexChanged);
            // 
            // Dateiname
            // 
            this.Dateiname.Text = "Dateiname";
            this.Dateiname.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Erstelldatum";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Letzte Änderung";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Typ";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Größe";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tabpBatchMode);
            this.tabMode.Controls.Add(this.tabpSingleMode);
            this.tabMode.Location = new System.Drawing.Point(616, 12);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(281, 433);
            this.tabMode.TabIndex = 1;
            // 
            // tabpBatchMode
            // 
            this.tabpBatchMode.Controls.Add(this.pbaBatchProgress);
            this.tabpBatchMode.Controls.Add(this.txtExceptions);
            this.tabpBatchMode.Controls.Add(this.lblExceptions);
            this.tabpBatchMode.Controls.Add(this.btnBatchStart);
            this.tabpBatchMode.Controls.Add(this.grbMoveData);
            this.tabpBatchMode.Location = new System.Drawing.Point(4, 22);
            this.tabpBatchMode.Name = "tabpBatchMode";
            this.tabpBatchMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabpBatchMode.Size = new System.Drawing.Size(273, 407);
            this.tabpBatchMode.TabIndex = 1;
            this.tabpBatchMode.Text = "Stapelverarbeitung";
            this.tabpBatchMode.UseVisualStyleBackColor = true;
            // 
            // pbaBatchProgress
            // 
            this.pbaBatchProgress.Location = new System.Drawing.Point(6, 193);
            this.pbaBatchProgress.Name = "pbaBatchProgress";
            this.pbaBatchProgress.Size = new System.Drawing.Size(261, 18);
            this.pbaBatchProgress.TabIndex = 1;
            // 
            // txtExceptions
            // 
            this.txtExceptions.Location = new System.Drawing.Point(7, 230);
            this.txtExceptions.Multiline = true;
            this.txtExceptions.Name = "txtExceptions";
            this.txtExceptions.ReadOnly = true;
            this.txtExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExceptions.Size = new System.Drawing.Size(260, 171);
            this.txtExceptions.TabIndex = 3;
            this.txtExceptions.WordWrap = false;
            // 
            // lblExceptions
            // 
            this.lblExceptions.AutoSize = true;
            this.lblExceptions.Location = new System.Drawing.Point(6, 214);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(146, 13);
            this.lblExceptions.TabIndex = 2;
            this.lblExceptions.Text = "Fehler bei folgenden Dateien:";
            // 
            // btnBatchStart
            // 
            this.btnBatchStart.Location = new System.Drawing.Point(6, 141);
            this.btnBatchStart.Name = "btnBatchStart";
            this.btnBatchStart.Size = new System.Drawing.Size(261, 46);
            this.btnBatchStart.TabIndex = 0;
            this.btnBatchStart.Text = "Erstelldatum aller geladenen Dateien um ermittelte Zeitspanne verändern";
            this.btnBatchStart.UseVisualStyleBackColor = true;
            this.btnBatchStart.Click += new System.EventHandler(this.btnBatchStart_Click);
            // 
            // grbMoveData
            // 
            this.grbMoveData.Controls.Add(this.lblBase);
            this.grbMoveData.Controls.Add(this.cboBase);
            this.grbMoveData.Controls.Add(this.lblCorrection);
            this.grbMoveData.Controls.Add(this.txtCorrection);
            this.grbMoveData.Controls.Add(this.lblCorrect);
            this.grbMoveData.Controls.Add(this.dtpCorrect);
            this.grbMoveData.Controls.Add(this.lblReference);
            this.grbMoveData.Controls.Add(this.dtpReference);
            this.grbMoveData.Location = new System.Drawing.Point(6, 6);
            this.grbMoveData.Name = "grbMoveData";
            this.grbMoveData.Size = new System.Drawing.Size(261, 129);
            this.grbMoveData.TabIndex = 0;
            this.grbMoveData.TabStop = false;
            this.grbMoveData.Text = "Korrekturzeitraum";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(7, 22);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(35, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Basis:";
            // 
            // cboBase
            // 
            this.cboBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBase.FormattingEnabled = true;
            this.cboBase.Items.AddRange(new object[] {
            "CreationTime",
            "LastWriteTime"});
            this.cboBase.Location = new System.Drawing.Point(95, 19);
            this.cboBase.Name = "cboBase";
            this.cboBase.Size = new System.Drawing.Size(160, 21);
            this.cboBase.TabIndex = 1;
            this.cboBase.SelectedIndexChanged += new System.EventHandler(this.cboBase_SelectedIndexChanged);
            // 
            // lblCorrection
            // 
            this.lblCorrection.AutoSize = true;
            this.lblCorrection.Location = new System.Drawing.Point(7, 101);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(73, 13);
            this.lblCorrection.TabIndex = 6;
            this.lblCorrection.Text = "Korrekturwert:";
            // 
            // txtCorrection
            // 
            this.txtCorrection.Location = new System.Drawing.Point(95, 98);
            this.txtCorrection.Name = "txtCorrection";
            this.txtCorrection.ReadOnly = true;
            this.txtCorrection.Size = new System.Drawing.Size(160, 20);
            this.txtCorrection.TabIndex = 7;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(7, 78);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(82, 13);
            this.lblCorrect.TabIndex = 4;
            this.lblCorrect.Text = "Korrekturdatum:";
            // 
            // dtpCorrect
            // 
            this.dtpCorrect.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpCorrect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCorrect.Location = new System.Drawing.Point(95, 72);
            this.dtpCorrect.Name = "dtpCorrect";
            this.dtpCorrect.Size = new System.Drawing.Size(160, 20);
            this.dtpCorrect.TabIndex = 5;
            this.dtpCorrect.ValueChanged += new System.EventHandler(this.dtpReference_ValueChanged__dtpCorrect_ValueChanged);
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(7, 52);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(82, 13);
            this.lblReference.TabIndex = 2;
            this.lblReference.Text = "Referenzdatum:";
            // 
            // dtpReference
            // 
            this.dtpReference.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpReference.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReference.Location = new System.Drawing.Point(95, 46);
            this.dtpReference.Name = "dtpReference";
            this.dtpReference.Size = new System.Drawing.Size(160, 20);
            this.dtpReference.TabIndex = 3;
            this.dtpReference.ValueChanged += new System.EventHandler(this.dtpReference_ValueChanged__dtpCorrect_ValueChanged);
            // 
            // tabpSingleMode
            // 
            this.tabpSingleMode.Controls.Add(this.prgSingleMode);
            this.tabpSingleMode.Location = new System.Drawing.Point(4, 22);
            this.tabpSingleMode.Name = "tabpSingleMode";
            this.tabpSingleMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSingleMode.Size = new System.Drawing.Size(273, 407);
            this.tabpSingleMode.TabIndex = 0;
            this.tabpSingleMode.Text = "Einzelbearbeitung";
            this.tabpSingleMode.UseVisualStyleBackColor = true;
            // 
            // prgSingleMode
            // 
            this.prgSingleMode.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgSingleMode.Location = new System.Drawing.Point(6, 6);
            this.prgSingleMode.Name = "prgSingleMode";
            this.prgSingleMode.Size = new System.Drawing.Size(261, 395);
            this.prgSingleMode.TabIndex = 0;
            this.prgSingleMode.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgSingleMode_PropertyValueChanged);
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Location = new System.Drawing.Point(616, 447);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(281, 192);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(771, 645);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(126, 23);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "Über dieses Programm";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkCheckForAdminRightsOnStartup
            // 
            this.chkCheckForAdminRightsOnStartup.AutoSize = true;
            this.chkCheckForAdminRightsOnStartup.Location = new System.Drawing.Point(12, 645);
            this.chkCheckForAdminRightsOnStartup.Name = "chkCheckForAdminRightsOnStartup";
            this.chkCheckForAdminRightsOnStartup.Size = new System.Drawing.Size(260, 17);
            this.chkCheckForAdminRightsOnStartup.TabIndex = 4;
            this.chkCheckForAdminRightsOnStartup.Text = "Beim Progammstart auf Administratorrechte prüfen";
            this.chkCheckForAdminRightsOnStartup.UseVisualStyleBackColor = true;
            this.chkCheckForAdminRightsOnStartup.CheckedChanged += new System.EventHandler(this.chkCheckForAdminRightsOnStartup_CheckedChanged);
            // 
            // BTNCheckForAdminRights
            // 
            this.BTNCheckForAdminRights.Location = new System.Drawing.Point(278, 645);
            this.BTNCheckForAdminRights.Name = "BTNCheckForAdminRights";
            this.BTNCheckForAdminRights.Size = new System.Drawing.Size(190, 23);
            this.BTNCheckForAdminRights.TabIndex = 4;
            this.BTNCheckForAdminRights.Text = "Jetzt Administratorrechte prüfen";
            this.BTNCheckForAdminRights.UseVisualStyleBackColor = true;
            this.BTNCheckForAdminRights.Click += new System.EventHandler(this.btnCheckForAdminRights_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 680);
            this.Controls.Add(this.BTNCheckForAdminRights);
            this.Controls.Add(this.chkCheckForAdminRightsOnStartup);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.grbExplorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "FaDaAd - Fast Date Adjustment";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grbExplorer.ResumeLayout(false);
            this.tabMode.ResumeLayout(false);
            this.tabpBatchMode.ResumeLayout(false);
            this.tabpBatchMode.PerformLayout();
            this.grbMoveData.ResumeLayout(false);
            this.grbMoveData.PerformLayout();
            this.tabpSingleMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbExplorer;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tabpSingleMode;
        private System.Windows.Forms.TabPage tabpBatchMode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private OLKI.Toolbox.Widgets.SortListView slvItems;
        private System.Windows.Forms.PictureBox picPreview;
        private OLKI.Toolbox.Widgets.ReadOnlyPropertyGrid prgSingleMode;
        private System.Windows.Forms.ColumnHeader Dateiname;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grbMoveData;
        private System.Windows.Forms.DateTimePicker dtpReference;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.DateTimePicker dtpCorrect;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblCorrection;
        private System.Windows.Forms.TextBox txtCorrection;
        private System.Windows.Forms.Button btnBatchStart;
        private System.Windows.Forms.Label lblExceptions;
        private System.Windows.Forms.TextBox txtExceptions;
        private System.Windows.Forms.ProgressBar pbaBatchProgress;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cboBase;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox chkCheckForAdminRightsOnStartup;
        private System.Windows.Forms.Button BTNCheckForAdminRights;
    }
}

