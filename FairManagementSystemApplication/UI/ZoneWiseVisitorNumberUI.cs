using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.BLL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.UI
{
    public partial class ZoneWiseVisitorNumberUI : Form
    {
        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
            LoadListBox();
        }
        ZoneManager zoneManager = new ZoneManager();
        void LoadListBox()
        {
            zoneWiseVisitorNumberListView.Items.Clear();
            List<Zone> zoneList = zoneManager.GetAllZoneTypeList();
            int total = 0;
            foreach (var zone in zoneList)
            {
                VisitorZoneInformationViewManager visitorZoneInformationViewManager = new VisitorZoneInformationViewManager();
                List<VisitorZoneInformationView> visitorZoneInformationViewList = visitorZoneInformationViewManager.GetVisitorZoneByZoneId(zone.Id);
                int count = 0;
                foreach (var visitorZone in visitorZoneInformationViewList)
                {
                    count++;
                }
                ListViewItem listViewItem = new ListViewItem(zone.Zone_Name);
                listViewItem.SubItems.Add(count.ToString());
                zoneWiseVisitorNumberListView.Items.Add(listViewItem);
                total += count;
            }
            zoneWiseVisitorNumberTotalTextBox.Text = total.ToString();
        }
    }
}
