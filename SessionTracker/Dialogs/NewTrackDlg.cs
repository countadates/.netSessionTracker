using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionTracker.Dialogs
{
    public partial class NewTrackDlg : Form
    {
        public DateTime Start { get {return DateTime.Parse(DateTime.Now.ToShortDateString() + " " + txtStart.Text); } }
        public DateTime End { get { return DateTime.Parse(DateTime.Now.ToShortDateString() + " " + txtEnd.Text); } }
        public String Description { get { return txtDescription.Text; } }

        public NewTrackDlg()
        {
            InitializeComponent();
        }

        public NewTrackDlg(DateTime start, DateTime end, string description)
        {
            InitializeComponent();
            txtStart.Text = start.ToShortTimeString();
            txtEnd.Text = end.ToShortTimeString();
            txtDescription.Text = description;
        }
    }
}
