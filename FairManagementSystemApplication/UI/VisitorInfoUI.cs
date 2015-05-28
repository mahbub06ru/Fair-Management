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
    public partial class VisitorInfoUI : Form
    {
        public VisitorInfoUI()
        {
            InitializeComponent();
            GetZoneListInZoneCheckedListBox();
        }
        VisitorInfoManager visitorInfoManager = new VisitorInfoManager();
        private void GetZoneListInZoneCheckedListBox()
        {
            ZoneManager zoneManager = new ZoneManager();
            List<Zone> zoneList = new List<Zone>();
            zoneList = zoneManager.GetAllZoneTypeList();
            zoneCheckedListBox.DataSource = null;
            zoneCheckedListBox.DataSource = zoneList;
            zoneCheckedListBox.ValueMember = "Id";
            zoneCheckedListBox.DisplayMember = "Zone_Name";
        }

        private void visitorSaveButton_Click(object sender, EventArgs e)
        {
            VisitorInfo visitorInfo = new VisitorInfo();
            VisitorZoneManager visitorZoneManager = new VisitorZoneManager();

            visitorInfo.Name = nameTextBox.Text;
            visitorInfo.Email = emailTextBox.Text;
            visitorInfo.ContactNumber = int.Parse(contactNoTextBox.Text);
                
           int visitorId = visitorInfoManager.Save(visitorInfo);

           if (visitorId > 0)
                {
                    foreach (var index in zoneCheckedListBox.CheckedItems)
                    {
                        Zone zone = (Zone) index;
                        VisitorZone visitorZone = new VisitorZone();

                        visitorZone.VisitorId = visitorId;
                        visitorZone.ZoneId = zone.Id;
                        visitorZoneManager.Save(visitorZone);
                    }
                    MessageBox.Show("Visitor Inserted Successfully! ");
               nameTextBox.Clear();
               emailTextBox.Clear();
               contactNoTextBox.Clear();
                }
            else
            {
                MessageBox.Show("Error Occurs");
            }
        }

        private void VisitorInfoUI_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
