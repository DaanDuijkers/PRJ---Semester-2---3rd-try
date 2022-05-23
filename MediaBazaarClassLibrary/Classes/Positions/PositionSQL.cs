using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class PositionSQL : GlobalDBMediator, IPosition
    {
        public PositionSQL() : base () { }

        public void Add(Position position)
        {
            string sqlStatement = "INSERT INTO position (Name, IsActive) VALUES (@Name, @IsActive);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Name", position.Name);
            sqlCommand.Parameters.AddWithValue("@IsActive", true);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void ReAdd(Position position)
        {
            string sqlStatement = "UPDATE position SET IsActive = @IsActive WHERE Name = @Name;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Name", position.Name);
            sqlCommand.Parameters.AddWithValue("@IsActive", true);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void Update(Position position)
        {
            string sqlStatement = "UPDATE position SET Name = @Name WHERE ID = @ID;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Name", position.Name);
            sqlCommand.Parameters.AddWithValue("@ID", position.ID);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void Remove(int id)
        {
            string sqlStatement = "UPDATE position SET IsActive = @IsActive WHERE ID = @ID;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.Parameters.AddWithValue("@IsActive", false);

            this.ExecuteNonQuery(sqlCommand);
        }

        public List<Position> GetAll()
        {
            List<Position> positions = new List<Position>();

            string sqlStatement = "SELECT * FROM position ORDER BY ID ASC;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            MySqlDataReader reader = null;

            int id;
            string name;
            bool isActive;

            try
            {
                reader = this.OpenExecuteReader(sqlCommand);

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                    name = Convert.ToString(reader.GetValue(1));
                    isActive = Convert.ToBoolean(reader.GetValue(2));

                    positions.Add(new Position(id, name, isActive));
                }
            }
            finally
            {
                this.CloseExecuteReader(reader);
            }

            return positions;
        }
    }
}