using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncryptLoginPassword
{
    public partial class TestPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ref: https://chandradev819.wordpress.com/2011/04/11/how-to-encrypt-and-decrypt-password-in-asp-net-using-c/

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string epass = Helper.ComputeHash(TextBox1.Text, "SHA512", null);

            lblmsg1.Text = epass;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string epass = Helper.ComputeHash(TextBox1.Text, "SHA512", null);
            bool isValid = Helper.VerifyHash(TextBox1.Text, "SHA512", epass);

            if (isValid)
            {
                Response.Write("Valid user");
            }
            else {
                Response.Write("Invalid user");
            }
        }
    }
}