﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IoTDevice.Models.Core
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }//DeviceType.TypeId
        public DateTimeOffset RegistrationTime { get; set; }
    }
}