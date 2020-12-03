using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class outcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Name"].ToString() != "")
            {
                LblName.Text = Session["Name"].ToString();

                LblContact.Text = Session["Contact"].ToString();
                LblAddress.Text = Session["Address"].ToString();

                LblPprofile.Text = Session["Personal"].ToString();

                LblAchievement.Text = Session["Achievement"].ToString();

                LblEducation1.Text = Session["Education from-to"].ToString();
                LblEducationc1.Text = Session["Course"].ToString();
                LblEducationi1.Text = Session["Insititue"].ToString();

                Lblwork1.Text = Session["Work Experience from-to"].ToString();
                Lblworkj1.Text = Session["Job Position"].ToString();
                Lblworkcm1.Text = Session["Company"].ToString();
            }
            else
            {
                Response.Redirect("cv.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cv.aspx");
        }
    }
}