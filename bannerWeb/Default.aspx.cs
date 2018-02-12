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
        
        private void carregaFoto()
        {
            
            Banner teste = new Banner();
            DataTable tabela = new DataTable();
           
            List<Foto> listaFoto = new List<Foto>();
            tabela = teste.Carregar();
            int cont=0;
            while (cont < tabela.Rows.Count)
            {
                Foto foto = new Foto();
                foto.nomeArquivo = tabela.Rows[cont][1].ToString();
                foto.descricao = tabela.Rows[cont++][2].ToString();
                listaFoto.Add(foto);
            }
            this.fotos.DataSource = listaFoto;
            this.fotos.DataBind();


        }

        private void Pesquisa()
        {

            Banner teste = new Banner();
            DataTable tabela = new DataTable();

            List<Foto> listaFoto = new List<Foto>();
            tabela = teste.Pesquisar(tbPesquisa.Text);
            int cont = 0;
            while (cont < tabela.Rows.Count)
            {
                Foto foto = new Foto();
                foto.nomeArquivo = tabela.Rows[cont][1].ToString();
                foto.descricao = tabela.Rows[cont++][2].ToString();
                listaFoto.Add(foto);
            }
            this.fotos.DataSource = listaFoto;
            this.fotos.DataBind();


        }

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }
    }
}
