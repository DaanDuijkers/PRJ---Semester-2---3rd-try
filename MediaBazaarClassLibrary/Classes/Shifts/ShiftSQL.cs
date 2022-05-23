using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class ShiftSQL : GlobalDBMediator, IShift
    {
        public ShiftSQL () : base () { }

        public List<Shift> GetAll()
        {
            List<Shift> shifts = new List<Shift>();

            string sqlStatement = "SELECT * FROM shift LEFT JOIN position ON shift.PositionID = position.ID;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            MySqlDataReader reader = null;

            int id, positionID;
            Time time;
            DateTime date;
            string positionName;
            bool isActive;

            try
            {
                reader = this.OpenExecuteReader(sqlCommand);

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                    time = (Time)Enum.Parse(typeof(Time), (string)reader.GetValue(1));
                    date = Convert.ToDateTime(reader.GetValue(2));

                    positionID = Convert.ToInt32(reader.GetValue(4));
                    positionName = Convert.ToString(reader.GetValue(5));
                    isActive = Convert.ToBoolean(reader.GetValue(6));

                    shifts.Add(new Shift(id, new Position(positionID, positionName, isActive), new List<Employee>(), time, date));
                }
            }
            finally
            {
                this.CloseExecuteReader(reader);
            }

            foreach (Shift s in shifts)
            {
                sqlStatement = "SELECT * FROM shiftline LEFT JOIN employee ON shiftline.EmployeeID = Employee.ID LEFT JOIN position ON employee.PositionID = Position.ID WHERE ShiftID = @ShiftID;";
                sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

                sqlCommand.Parameters.AddWithValue("@ShiftID", s.ID);

                reader = null;

                int employeeID, bsn, workingHours, employeePositionID;
                double salary;
                bool employeeIsActive, employeePositionIsActive;
                DateTime birthDate, hireDate;
                Gender gender;
                string firstName, lastName, username, password, phone, email, postal, contactName, contactPhone, employeePositionName;

                try
                {
                    reader = this.OpenExecuteReader(sqlCommand);

                    while (reader.Read())
                    {
                        employeeID = Convert.ToInt32(reader.GetValue(3));
                        bsn = Convert.ToInt32(reader.GetValue(4));
                        workingHours = Convert.ToInt32(reader.GetValue(5));
                        salary = Convert.ToDouble(reader.GetValue(7));
                        employeeIsActive = Convert.ToBoolean(reader.GetValue(8));
                        birthDate = Convert.ToDateTime(reader.GetValue(9));
                        hireDate = Convert.ToDateTime(reader.GetValue(10));
                        gender = (Gender)Enum.Parse(typeof(Gender), (string)reader.GetValue(11));
                        firstName = Convert.ToString(reader.GetValue(12));
                        lastName = Convert.ToString(reader.GetValue(13));
                        username = Convert.ToString(reader.GetValue(14));
                        password = Convert.ToString(reader.GetValue(15));
                        phone = Convert.ToString(reader.GetValue(16));
                        email = Convert.ToString(reader.GetValue(17));
                        postal = Convert.ToString(reader.GetString(18));
                        contactName = Convert.ToString(reader.GetString(19));
                        contactPhone = Convert.ToString(reader.GetString(20));

                        employeePositionID = Convert.ToInt32(reader.GetValue(21));
                        employeePositionName = Convert.ToString(reader.GetValue(22));
                        employeePositionIsActive = Convert.ToBoolean(reader.GetValue(23));

                        s.Employees.Add(new Employee(employeeID, bsn, workingHours, new Position(employeePositionID, employeePositionName, employeePositionIsActive), salary, employeeIsActive, birthDate, hireDate, gender, firstName, lastName, username, password, phone, email, postal, contactName, contactPhone));
                    }
                }
                finally
                {
                    this.CloseExecuteReader(reader);
                }
            }

            return shifts;
        }

        public void Add(Shift shift)
        {
            string sqlStatement = "INSERT INTO shift (Time, Date, PositionID) VALUES (@Time, @Date, @PositionID);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Time", shift.Time);
            sqlCommand.Parameters.AddWithValue("@Date", shift.Date);
            sqlCommand.Parameters.AddWithValue("@PositionID", shift.Position.ID);

            this.ExecuteNonQuery(sqlCommand);

            foreach (Employee e in shift.Employees)
            {
                sqlStatement = "INSERT INTO shiftline (EmployeeID, ShiftID) VALUES (@EmployeeID, (SELECT ID FROM shift ORDER BY ID DESC LIMIT 1));";
                sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

                sqlCommand.Parameters.AddWithValue("@EmployeeID", e.ID);

                this.ExecuteNonQuery(sqlCommand);
            }
        }

        public void Remove(int id)
        {
            string sqlStatement = "DELETE FROM shiftline WHERE ShiftID = @ShiftID;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@ShiftID", id);

            this.ExecuteNonQuery(sqlCommand);


            sqlStatement = "DELETE FROM shift WHERE ID = @ID;";
            sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@ID", id);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void Update(Shift shift)
        {
            string sqlStatement = "UPDATE shift SET Time = @Time, Date = @Date, PositionID = @PositionID WHERE ID = @ID";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@Time", shift.Time);
            sqlCommand.Parameters.AddWithValue("@Date", shift.Date);
            sqlCommand.Parameters.AddWithValue("@PositionID", shift.Position.ID);
            sqlCommand.Parameters.AddWithValue("@ID", shift.ID);

            this.ExecuteNonQuery(sqlCommand);

            foreach (Employee e in shift.Employees)
            {
                sqlStatement = "DELETE FROM shiftline WHERE ShiftID = @ShiftID && EmployeeID = @EmployeeID; INSERT INTO shiftline (EmployeeID, ShiftID) VALUES (@EmployeeID, @ShiftID);";
                sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

                sqlCommand.Parameters.AddWithValue("@EmployeeID", e.ID);
                sqlCommand.Parameters.AddWithValue("@ShiftID", shift.ID);

                this.ExecuteNonQuery(sqlCommand);
            }
        }
    }
}