using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;


namespace FairManagementSystemApplication.BLL
{
    class VisitorInfoManager
    {
        public List<Zone> GetAllZoneTypeList()
        {
            ZoneGateway zoneGateway = new ZoneGateway();
            return zoneGateway.GetAllZoneTypeList();
        }

        public int Save(VisitorInfo visitorInfo)
        {
            VisitorInfoGateway visitorInfoGateway = new VisitorInfoGateway();
            return visitorInfoGateway.Save(visitorInfo);
        }
    }
}
