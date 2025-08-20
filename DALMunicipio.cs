using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL
{
    public class DALMunicipio
    {
        SqlConnection cn = new SqlConnection(clsconexaoBanco.conexaoBanco);


        public void inserirMunicipios(MODMunicipio municipio)
        {
            SqlCommand cmd = new SqlCommand("insereMunicipio",cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@municipio", municipio.Municipio);
                cmd.Parameters.AddWithValue("@estado", municipio.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void editarMunicipios(MODMunicipio municipio)
        {
            SqlCommand cmd = new SqlCommand("atualizaMunicipio", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMunicipio", municipio.IdMunicicpio);
                cmd.Parameters.AddWithValue("@municipio", municipio.Municipio.ToString());
                cmd.Parameters.AddWithValue("@estado", municipio.Estado);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable listarMunicipios(String municipio)
        {
            SqlCommand cmd = new SqlCommand("buscaMunicipio", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@municipio", municipio);
                cmd.Parameters.AddWithValue("@opcao", 2);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable listaMunicipios(String municipio)
        {
            SqlCommand cmd = new SqlCommand("buscaMunicipio", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@municipio", municipio);
                cmd.Parameters.AddWithValue("@opcao", 2);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listaMunicipioID(int idMunicipio)
        {
            SqlCommand cmd = new SqlCommand("buscaMunicipio", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMunicipio", idMunicipio);
                
                cmd.Parameters.AddWithValue("@opcao", 3);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable listaMunicipioTodos()
        {
            SqlCommand cmd = new SqlCommand("buscaMunicipio", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opcao", 1);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }





    }
}
