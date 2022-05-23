using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class LoginApplicationSQL : GlobalDBMediator, ILogin
    {
        public LoginApplicationSQL() { }

        public Employee Login(Employee employee)
        {
            Employee account = null;

            string sqlStatement = "SELECT * FROM Employee LEFT JOIN position ON employee.PositionID = position.ID WHERE UserName = @UserName AND Password = @Password AND (PositionID = 1 OR PositionID = 2 OR PositionID = 3);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Username", employee.Username);
            sqlCommand.Parameters.AddWithValue("@Password", this.EncryptPassword(employee.Password));

            MySqlDataReader reader = null;

            int id, bsn, workingHours, positionID;
            double salary;
            string firstName, lastName, username, password, phone, email, postal, contactName, contactPhone, positionName;
            bool isActive, positionIsActive;
            DateTime birthDate, hireDate;
            Gender gender;

            try
            {
                reader = this.OpenExecuteReader(sqlCommand);

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                    bsn = Convert.ToInt32(reader.GetValue(1));
                    workingHours = Convert.ToInt32(reader.GetValue(2));
                    salary = Convert.ToDouble(reader.GetValue(4));
                    isActive = Convert.ToBoolean(reader.GetValue(5));
                    birthDate = Convert.ToDateTime(reader.GetValue(6));
                    hireDate = Convert.ToDateTime(reader.GetValue(7));
                    gender = (Gender)Enum.Parse(typeof(Gender), (string)reader.GetValue(8));
                    firstName = Convert.ToString(reader.GetValue(9));
                    lastName = Convert.ToString(reader.GetValue(10));
                    username = Convert.ToString(reader.GetValue(11));
                    password = Convert.ToString(reader.GetValue(12));
                    phone = Convert.ToString(reader.GetValue(13));
                    email = Convert.ToString(reader.GetValue(14));
                    postal = Convert.ToString(reader.GetString(15));
                    contactName = Convert.ToString(reader.GetString(16));
                    contactPhone = Convert.ToString(reader.GetString(17));

                    positionID = Convert.ToInt32(reader.GetValue(18));
                    positionName = Convert.ToString(reader.GetValue(19));
                    positionIsActive = Convert.ToBoolean(reader.GetValue(20));

                    account = new Employee(id, bsn, workingHours, new Position(positionID, positionName, positionIsActive), salary, isActive, birthDate, hireDate, gender, firstName, lastName, username, password, phone, email, postal, contactName, contactPhone);
                }
            }
            finally
            {
                this.CloseExecuteReader(reader);
            }

            return account;
        }
    }
}