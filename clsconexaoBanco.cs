using System.Configuration;

namespace DAL
{
    public class clsconexaoBanco
    {
        private static string conexao = null;

        public static string conexaoBanco 
        {
           get 
            {
                return conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            } 
        }
    }
}
