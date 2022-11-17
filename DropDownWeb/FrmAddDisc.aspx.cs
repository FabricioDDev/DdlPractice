using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace DropDownWeb
{
    public partial class FrmAddDisc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                ReChargePage();
        }
        public void ReChargePage()
        {
            ChargeDDLGenre();
            
        }
        public void ChargeDDLGenre()
        {
            GenreData genreData = new GenreData();
            DdlGenre.DataSource = genreData.List();
            DdlGenre.DataValueField = "Id";
            DdlGenre.DataTextField = "Name";
            DdlGenre.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Disc newDisc = new Disc();
            DiscData discData = new DiscData();
            try
            {
                newDisc.Name = TxtName.Text;
                newDisc.Genre = new Genre();
                newDisc.Genre.Id = int.Parse(DdlGenre.SelectedValue);
                discData.Add(newDisc);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}