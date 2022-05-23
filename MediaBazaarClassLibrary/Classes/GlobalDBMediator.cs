using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class GlobalDBMediator : Encrypt 
    {
        protected MySqlConnection myDBConnection;

        public GlobalDBMediator()
        {
            string dbConnectionInfo = @"Server=studmysql01.fhict.local;Uid=dbi435906;Database=dbi435906;Pwd=Rene1995;";

            this.myDBConnection = new MySqlConnection(dbConnectionInfo);
        }

        public MySqlConnection GetDBConnection()
        {
            return this.myDBConnection;
        }

        public long ExecuteCount(MySqlCommand sqlCountCommand)
        {
            try
            {
                this.myDBConnection.Open();
                long count = (long)sqlCountCommand.ExecuteScalar();

                return count;
            }
            finally
            {
                this.myDBConnection.Close();
            }
        }

        public int ExecuteNonQuery(MySqlCommand sqlNonQueryCommand)
        {
            int numberAffectedRows = 0;

            try
            {
                this.myDBConnection.Open();
                numberAffectedRows = sqlNonQueryCommand.ExecuteNonQuery();
            }
            finally
            {
                this.myDBConnection.Close();
            }

            return numberAffectedRows;
        }

        public MySqlDataReader OpenExecuteReader(MySqlCommand sqlReaderCommand)
        {
            this.myDBConnection.Open();
            MySqlDataReader reader = sqlReaderCommand.ExecuteReader();

            return reader;
        }

        public void CloseExecuteReader(MySqlDataReader reader)
        {
            if (reader != null)
            {
                reader.Close();
            }

            this.myDBConnection.Close();
        }
    }
}