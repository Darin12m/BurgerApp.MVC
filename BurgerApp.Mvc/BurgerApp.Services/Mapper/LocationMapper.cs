using BurgerApp.Data.Models;
using BurgerApp.Services.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Mapper
{
    public static class LocationMapper
    {
        public static LocationModel ToModel (this Location location)
        {
            return new LocationModel
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                OpensAt = location.OpensAt,
                ClosesAt = location.ClosesAt
            };
        }

        public static LocationDetailsModel ToDetailsModel (this Location location)
        {
            return new LocationDetailsModel
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                OpensAt = location.OpensAt,
                ClosesAt = location.ClosesAt
            };
        }
    }
}
