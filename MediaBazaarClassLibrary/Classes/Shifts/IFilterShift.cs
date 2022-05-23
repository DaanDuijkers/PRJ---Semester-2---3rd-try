using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IFilterShift
    {
        Shift Filter(List<Shift> shifts);
    }
}