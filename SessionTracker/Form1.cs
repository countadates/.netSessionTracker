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
using System.IO;

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
        String DBFileName = "SessionTracker.sqlite";

        public SessionTrackerMain()
        {
            InitializeComponent();
            m_dbProvider = new SQLiteProvider();
            m_dbProvider.Open(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),DBFileName));
            session.StateChanged += Session_StateChanged;
            bsource.DataSource = this.tracks;
            dgvTrackDataView.DataSource = bsource;
            toolStripMenuItem3.Checked = IsApplicationFromStartup();
            ListDayCounter();
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
                    if ((DateTime.Now - currentTrack.start) > TimeSpan.FromMinutes(10))
                    {
                        // show EntryType

                        Components.EntryType dlg = new Components.EntryType();
                        dlg.ShowDialog();
                        currentTrack.description = dlg.Type;
                    }
                    else {
                        currentTrack.description = "Waiting";
                    }
                    // close current Track and add it to List
                    currentTrack.stop = DateTime.Now;
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
            this.ClearListDayCounter();
        }

        private void insertNewTrack() {
            using (Dialogs.NewTrackDlg dlg = new Dialogs.NewTrackDlg())
            {
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

        public bool IsApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                var value = key.GetValue("SessionTracker");
                if (value != null)
                {
                    return value.Equals("\"" + Application.ExecutablePath + "\"");
                }
            }
            return false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem3.Checked == false)
            {
                AddApplicationToStartup();
                toolStripMenuItem3.Checked = true;
            }
            else {
                RemoveApplicationFromStartup();
                toolStripMenuItem3.Checked = false;
            }
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
            currentTrack.stop = DateTime.Now;
            tracks.Add(currentTrack);
            m_dbProvider.SaveTrack(currentTrack);
            currentTrack = new Track();
            DataSourceChanged();
            ClearListDayCounter();
            ListDayCounter();

        }

        private void SessionTrackerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close current Track and add it to List
            currentTrack.stop = DateTime.Now;
            currentTrack.description = "Working";
            m_dbProvider.SaveTrack(currentTrack);
        }

        private void ClearListDayCounter()
        {
            for (int c = listBox1.Controls.Count - 1; c >= 0; c--)
            {
                listBox1.Controls.RemoveAt(c);
            }
            listBox1.Controls.Clear();
        }

        private void ListDayCounter() {
            List<DayCounter> days=this.m_dbProvider.getCounter();
            foreach (DayCounter day in days) {
                Components.DayPanel panel = new Components.DayPanel();
                panel.hourCount = string.Format("{0:0.00}", (day.Counter / 60));
                panel.WeekDay = day.DayName;
                panel.Date = String.Format("{0:d}",day.Date);
                panel.Week = day.Week.ToString();
                panel.status = day.status;
                listBox1.Controls.Add(panel);
            }
        }
    }

}
