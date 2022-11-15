using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class GenreData
    {
        public GenreData()
        {
            data = new DataAccess();
        }
        private DataAccess data;
        public List<Genre> ListSP()
        {
            List<Genre> List = new List<Genre>();
            try
            {
                data.Query("select Id, Name from Genre");
                data.Read();
                while (data.ReaderProp.Read())
                {
                    Genre aux = new Genre();
                    aux.Id = (int)data.ReaderProp["Id"];
                    aux.Name = (string)data.ReaderProp["Name"];
                    List.Add(aux);
                }
                return List;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
