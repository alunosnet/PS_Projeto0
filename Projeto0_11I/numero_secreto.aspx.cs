using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto0_11I
{
    public partial class numero_secreto : System.Web.UI.Page
    {
        int nrsecreto;
        int nrtentativas;
        protected void Page_Load(object sender, EventArgs e)
        {
            //só deve executar a primeira vez
            if (IsPostBack == false)
            {
                Random numero = new Random();
                nrsecreto = numero.Next(1, 10);
                Session["nrsecreto"] = nrsecreto;
                nrtentativas = 3;
                Session["nrtentativas"] = nrtentativas;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int resposta = int.Parse(TextBox1.Text);
            nrsecreto = int.Parse(Session["nrsecreto"].ToString());
            nrtentativas = int.Parse(Session["nrtentativas"].ToString());
            if (resposta == nrsecreto)
            {
                Label1.Text = "Certo";
                Button2.Visible = true;
                Button1.Visible = false;
            }
            else
            {
                nrtentativas--;
                Session["nrtentativas"] = nrtentativas;
                if (nrtentativas <= 0)
                {
                    Label1.Text = $"O número secreto era {nrsecreto}";
                    Button2.Visible = true;
                    Button1.Visible = false;
                    return;
                }
                if (nrsecreto < resposta)
                    Label1.Text = $"O número secreto é menor.Tem {nrtentativas} tentativas";
                else
                    Label1.Text = $"O número secreto é maior.Tem {nrtentativas} tentativas";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
            nrsecreto = numero.Next(1, 10);
            Session["nrsecreto"] = nrsecreto;
            nrtentativas = 3;
            Session["nrtentativas"] = nrtentativas;
            Button1.Visible = true;
            Button2.Visible = false;
            Label1.Text = "";
        }
    }
}