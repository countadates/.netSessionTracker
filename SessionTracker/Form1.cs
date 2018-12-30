using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionTracker.lib;
using SessionTracker.Dialogs;
using Microsoft.Win32;
using System.Data.SQLite;

namespace SessionTracker
{
    public partial class SessionTrackerMain : Form
    {
        FormWindowState lastState = FormWindowState.Normal;
        public List<Track> tracks = new List<Track>();
        BindingSource bsource = new BindingSource();
        WindowsSession session = new WindowsSession();
        Track currentTrack = new Track();
        SQLiteProvider m_dbProvider;
        

        public SessionTrackerMain()
        {
            InitializeComponent();
            m_dbProvider = new SQLiteProvider();
            m_dbProvider.Open("SessionTracker.sqlite");
            session.StateChanged += Session_StateChanged;
            bsource.DataSource = this.tracks;
            dgvTrackDataView.DataSource = bsource;
        }

        private void Session_StateChanged(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case Microsoft.Win32.SessionSwitchReason.SessionLock:
                case Microsoft.Win32.SessionSwitchReason.SessionLogoff:
                    // close current Track and add it to List
                    currentTrack.stop = DateTime.Now;
                    currentTrack.description = "Working";
                    tracks.Add(currentTrack);
                    m_dbProvider.SaveTrack(currentTrack);
                    currentTrack = new Track();
                    DataSourceChanged();
                    break;
                case Microsoft.Win32.SessionSwitchReason.SessionUnlock:
                    // close current Track and add it to List
                    currentTrack.stop = DateTime.Now;
                    currentTrack.description = "Paused";
                    tracks.Add(currentTrack);
                    m_dbProvider.SaveTrack(currentTrack);
                    currentTrack = new Track();
                    DataSourceChanged();
                    break;
            }

        }

        private void DataSourceChanged() {
            bsource.ResetBindings(false);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
            this.WindowState = lastState;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
            else {
                lastState = this.WindowState;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void summaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimeSpan total = new TimeSpan();
            foreach (Track track in tracks) {
                total += track.Duration;
            }
            MessageBox.Show("Total: " + total.ToString());
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogs.NewTrackDlg dlg = new Dialogs.NewTrackDlg();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Track track = new Track();
                    track.start = dlg.Start;
                    track.stop = dlg.End;
                    track.description = dlg.Description;
                    tracks.Add(track);
                    DataSourceChanged();
                }
        }

        public void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("SessionTracker", "\"" + Application.ExecutablePath + "\"");
            }
        }

        public void RemoveApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("SessionTracker", false);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddApplicationToStartup();
        }

        private void dgvTrackDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex == -1 || e.ColumnIndex != 3)  // ignore header row and any column
            {
                return;                                  //  that doesn't have a file name
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void saveLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_dbProvider.SaveTrack(tracks[0]);
        }

        private void SessionTrackerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close current Track and add it to List
            currentTrack.stop = DateTime.Now;
            currentTrack.description = "Working";
            m_dbProvider.SaveTrack(currentTrack);
        }
    }
}
