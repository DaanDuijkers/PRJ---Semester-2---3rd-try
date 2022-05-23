using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeSQL : GlobalDBMediator, IEmployee
    {
        public EmployeeSQL() : base() { }

        public void Add(Employee employee)
        {
            string sqlStatement = "INSERT INTO employee (BSN, WorkingHours, PositionID, Salary, IsActive, BirthDate, HireDate, Gender, FirstName, LastName, Username, Password, Phone, Email, Postal, ContactName, ContactPhone) VALUES (@BSN, @WorkingHours, @PositionID, @Salary, @IsActive, @BirthDate, @HireDate, @Gender, @FirstName, @LastName, @Username, @Password, @Phone, @Email, @Postal, @ContactName, @ContactPhone);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@BSN", employee.BSN);
            sqlCommand.Parameters.AddWithValue("@WorkingHours", employee.WorkingHours);
            sqlCommand.Parameters.AddWithValue("@PositionID", employee.Position.ID);
            sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
            sqlCommand.Parameters.AddWithValue("@IsActive", employee.IsActive);
            sqlCommand.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@HireDate", employee.HireDate);
            sqlCommand.Parameters.AddWithValue("@Gender", employee.Gender);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@Username", employee.Username);
            sqlCommand.Parameters.AddWithValue("@Password", this.EncryptPassword(employee.Password));
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Postal", employee.Postal);
            sqlCommand.Parameters.AddWithValue("@ContactName", employee.ContactName);
            sqlCommand.Parameters.AddWithValue("@ContactPhone", employee.ContactPhone);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void ReHire (Employee employee)
        {
            string sqlStatement = "UPDATE employee SET IsActive = @IsActive WHERE BSN = @BSN";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@IsActive", employee.IsActive);
            sqlCommand.Parameters.AddWithValue("@BSN", employee.ID);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void Update(Employee employee)
        {
            string sqlStatement = "UPDATE employee SET BSN = @BSN, WorkingHours = @WorkingHours, PositionID = @PositionID, Salary = @Salary, BirthDate = @BirthDate, HireDate = @HireDate, Gender = @Gender, FirstName = @FirstName, LastName = @LastName, UserName = @UserName, Password = @Password, Phone = @Phone, Email = @Email, Postal = @Postal, ContactName = @ContactName, ContactPhone = @ContactPhone WHERE ID = @ID";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@BSN", employee.BSN);
            sqlCommand.Parameters.AddWithValue("@WorkingHours", employee.WorkingHours);
            sqlCommand.Parameters.AddWithValue("@PositionID", employee.Position.ID);
            sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
            sqlCommand.Parameters.AddWithValue("@IsActive", employee.IsActive);
            sqlCommand.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@HireDate", employee.HireDate);
            sqlCommand.Parameters.AddWithValue("@Gender", employee.Gender);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@Username", employee.Username);
            sqlCommand.Parameters.AddWithValue("@Password", this.EncryptPassword(employee.Password));
            sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@Postal", employee.Postal);
            sqlCommand.Parameters.AddWithValue("@ContactName", employee.ContactName);
            sqlCommand.Parameters.AddWithValue("@ContactPhone", employee.ContactPhone);
            sqlCommand.Parameters.AddWithValue("@ID", employee.ID);

            this.ExecuteNonQuery(sqlCommand);
        }

        public void Remove(int id)
        {
            string sqlStatement = "UPDATE employee SET IsActive = @IsActive WHERE ID = @ID;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@IsActive", false);
            sqlCommand.Parameters.AddWithValue("@ID", id);

            this.ExecuteNonQuery(sqlCommand);
        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            string sqlStatement = "SELECT * FROM Employee LEFT JOIN position ON employee.PositionID = position.ID ORDER BY Employee.ID ASC;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.GetDBConnection());

            MySqlDataReader reader = null;

            int id, bsn, workingHours, positionID;
            double salary;
            bool isActive, positionIsActive;
            DateTime birthDate, hireDate;
            Gender gender;
            string firstName, lastName, username, password, phone, email, postal, contactName, contactPhone, positionName;

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

                    employees.Add(new Employee(id, bsn, workingHours, new Position(positionID, positionName, isActive), salary, isActive, birthDate, hireDate, gender, firstName, lastName, username, password, phone, email, postal, contactName, contactPhone));
                }
            }
            finally
            {
                this.CloseExecuteReader(reader);
            }

            return employees;
        }
    }
}