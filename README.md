# SmartWatchTracker

//Authentication
var device = _dbContext.Device.Where(d => d.DeviceId == deviceData.DeviceId);
            if(device != null)
            {
                //Insert data into DeviceTracker table
                return Ok();
            }
            else
            {
                return Unauthorized();
            }
