using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public interface IPosition
    {
        void Add(Position position);
        void ReAdd(Position position);
        void Update(Position position);
        void Remove(int id);
        List<Position> GetAll();
    }
}