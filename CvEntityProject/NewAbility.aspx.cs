using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class NewAbility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Abilities a = new Abilities();
            a.Ability = TextBox1.Text;
            db.Abilities.Add(a);
            db.SaveChanges();
            Response.Redirect("Abilities.aspx");

        }
    }
}