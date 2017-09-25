using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloning
{
    public class DriverInfo
    {
        string driverProvider;
        string driverDescription;
        string driverDeviceGuid;
        string driverID;

        public DriverInfo(string driverProvider, string driverDescription, string driverDeviceGuid, string driverID)
        {
            this.driverProvider = driverProvider;
            this.driverDescription = driverDescription;
            this.driverDeviceGuid = driverDeviceGuid;
            this.driverID = driverID;
        }

        public string DriverProvider
        {
            get { return this.driverProvider; }
        }

        public string DriverDescription
        {
            get { return this.driverDescription; }
        }

        public string DriverDeviceGUID
        {
            get { return this.driverDeviceGuid; }
        }

        public string DriverID
        {
            get { return this.driverID; }
        }
    }
}
