using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.UI;

namespace FairManagementSystemApplication
{
    public partial class FairManagementSystemUI : Form
    {
        public FairManagementSystemUI()
        {
            InitializeComponent();
        }

        private void manuZoneType_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI zoneTypeEntry = new ZoneTypeEntryUI();
            zoneTypeEntry.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorInfoUI visitorInfo = new VisitorInfoUI();
            visitorInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorDetailsUI zoneSpecificVisitorDetailsUI = new ZoneSpecificVisitorDetailsUI();
            zoneSpecificVisitorDetailsUI.Show();
        }

        private void zoneWiseVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberUI zoneWiseVisitorNumberUI = new ZoneWiseVisitorNumberUI();
            zoneWiseVisitorNumberUI.Show();
        }
    }
}
