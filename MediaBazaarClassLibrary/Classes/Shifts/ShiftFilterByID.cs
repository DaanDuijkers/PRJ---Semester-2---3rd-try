using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftFilterByID : IFilterShift
    {
        private int id;

        public ShiftFilterByID (int id)
        {
            this.id = id;
        }

        public Shift Filter(List<Shift> shifts)
        {
            foreach (Shift s in shifts)
            {
                if (s.ID == this.id)
                {
                    return s;
                }
            }

            return null;
        }
    }
}