using bannerWeb.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace bannerWeb.Banco
{
    public class Banner
    {
        
        private Banco ObjBanco;

        public Banner()
        {
            ObjBanco = new Banco();
        }
        ~Banner()
        {
            ObjBanco = null;
        }

        public DataTable Carregar()
        {
            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery(@"
                    select * from foto f inner join agendamento a on f.id = a.id 
                    where  inicio >= getdate()
               ", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public DataTable Pesquisar(string parametro)
        {
            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery("select * from foto where descricao like '%" + parametro + "%' ", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool SalvarUpload (string nomeArquivo, string descricao, int padrao)
        {

            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery("insert into Foto values('"+ nomeArquivo + "','"+ descricao + "',"+ padrao + ")", LstParametros);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool SalvarAgendamento(DateTime inicio, DateTime fim, string dias, int idFoto)
        {

            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery("insert into Agendamento values('" + inicio + "','" + fim + "','" + dias + "'," + idFoto + ")", LstParametros);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}