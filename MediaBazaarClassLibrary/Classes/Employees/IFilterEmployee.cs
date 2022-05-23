using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IFilterEmployee
    {
        List<Employee> Filter(List<Employee> employees);
    }
}