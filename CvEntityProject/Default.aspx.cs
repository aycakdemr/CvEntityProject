using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Abouts.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.Abouts.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.Abouts.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.Abilities.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Contacts c = new Contacts();
            c.Name = TextBox1.Text;
            c.Email = TextBox2.Text;
            c.Topic = TextBox3.Text;
            c.Message = TextBox4.Text;
            db.Contacts.Add(c);
            db.SaveChanges();
        }
    }
}