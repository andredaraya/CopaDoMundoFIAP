using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.WebApi.Dados.Repositorio
{
    public class RepositorioBase
    {
        private readonly string path = @"c:\sqlite\";

        private readonly string file = "base_da_copa.sqlite";

        public SqliteConnection GetConnection()
        {
            var m_dbConnection = new SqliteConnection($"Data Source={path + file}");
            return m_dbConnection;
        }
    }
}
