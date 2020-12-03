using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class cv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            Session["Name"] = TxtName.Text;

            Session["Contact"] = TxtContact.Text;
            Session["Address"] = TxtAddress.Text;

            Session["Personal"] = TxtPprofile.Text;

            Session["Achievement"] = TxtAchievement.Text;

            Session["Education from-to"] = TxtEducation1.Text;
            Session["Course"] = TxtEducationc1.Text;
            Session["Insititue"] = TxtEducationi1.Text;
            Session["Work Experience from-to"] = Txtwork1.Text;
            Session["Job Position"] = Txtworkj1.Text;

            Session["Company"] = Txtworkcm1.Text;

            Response.Redirect("outcome.aspx");

        }
    }
}