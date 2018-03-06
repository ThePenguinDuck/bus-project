using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Device.Location;

namespace bus_project.Model
{
    public class GeoLocation
    {
        public GeoLocation()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
        }

        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            string.Format("Lat: {0}, Long: {1}", e.Position.Location.Latitude, e.Position.Location.Longitude);
        }
    }
}