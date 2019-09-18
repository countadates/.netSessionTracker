using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionTracker.lib;
using SessionTracker.Dialogs;

namespace SessionTracker.Components
{
    public partial class DayPanel : UserControl
    {
        public String hourCount { set { this.HourCount.Text = value; } }
        public String Date { set { this.DateLabel.Text = value; } }
        public String WeekDay { set { this.WeekDayLabel.Text = value; } }
        public String Week { set { this.WeekLabel.Text = value; } }
        public Status status { set { setColor(value); } }



        private void setColor(Status status) {
            if (status == Status.Critical) { this.BackColor = Color.Crimson; this.ForeColor = Color.Wheat; }
            if (status == Status.Warn) { this.BackColor = Color.Yellow; this.ForeColor = Color.Black; }
            if (status == Status.Low) { this.BackColor = Color.WhiteSmoke; this.ForeColor = Color.Black; }
            HourCount.BackColor = this.BackColor;
            HourCount.ForeColor = this.ForeColor;
        }

        public DayPanel()
        {
            InitializeComponent();
        }

        private void DayPanel_DoubleClick(object sender, EventArgs e)
        {
            using (Tracklist dlg = new Tracklist())
            {
                dlg.ShowDialog();
            }
        }
    }
}
