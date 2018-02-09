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

                DataTable dt = ObjBanco.ExecuteProc(@"
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

                DataTable dt = ObjBanco.ExecuteProc("select * from foto where descricao like '%" + parametro + "%' ", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}