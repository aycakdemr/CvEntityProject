using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Istatistics : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Abilities.Count().ToString();
            Label2.Text = db.Contacts.Count().ToString();
            Label3.Text = db.Abilities.Average(x => x.Degree).ToString();
            Label4.Text = db.Abilities.Max(x => x.Degree).ToString();
        }
    }
}