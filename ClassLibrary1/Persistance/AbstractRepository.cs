using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class AbstractRepository
    {
        public string ConnexionString { get; set; }

        public QueryFactory EntityManager { get; set; }

        public AbstractRepository(string connexionString)
        {
            ConnexionString = connexionString;
            SqlConnection connection = new SqlConnection(this.ConnexionString);
            SqlServerCompiler compiler = new SqlServerCompiler();
            this.EntityManager = new QueryFactory(connection, compiler);

        }
    }
}
