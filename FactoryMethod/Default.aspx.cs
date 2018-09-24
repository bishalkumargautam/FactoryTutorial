using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using FactoryBO;
using FactoryBLL;

namespace FactoryMethod
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            IEmplBO emplBO = EmplFacBO.CheckEmployee(username, password);
            IEmplBLL emplBLL = EmplFacBLL.createnew();
            int check = emplBLL.CheckEmp(emplBO);
            if (check ==1)
            {
                Response.Redirect("~/successform.aspx");

            }
            else
            {
                Response.Redirect("~/Faliureform.aspx");

            }

        }
    }
}