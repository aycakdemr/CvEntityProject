using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class UpdateAbility : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            if (Page.IsPostBack == false)
            {
                var ability = db.Abilities.Find(id);
                TextBox1.Text = ability.Ability;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var ability = db.Abilities.Find(id);
            ability.Ability = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Abilities.Aspx");
        }
    }
}