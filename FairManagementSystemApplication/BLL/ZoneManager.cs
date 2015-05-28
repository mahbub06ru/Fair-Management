using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    
    class ZoneManager
    {
        ZoneGateway zoneGateway = new ZoneGateway();

        public bool Insert(Zone zone)
        {
            if (zone.Zone_Name == "")
            {
                MessageBox.Show("Zone Type Cannot Be Empty");
                return false;
            }
            bool IsZoneTitleExist = IsZoneTitleExists(zone.Zone_Name);
            if (IsZoneTitleExist)
            {
                MessageBox.Show("Zone Type All Ready Exists !!");
                return false;
            }
            else
            {
                 return zoneGateway.Insert(zone)>0;    
            }
            
        }

        public bool IsZoneTitleExists(string zoneTitle)
        {
            Zone zone = zoneGateway.GetZoneByZoneTitle(zoneTitle);

            if (zone !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Zone> GetAllZoneTypeList()
        {
            return zoneGateway.GetAllZoneTypeList();
        }

    }
}
