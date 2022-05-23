using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftTest : IShift
    {
        private List<Shift> shifts;
        private static int count = 1;

        public ShiftTest ()
        {
            this.shifts = new List<Shift>();
        }

        public void Add(Shift shift)
        {
            this.shifts.Add(new Shift (count,
                shift.Position,
                shift.Employees,
                shift.Time,
                shift.Date
                ));
        }

        public List<Shift> GetAll()
        {
            return this.shifts;
        }

        public void Remove(int id)
        {
            for (int i = 0; i < this.shifts.Count; i++)
            {
                if (this.shifts[i].ID == id)
                {
                    this.shifts.RemoveAt(i);
                }
            }
        }

        public void Update(Shift shift)
        {
            for (int i = 0; i < this.shifts.Count; i++)
            {
                if (this.shifts[i].ID == shift.ID)
                {
                    this.shifts[i] = shift;
                }
            }
        }
    }
}