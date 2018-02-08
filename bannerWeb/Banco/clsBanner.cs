using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace bannerWeb.Banco
{
    public class ClsBanner
    {
        private Banco ObjBanco;

        public ClsBanner()
        {
            ObjBanco = new Banco();
        }
        ~ClsBanner()
        {
            ObjBanco = null;
        }

        public DataTable Carregar()
        {
            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteProc("select * from foto", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}