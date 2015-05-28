using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    class VisitorZoneInformationViewManager
    {
        VisitorZoneInformationViewGateway visitorZoneInformationViewGateway = new VisitorZoneInformationViewGateway();
        public List<VisitorZoneInformationView> GetVisitorZoneByZoneId(int zoneId)
        {
            return visitorZoneInformationViewGateway.GetVisitorZoneByZoneId(zoneId);
        }
    }
}
