using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IEmployee
    {
        public void Add(Employee employee);
        public void ReHire(Employee employee);
        public void Update(Employee employee);
        public void Remove(int id);
        public List<Employee> GetAll();
    }
}