using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class Position
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public Position (string name)
        {
            this.Name = name;
            this.IsActive = true;
        }

        public Position(int id, string name, bool isActive)
        {
            this.ID = id;
            this.Name = name;
            this.IsActive = isActive;
        }
    }
}