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
    public partial class Tracklist : Form
    {
        public Tracklist()
        {
            InitializeComponent();
            // reading tracks from db
            // fill table with tracks 
        }

        public string Date { get; internal set; }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
