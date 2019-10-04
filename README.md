# SmartWatchTracker

//Authentication
var device = _dbContext.Device.Where(d => d.RegistrationId == deviceData.RegistrationId);
            if(device != null)
            {
                //Insert data into DeviceTracker table
                return Ok();
            }
            else
            {
                return Unauthorized();
            }
