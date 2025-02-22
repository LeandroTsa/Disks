using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Disks;




namespace businessDisks
{
    public class bnsDisk
    {
        public List<domDisks> listar()
        {
             
            List<domDisks> list = new List<domDisks>();
            SqlConnection conection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                conection.ConnectionString = "server= .\\SQLEXPRESS; database = DISCOS_DB; integrated security = true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT D.Titulo,D.FechaLanzamiento,D.CantidadCanciones, D.UrlImagenTapa, T.Descripcion FROM DISCOS D, TIPOSEDICION T WHERE D.IdTipoEdicion = T.Id";
                cmd.Connection = conection;

                conection.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    domDisks Aux = new domDisks();
                    Aux.Title = (string)reader["Titulo"];
                    Aux.release = (DateTime)reader["FechaLanzamiento"];
                    Aux.mount = reader.GetInt32(2);
                    Aux.URLdisks = (string)reader["UrlImagenTapa"];
                    Aux.Descripcion = new diskEdicion();
                    Aux.Descripcion.description = (string)reader["Descripcion"];

                    list.Add(Aux);

                }
                conection.Close();
                return list;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void add(domDisks addnew)
        {
            dataAcces data = new dataAcces();
            try
            {

                data.setearQuery("INSERT INTO DISCOS(Titulo, CantidadCanciones, UrlImagenTapa) values('" + addnew.Title +"',"+ addnew.mount + ", '"+addnew.URLdisks+"')");
                data.actioneject();

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                data.closeconection();   
            }
        }

    }
}