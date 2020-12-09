using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Forms;

namespace MedClinic
{
    public partial class Send_code : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
        }

       

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
           
        }
    }
}