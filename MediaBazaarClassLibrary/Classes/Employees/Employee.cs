using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class Employee
    {
        public int ID { get; private set; }
        public int BSN { get; private set; }
        public int WorkingHours { get; private set; }
        public Position Position { get; private set; }
        public double Salary { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime HireDate { get; private set; }
        public Gender Gender { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Postal { get; private set; }
        public string ContactName { get; private set; }
        public string ContactPhone { get; private set; }

        public Employee(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Employee(int bsn, int workingHours, Position position, double salary, bool isActive, DateTime birthDate, DateTime hireDate, Gender gender, string firstName, string lastName, string phone, string email, string postal, string contactName, string contactPhone)
        {
            this.BSN = bsn;
            this.WorkingHours = workingHours;
            this.Position = position;
            this.Salary = salary;
            this.IsActive = isActive;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Gender = gender;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Postal = postal;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }

        public Employee(int bsn, int workingHours, Position position, double salary, bool isActive, DateTime birthDate, DateTime hireDate, Gender gender, string firstName, string lastName, string username, string password, string phone, string email, string postal, string contactName, string contactPhone)
        {
            this.BSN = bsn;
            this.WorkingHours = workingHours;
            this.Position = position;
            this.Salary = salary;
            this.IsActive = isActive;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Gender = gender;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Phone = phone;
            this.Email = email;
            this.Postal = postal;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }

        public Employee(int id, int bsn, int workingHours, Position position, double salary, bool isActive, DateTime birthDate, DateTime hireDate, Gender gender, string firstName, string lastName, string password, string phone, string email, string postal, string contactName, string contactPhone)
        {
            this.ID = id;
            this.BSN = bsn;
            this.WorkingHours = workingHours;
            this.Position = position;
            this.Salary = salary;
            this.IsActive = isActive;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Gender = gender;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Phone = phone;
            this.Email = email;
            this.Postal = postal;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }

        public Employee(int id, int bsn, int workingHours, Position position, double salary, bool isActive, DateTime birthDate, DateTime hireDate, Gender gender, string firstName, string lastName, string username, string password, string phone, string email, string postal, string contactName, string contactPhone)
        {
            this.ID = id;
            this.BSN = bsn;
            this.WorkingHours = workingHours;
            this.Position = position;
            this.Salary = salary;
            this.IsActive = isActive;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Gender = gender;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Phone = phone;
            this.Email = email;
            this.Postal = postal;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }
    }
}