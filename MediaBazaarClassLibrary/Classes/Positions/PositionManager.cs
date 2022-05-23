using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class PositionManager
    {
        public List<Position> positions;
        private IPosition dbConnection;

        public PositionManager (IPosition dbConnection)
        {
            this.dbConnection = dbConnection;
            this.positions = dbConnection.GetAll();
        }

        public Position Get(int id)
        {
            foreach (Position p in this.positions)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Position> GetAll ()
        {
            List<Position> filteredPositions = new List<Position>();
            foreach (Position p in this.positions)
            {
                if (p.IsActive == true)
                {
                    filteredPositions.Add(p);
                }
            }

            return filteredPositions;
        }

        public bool Add(Position position)
        {
            foreach (Position p in this.positions)
            {
                if (p.Name == position.Name)
                {
                    if (p.IsActive == false)
                    {
                        this.dbConnection.ReAdd(p);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            this.dbConnection.Add(position);
            this.positions = this.dbConnection.GetAll();
            return true;
        }

        public bool Update(Position position)
        {
            foreach (Position p in this.positions)
            {
                if (p.ID == position.ID)
                {
                    this.dbConnection.Update(position);
                    this.positions = this.dbConnection.GetAll();
                    return true;
                }
            }

            return false;
        }

        public bool Remove(int id)
        {
            foreach (Position p in this.positions)
            {
                if (p.ID == id)
                {
                    this.dbConnection.Remove(id);
                    this.positions = this.dbConnection.GetAll();
                    return true;
                }
            }

            return false;
        }
    }
}