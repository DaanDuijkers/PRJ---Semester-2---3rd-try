using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IShift
    {
        void Add(Shift shift);
        void Update(Shift shift);
        void Remove(int id);
        List<Shift> GetAll();
    }
}