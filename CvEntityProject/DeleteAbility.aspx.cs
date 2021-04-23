using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class DeleteAbility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();
            int x = Convert.ToInt32(Request.QueryString["Id"]);
            var ability = db.Abilities.Find(x);
            db.Abilities.Remove(ability);
            db.SaveChanges();
            Response.Redirect("Abilities.Aspx");
        }
    }
}