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
            imgTeste.Attributes["src"] = "C:/Users/Will/Pictures/teste/" + tabela.Rows[0][1].ToString();
            string resul = imgTeste.Attributes["src"];
            //int cont = 0;
            //while ( cont < tabela.Rows.Count) {
            //    slideshow.Controls.Add(new HtmlImage()
            //    {
            //        Src = "C:/Users/Will/Pictures/teste/" + tabela.Rows[cont][1].ToString(),
            //        Alt = tabela.Rows[cont][2].ToString(),
            //        Width = 200,
            //        Height = 200
            //    });
            //    cont++;
            //}
        }











        protected void btnBanco_Click(object sender, EventArgs e)
        {

        }
    }
}