using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using Projects.ViewModels;

namespace Empresa.DAL
{
    public class EmpresaDAL : IDisposable
    {

        public SqlConnection Connection { get; set; }

        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public void Salvar(EmpresaViewModel vm)
        {
            //using (Connection = new SqlConnection(ConnectionString))
            //{
            //    Connection.Open();

            //    Parameters.Add(new SqlParameter("@CustomerID", custId));

            //    Dispose();
            //}
            //SqlConnection connection = new SqlConnection(ConnectionString);

            //SqlCommand cmdCommand = new SqlCommand("emp_SalvarEmpresa", connection);

            //cmdCommand.CommandType = CommandType.StoredProcedure;
            //cmdCommand.Parameters.Add("@CNPJ", SqlDbType.VarChar, 15).Value = vm.cnpj;

            //connection.Open();
            //cmdCommand.ExecuteNonQuery();
            //connection.Dispose();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}