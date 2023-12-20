using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademySpace
{
    internal class Space
    {
        public int SpaceID { get; set; }
        public string SpaceName { get; set; }
        public int capacity { get; set; }
        public List <booking> Bookings { get; set; }

    }
}
