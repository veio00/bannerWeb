﻿using bannerWeb.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace bannerWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClsBanner teste = new ClsBanner();
            DataTable tabela = new DataTable();
            tabela = teste.Carregar();
            int cont = 0;
            while (cont < tabela.Rows.Count)
            {
                slideshow.Controls.Add(new HtmlImage()
                {
                    Src = "~/Imagens/" + tabela.Rows[cont][1],
                    Alt = tabela.Rows[cont][2].ToString(),
                    Width = 200,
                    Height = 200
                });
                cont++;
            }
        }
        protected void btnBanco_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var mensagem = string.Empty;

            for (int i = 0; i < fImagem.PostedFiles.Count(); i++)
            {
                var file = fImagem.PostedFiles[i];
                file.SaveAs(Server.MapPath("~/Imagens/" + i + ".jpg"));

                mensagem = "Imagem gravada com sucesso!";

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Mensagem", "alert(' " + mensagem + "')", true);
            }
        }
    }
}
