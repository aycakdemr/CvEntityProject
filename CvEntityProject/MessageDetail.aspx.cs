using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class MessageDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();
            int id = int.Parse(Request.QueryString["Id"]);
            var message = db.Contacts.Find(id);
            txtAsSoyad.Text = message.Name;
            txtMail.Text = message.Email;
            txtKonu.Text = message.Topic;
            txtMessage.Text = message.Message;
        }
    }
}