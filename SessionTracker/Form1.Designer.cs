namespace SessionTracker
{
    partial class SessionTrackerMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionTrackerMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrackDataView = new System.Windows.Forms.DataGridView();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTrackerMainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTrackerMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTrackerMainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.mnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.showToolStripMenuItem.Text = "show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.zeitenToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(359, 24);
            this.mnMain.TabIndex = 1;
            this.mnMain.Text = "menuStrip1";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.importierenToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.schließenToolStripMenuItem});
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.summaryToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "speichern";
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importierenToolStripMenuItem.Text = "importieren";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "start on Windows";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Database anlegen";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schließenToolStripMenuItem.Text = "schließen";
            // 
            // zeitenToolStripMenuItem
            // 
            this.zeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.summaryToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.saveLastToolStripMenuItem});
            this.zeitenToolStripMenuItem.Name = "zeitenToolStripMenuItem";
            this.zeitenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.zeitenToolStripMenuItem.Text = "Zeiten";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem1
            // 
            this.summaryToolStripMenuItem1.Name = "summaryToolStripMenuItem1";
            this.summaryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem1.Text = "Summary";
            this.summaryToolStripMenuItem1.Click += new System.EventHandler(this.summaryToolStripMenuItem1_Click);
            // 
            // dgvTrackDataView
            // 
            this.dgvTrackDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrackDataView.Location = new System.Drawing.Point(0, 24);
            this.dgvTrackDataView.Name = "dgvTrackDataView";
            this.dgvTrackDataView.Size = new System.Drawing.Size(359, 222);
            this.dgvTrackDataView.TabIndex = 2;
            this.dgvTrackDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrackDataView_CellClick);
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(SessionTracker.lib.Track);
            // 
            // sessionTrackerMainBindingSource1
            // 
            this.sessionTrackerMainBindingSource1.DataSource = typeof(SessionTracker.SessionTrackerMain);
            // 
            // sessionTrackerMainBindingSource
            // 
            this.sessionTrackerMainBindingSource.DataSource = typeof(SessionTracker.SessionTrackerMain);
            // 
            // sessionTrackerMainBindingSource2
            // 
            this.sessionTrackerMainBindingSource2.DataSource = typeof(SessionTracker.SessionTrackerMain);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // saveLastToolStripMenuItem
            // 
            this.saveLastToolStripMenuItem.Name = "saveLastToolStripMenuItem";
            this.saveLastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLastToolStripMenuItem.Text = "Save Last";
            this.saveLastToolStripMenuItem.Click += new System.EventHandler(this.saveLastToolStripMenuItem_Click);
            // 
            // SessionTrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 246);
            this.Controls.Add(this.dgvTrackDataView);
            this.Controls.Add(this.mnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMain;
            this.Name = "SessionTrackerMain";
            this.Text = "SessionTracker";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTrackerMainBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTrackDataView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.BindingSource sessionTrackerMainBindingSource;
        private System.Windows.Forms.BindingSource sessionTrackerMainBindingSource1;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private System.Windows.Forms.BindingSource sessionTrackerMainBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saveLastToolStripMenuItem;
    }
}

