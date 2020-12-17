using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto0_11I
{
    public partial class enforcado : System.Web.UI.Page
    {
        //lista de palavras
        string[] palavras = { "gato", "carro", "enforcado" };
        string mostrar = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Random numero = new Random();
                int posicao = numero.Next(0, palavras.Length - 1);
                for (int i = 0; i < palavras[posicao].Length; i++)
                    mostrar += "-";
                Label1.Text = mostrar;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string letra = TextBox1.Text;

        }
    }
}