using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class DiscData
    {
        public DiscData()
        {
            data = new DataAccess();
        }
        private DataAccess data;
        public List<Disc> ListSP()
        {
            List<Disc> List = new List<Disc>();
            try
            {
                data.SP("List_SP");
                data.Read();
                while (data.ReaderProp.Read())
                {
                    Disc aux = new Disc();
                    aux.Id = (int)data.ReaderProp["Id"];
                    aux.Name = (string)data.ReaderProp["Name"];
                    aux.Genre = new Genre();
                    aux.Genre.Name = (string)data.ReaderProp["GName"];
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
    
        public void Add(Disc newDisc)
        {
            try
            {
                data.Query("insert into Disco (Name, IdGenre) values (@Name, @IdGenre)");
                data.Parameters("@Name", newDisc.Name);
                data.Parameters("@IdGenre", newDisc.Genre.Id);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
