using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademySpace
{
    internal class booking
    {
        public int BookingId { get; set; }
        public int SpaceID { get; set; }
        public DateTime BookDate { get; set; }
        public TimeSpan BookTime { get; set; }
        public string Username { get; set; }
        public Space space { get; set; }
    }
}
