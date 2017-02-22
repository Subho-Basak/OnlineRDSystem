using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuccessResponse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String ac = Request.QueryString["accountno"].ToString();
        int accountno = Convert.ToInt32(Request.QueryString["accountno"].ToString());
      
    }
}