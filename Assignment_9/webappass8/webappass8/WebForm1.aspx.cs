using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webappass8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        twinkle.WebService1 ws = new twinkle.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adddata(object sender, EventArgs e)
        {
            ans.Text = ws.add(Convert.ToInt16(no1.Text), Convert.ToInt16(no2.Text)).ToString();
        }

        protected void subdata(object sender, EventArgs e)
        {
            ans.Text = ws.sub(Convert.ToInt16(no1.Text), Convert.ToInt16(no2.Text)).ToString();

        }

        protected void divdata(object sender, EventArgs e)
        {
            ans.Text = ws.div(Convert.ToInt16(no1.Text), Convert.ToInt16(no2.Text)).ToString();
        }

        protected void muldata(object sender, EventArgs e)
        {
            ans.Text = ws.mul(Convert.ToInt16(no1.Text), Convert.ToInt16(no2.Text)).ToString();
        }
    }
}