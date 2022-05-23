using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class Shift
    {
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public List<Employee> Employees { get; private set; }
        public Time Time { get; private set; }
        public DateTime Date { get; private set; }

        static int count = 1;

        public Shift (Position position, List<Employee> employees, Time time, DateTime date)
        {
            this.Position = position;
            this.Employees = employees;
            this.Time = time;
            this.Date = date;
        }

        public Shift (int id, Position position, List<Employee> employees, Time time, DateTime date)
        {
            this.ID = id;
            this.Position = position;
            this.Employees = employees;
            this.Time = time;
            this.Date = date;
        }
    }
}