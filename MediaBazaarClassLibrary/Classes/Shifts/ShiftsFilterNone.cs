using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftsFilterNone : IFilterShifts
    {
        public ShiftsFilterNone() { }

        public List<Shift> Filter(List<Shift> shifts)
        {
            return shifts;
        }
    }
}