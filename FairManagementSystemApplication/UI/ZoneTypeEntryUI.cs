using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.Model;
using FairManagementSystemApplication.BLL;
namespace FairManagementSystemApplication.UI
{
    public partial class ZoneTypeEntryUI : Form
    {
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
            GetZoneListView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Zone zone = new Zone();
            zone.Zone_Name = zoneTypeEntryTextBox.Text;
            ZoneManager zoneManager = new ZoneManager();

            if (zoneManager.Insert(zone))
            {
                
                MessageBox.Show("Zone inserted Successfully");
                GetZoneListView();
                zoneTypeEntryTextBox.Clear();
            }
        }

        private void GetZoneListView()
        {
            ZoneManager zoneManager = new ZoneManager();
            List<Zone> zoneList = zoneManager.GetAllZoneTypeList();
            zoneTypeListView.Items.Clear();
            int count = 1;
            foreach (var index in zoneList)
            {
                ListViewItem listViewItem = new ListViewItem(count.ToString());
                listViewItem.SubItems.Add(index.Zone_Name);
                listViewItem.Tag = index.Id;
                zoneTypeListView.Items.Add(listViewItem);
                count++;
            }
        }

    }
}
