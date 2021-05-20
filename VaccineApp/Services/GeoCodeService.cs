using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Data;
using GoogleMaps.LocationServices;
using VaccineApp.DTO;
using System.Threading.Tasks;

namespace VaccineApp.Services
{
    public class GeoCodeService : IGeoCodeService
    {
        private IUserService _userService;

        public GeoCodeService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<LocationDto> GetLocation(string address)
        {
            var locationService = new GoogleLocationService("AIzaSyD7PxbrSfbIjOcREaGqCs2Xo3plhDeHOVg");
            var point = locationService.GetLatLongFromAddress(address);
            double latitude = point.Latitude;
            double longitude = point.Longitude;
            LocationDto result = new LocationDto { Address = address, Latitude = latitude, Longitude = longitude };
            return result;
        }
    }
}