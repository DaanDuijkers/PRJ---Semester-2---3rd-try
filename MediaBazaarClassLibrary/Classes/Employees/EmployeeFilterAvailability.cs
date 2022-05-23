using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeFilterAvailability : IFilterEmployee
    {
        private List<Shift> shiftsThisWeek;
        private Position position;
        private List<Employee> assignedEmployees;

        public EmployeeFilterAvailability(Position position, List<Employee> assignedEmployees, DateTime date, List<Shift> shifts)
        {
            this.position = position;
            this.assignedEmployees = assignedEmployees;

            DayOfWeek day = date.DayOfWeek;
            int days = day - DayOfWeek.Monday;
            DateTime weekStart = date.AddDays(-days);
            DateTime weekEnd = weekStart.AddDays(6);
            this.shiftsThisWeek = new List<Shift>();
            foreach (Shift s in shifts)
            {
                if (s.Date >= weekStart && s.Date <= weekEnd)
                {
                    this.shiftsThisWeek.Add(s);
                }
            }
        }

        public List<Employee> Filter (List<Employee> employees)
        {
            List<Employee> filteredEmployees = new List<Employee>();

            foreach (Employee e in employees)
            {
                bool exists = false;
                foreach (Employee ae in this.assignedEmployees)
                {
                    if (ae.ID == e.ID)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists == false)
                {
                    if (e.Position.ID == this.position.ID)
                    {
                        int count = 0;
                        foreach (Shift s in this.shiftsThisWeek)
                        {
                            foreach (Employee se in s.Employees)
                            {
                                if (se.ID == e.ID)
                                {
                                    count += 3;
                                }
                            }
                        }

                        if (count < e.WorkingHours)
                        {
                            filteredEmployees.Add(e);
                        }
                    }
                }
            }
            
            return filteredEmployees;
        }
    }
}