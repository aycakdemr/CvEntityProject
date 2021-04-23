using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Admins
                        where x.UserName ==
                        TextBox1.Text && x.Password == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("Contact.Aspx");
            }
            else
            {
                Response.Write("hatalı giriş");
            }


        }
    }
}