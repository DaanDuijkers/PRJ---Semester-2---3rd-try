using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftManager
    {
        public List<Shift> shifts;
        private IShift dbConnection;

        public ShiftManager (IShift shift)
        {
            this.dbConnection = shift;
            this.shifts = this.dbConnection.GetAll();
        }

        public Shift Get (IFilterShift filterShift)
        {
            return filterShift.Filter(this.shifts);
        }

        public List<Shift> GetAll (IFilterShifts filterShifts)
        {
            return filterShifts.Filter(this.shifts);
        }

        public bool Add(Shift shift)
        {
            foreach (Shift s in this.shifts)
            {
                if (s.Date.ToString("yyyy-MM-dd") == shift.Date.ToString("yyyy-MM-dd") && s.Time == shift.Time && s.Position.ID == shift.Position.ID)
                {
                    return false;
                }
            }

            if (shift.Date.DayOfWeek != DayOfWeek.Saturday && shift.Date.DayOfWeek != DayOfWeek.Sunday)
            {
                this.dbConnection.Add(shift);
                this.shifts = this.dbConnection.GetAll();
                return true;
            }
            
            return false;
        }

        public bool Update(Shift shift)
        {
            foreach (Shift s in this.shifts)
            {
                if (s.Position.ID == shift.Position.ID && s.Date == shift.Date && s.Time == shift.Time)
                {
                    if (s.ID != shift.ID)
                    {
                        return false;
                    }
                }
            }

            if (shift.Date.DayOfWeek != DayOfWeek.Saturday && shift.Date.DayOfWeek != DayOfWeek.Sunday)
            {
                this.dbConnection.Update(shift);
                this.shifts = this.dbConnection.GetAll();
                return true;
            }

            return false;
        }

        public bool Remove(int id)
        {
            foreach (Shift s in this.shifts)
            {
                if (s.ID == id)
                {
                    this.dbConnection.Remove(id);
                    this.shifts = this.dbConnection.GetAll();
                    return true;
                }
            }

            return false;
        }
    }
}