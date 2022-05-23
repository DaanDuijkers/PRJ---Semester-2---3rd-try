using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftFilterEmployeeDateTime : IFilterShift
    {
        private int EmployeeID;
        private DateTime shiftDate;
        private Time shiftTime;

        public ShiftFilterEmployeeDateTime (int id, DateTime date, Time time)
        {
            this.EmployeeID = id;
            this.shiftDate = date;
            this.shiftTime = time;
        }

        public Shift Filter(List<Shift> shifts)
        {
            foreach (Shift s in shifts)
            {
                foreach (Employee e in s.Employees)
                {
                    if (e.ID == EmployeeID && s.Date == shiftDate && s.Time == shiftTime)
                    {
                        return s;
                    }
                }
            }

            return null;
        }
    }
}