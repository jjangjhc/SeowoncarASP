using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeowoncarASP
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MetaDescription = "서원폐차장에서 폐차에서 말소까지 항상 신속하게! 정확하게!";
        }
    }
}