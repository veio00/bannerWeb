using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bannerWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var mensagem = string.Empty;

            for (int i = 0; i < fupImagem.PostedFiles.Count(); i++)
            {
                var file = fupImagem.PostedFiles[i];
                file.SaveAs(Server.MapPath("~/Imagens" + i + ".jpg"));

                mensagem = "Imagem gravada com sucesso!";

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Mensagem", "alert(' " + mensagem + "')", true);
            }
        }
    }
}
//C:\Users\crs_9_000\Source\Repos\bannerWeb2\bannerWeb\Imagens\