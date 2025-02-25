using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;


namespace businessDisks
{
    public class dataAcces
    {
        private SqlCommand command;
            private SqlConnection conection;
        private SqlDataReader reader;


        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public dataAcces () {

            conection = new SqlConnection("server= .\\SQLEXPRESS; database = DISCOS_DB; integrated security = true");
            command = new SqlCommand();
        }
        public void setearQuery(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText  = consulta;
        }
        public void actioneject()
        {
            command.Connection = conection;
            try
            {
                conection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;   
            }
        }
        public void readerEjecucion()
        {
            try
            {
                command.Connection = conection;
                conection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }     
        }
        public void closeconection()
        {
            if (reader != null)
                reader.Close();
            conection.Close();
        }
        public void setearparametros(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }
    }
}
