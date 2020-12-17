using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto0_11I
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(tb.Text);
            Label1.Text = "";
            for(int i = 0; i <=10; i++)
            {
                
                Label1.Text += $"{nr} x {i} = {nr * i} <br/>";
            }
        }
    }
}