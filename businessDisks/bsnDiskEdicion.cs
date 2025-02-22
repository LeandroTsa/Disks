using businessDisks;
using Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace businessDisks
{
    public class bsnDiskEdicion
    {
        public List<diskEdicion> Listaedicion()
        {

            List<diskEdicion> listaedicion = new List<diskEdicion>();
            dataAcces dataAcces = new dataAcces();
            try
            {
                dataAcces.setearQuery("SELECT Id,Descripcion FROM TIPOSEDICION");
                dataAcces.readerEjecucion();

                while (dataAcces.Reader.Read())
                {
                    diskEdicion aux = new diskEdicion();
                    aux.id = (int)dataAcces.Reader["Id"];
                    aux.description = (string)dataAcces.Reader["Descripcion"];

                    listaedicion.Add(aux);
                }

                return listaedicion;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}


