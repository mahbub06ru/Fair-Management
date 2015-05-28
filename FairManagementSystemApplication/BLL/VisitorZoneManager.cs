using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    class VisitorZoneManager
    {
        VisitorZoneGateway visitorZoneGateway = new VisitorZoneGateway();

        public void Save(VisitorZone visitorZone)
        {
            visitorZoneGateway.Save(visitorZone);
        }

    }
}
