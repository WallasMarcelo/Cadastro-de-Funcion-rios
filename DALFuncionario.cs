using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;

namespace DAL
{
    public class DALFuncionario
    {
        SqlConnection cn = new SqlConnection(clsconexaoBanco.conexaoBanco);


        public void inserirFuncionario(MODFuncioinario funcioinario)
        {
            SqlCommand cmd =  new SqlCommand("insereFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", funcioinario.Nome);
                cmd.Parameters.AddWithValue("@endereco", funcioinario.Endereco);
                cmd.Parameters.AddWithValue("@idMunicipio", funcioinario.IdMunicipio);
                cmd.Parameters.AddWithValue("@cep", funcioinario.Cep);
                cmd.Parameters.AddWithValue("@telefone", funcioinario.Tel);
                cmd.Parameters.AddWithValue("@email", funcioinario.Email);
                cmd.Parameters.AddWithValue("@cpf", funcioinario.Cpf);
                cmd.Parameters.AddWithValue("@rg", funcioinario.Rg);
                cmd.Parameters.AddWithValue("@salario", funcioinario.Salario);
                cmd.Parameters.AddWithValue("dataCadastro", funcioinario.DataCadastro);
                cmd.Parameters.AddWithValue("@situacao", funcioinario.Situacao);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        public void editarFuncioionario(MODFuncioinario funcioinario)
        {
            SqlCommand cmd = new SqlCommand("atualizaFuncioinario", cn);


            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFuncioinario", funcioinario.IdFuncionario);
                cmd.Parameters.AddWithValue("@nome", funcioinario.Nome);
                cmd.Parameters.AddWithValue("@endereco", funcioinario.Endereco);
                cmd.Parameters.AddWithValue("@idMunicipio", funcioinario.IdMunicipio);
                cmd.Parameters.AddWithValue("@cep", funcioinario.Cep);
                cmd.Parameters.AddWithValue("@telefone", funcioinario.Tel);
                cmd.Parameters.AddWithValue("@email", funcioinario.Email);
                cmd.Parameters.AddWithValue("@cpf", funcioinario.Cpf);
                cmd.Parameters.AddWithValue("@rg", funcioinario.Rg);
                cmd.Parameters.AddWithValue("@salario", funcioinario.Salario);
                cmd.Parameters.AddWithValue("dataCadastro", funcioinario.DataCadastro);
                cmd.Parameters.AddWithValue("@situacao", funcioinario.Situacao);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        public DataTable buscaFuncionarioNome(String nome)
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@funcionario", nome);
                cmd.Parameters.AddWithValue("@cpf", "");
                cmd.Parameters.AddWithValue("@situacao", "");
                cmd.Parameters.AddWithValue("@opcao", 1);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public DataTable buscaFuncionarioCPF(String cpf)
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@opcao", 2);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public DataTable buscaFuncionarioSituacao(bool situacao)
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@situacao", situacao);
                cmd.Parameters.AddWithValue("@opcao", 3);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable buscaFuncionarioTodos()
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opcao", 4);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable buscaFuncionarioData(DateTime data1, DateTime data2)
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@data1", data1);
                cmd.Parameters.AddWithValue("@data2", data2);
                cmd.Parameters.AddWithValue("@opcao", 6);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public DataTable buscaFuncionarioID(int id)
        {
            SqlCommand cmd = new SqlCommand("buscaFuncionario", cn);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFuncionario", id);
                cmd.Parameters.AddWithValue("@opcao", 5);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
