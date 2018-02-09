using bannerWeb.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using bannerWeb.Model;


namespace bannerWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregaFoto();
        }
        protected void btnBanco_Click(object sender, EventArgs e)
        {
            //teste.Carregar();
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
        
        public List<clsFoto> carregaFoto()
        {
            ClsBanner teste = new ClsBanner();
            DataTable tabela = new DataTable();
            clsFoto foto = new clsFoto();
            List<clsFoto> listaFoto = new List<clsFoto>();
            tabela = teste.Carregar();
            int cont=0;
            while (cont < tabela.Rows.Count)
            {
                foto.nomeArquivo = tabela.Rows[cont][1].ToString();
                foto.descricao = tabela.Rows[cont][2].ToString();
                listaFoto.Add(foto);
                cont++;
            }
            return listaFoto;
        }

    }
}
