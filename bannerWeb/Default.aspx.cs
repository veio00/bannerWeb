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
            bool upload = false;
            for (int i = 0; i < fImagem.PostedFiles.Count(); i++)
            {
                var file = fImagem.PostedFiles[i];
                file.SaveAs(Server.MapPath("~/Imagens/imagem" + i + ".jpg"));

                Banner teste = new Banner();
                upload = teste.SalvarUpload("imagem" + teste.UltimaImagem()+1 + ".jpg",txtDescricao.Text,padrao);

                //mensagem = "Imagem gravada com sucesso!";

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Mensagem", "alert(' " + mensagem + "')", true);
            }

            if(upload == true)
            {
                mensagem = "Imagem gravada com sucesso!";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Mensagem", "alert(' " + mensagem + "')", true);
            }
            else
            {
                mensagem = "Imagem ou imagens não puderam ser carregadas! Por favor tentar novamente";
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
        public int padrao;
        protected void ImagemPadrao(object sender, EventArgs e)
        {
            if(cbPadrao.Checked == true)
            {
                padrao = 1;
            }
            else
            {
                padrao = 0;
            }
        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            string selectedValue="";
            var selected = cbDias.Items.Cast<ListItem>().Where(x => x.Selected);
            foreach (ListItem item in cbDias.Items)
            {
                if (item.Selected)
                {
                    selectedValue = item.Value + "," + selectedValue;
                }
            }
            string testes = selectedValue;
            Banner teste = new Banner();
            //teste.SalvarAgendamento(DateTime.Parse(txtInicio.Text), DateTime.Parse(txtFim.Text), "", 1);
        }
    }
}
