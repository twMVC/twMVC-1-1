using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var source = new string[] { "A", "B", "C" };
            //this.DropDownList1.DataSource = source;
            //this.DropDownList1.DataBind();
            this.GridView1.DataSource = source;
            this.GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text=DateTime.Now.ToString();
        }
    }
}