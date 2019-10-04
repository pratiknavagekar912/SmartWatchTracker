using System;
using System.Collections.Generic;
using System.Text;

namespace IoTDevice.Models.Core
{
    public class DeviceTracker
    {
        public int Id { get; set; }//DeviceTracker Id
        public int DeviceId { get; set; }//Device.Id
        public DateTimeOffset CreatedDate { get; set; }
        public string Name { get; set; } //Peroperty Name or Key i.e. Heart rate
        public string Value { get; set; } //Property value i.e. 120
    }
}
