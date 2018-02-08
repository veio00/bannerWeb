﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bannerWeb.Banco
{
    public class Banco
    {
        private SqlConnection GerarConexao()
        {
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings["CONEXAO"]
                    .ConnectionString;

                if (!string.IsNullOrEmpty(strConn))
                {
                    SqlConnection conexao = new SqlConnection(strConn);
                    return conexao;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private SqlConnection AbrirConexao()
        {
            SqlConnection cn = GerarConexao();

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FecharConexao(SqlConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ExecuteProc(string strNomeProc, List<SqlParameter> lstParametros)
        {
            try
            {
                DataTable dtDados = new DataTable();
                using (SqlConnection sqlConexao = AbrirConexao())
                {
                    using (SqlCommand sqlComando = new SqlCommand(strNomeProc, sqlConexao))
                    {
                        sqlComando.CommandType = System.Data.CommandType.Text;

                        if (lstParametros != null)
                        {
                            sqlComando.Parameters.AddRange(lstParametros.ToArray());
                        }

                        using (SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando))
                        {
                            sqlAdaptador.Fill(dtDados);
                        }
                    }

                    FecharConexao(sqlConexao);
                }

                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}