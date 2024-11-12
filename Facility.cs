using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDBConnection
{
    internal class Facility
    {
        public int Facility_id{ get; set; }
        public string Name { get; set; }

        public int Hotel_no { get; set; }
        public override string ToString()
        {
            return $"ID: {Facility_id}, Name: {Name}, Hotel No.: {Hotel_no}";
        }
    }
}
