using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IFilterShifts
    {
        List<Shift> Filter(List<Shift> shifts);
    }
}