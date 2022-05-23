using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class PositionTest : IPosition
    {
        private List<Position> positions;

        public PositionTest ()
        {
            this.positions = new List<Position>();
        }

        public void Add(Position position)
        {
            this.positions.Add(new Position(this.positions.Count + 1,
                position.Name,
                position.IsActive
                ));
        }

        public List<Position> GetAll()
        {
            return this.positions;
        }

        public void ReAdd(Position position)
        {
            for (int i = 0; i < this.positions.Count; i++)
            {
                if (this.positions[i].Name == position.Name)
                {
                    this.positions[i] = new Position(this.positions[i].ID,
                        this.positions[i].Name,
                        true
                        );
                    break;
                }
            }
        }

        public void Remove(int id)
        {
            for (int i = 0; i < this.positions.Count; i++)
            {
                if (this.positions[i].ID == id)
                {
                    this.positions[i] = new Position(this.positions[i].ID,
                        this.positions[i].Name,
                        false
                        );
                    break;
                }
            }
        }

        public void Update(Position position)
        {
            for (int i = 0; i < this.positions.Count; i++)
            {
                if (this.positions[i].ID == position.ID)
                {
                    this.positions[i] = new Position(position.ID,
                        position.Name,
                        position.IsActive
                        );
                    break;
                }
            }
        }
    }
}