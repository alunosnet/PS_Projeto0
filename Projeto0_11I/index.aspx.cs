using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto0_11I
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //é executada sempre que a página é submetida ao servidor

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //3 variáveis
            int n1, n2, n3;

            //guardar os números nas variáveis
            n1 = int.Parse(TextBox1.Text);
            n2 = int.Parse(TextBox2.Text);
            n3 = int.Parse(TextBox3.Text);

            //comparar os números
            int maior = n1;
            if (n2 > n1 && n2 > n3) maior = n2;
            if (n3 > n1 && n3 > n2) maior = n3;

            //mostrar o maior
            Label1.Text = "O maior é o " + maior;
        }
    }
}