using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto0_11I
{
    public partial class Soma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)//primeira vez que a página é pedida
            {
                Tb1.Text = "0";
                Tb2.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2;

            n1 = int.Parse(Tb1.Text);
            n2 = int.Parse(Tb2.Text);

            int soma = n1 + n2;
            //Label1.Text = soma.ToString();
            Label1.Text = $"A soma de {n1} com {n2} é igual a {soma}";
        }
    }
}