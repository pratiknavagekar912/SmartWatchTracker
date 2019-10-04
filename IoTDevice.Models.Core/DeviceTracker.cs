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
        public string Data { get; set; } //JSON Data i.e. "{ "Heart rate" : 120 }"         
    }
}
