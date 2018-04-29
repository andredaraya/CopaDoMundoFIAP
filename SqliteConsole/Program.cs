using System;
using System.Data.SQLite;
using System.IO;

namespace SqliteConsole
{
    class Program
    {
        
        static string path = @"c:\sqlite\";
        static string file = "base_da_copa.sqlite";
        static void Main(string[] args)
        {
            Console.WriteLine("Criando  Banco e Tabelas do  projeto!");
            CriacaoDaBase();
            CriaTabelas();
            Console.WriteLine("Criação  de base finalizada");
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();

        }

        private static void CriaTabelas()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={path+file};Version=3;");
            m_dbConnection.Open();


            string sql = "create table selecao (ID integer primary key autoincrement , Nome varchar(100), QuantidadeTitulos int, CriadoEm DateTime , Ativo bit)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table jogador (ID integer primary key autoincrement , Nome varchar(100), Apelido varchar(50), Idade int, Posicao varchar(30), Selecao int, CriadoEm DateTime , Ativo bit)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        private static void CriacaoDaBase()
        {

            FileInfo fi = new FileInfo(path+file);
            
            if (!fi.Exists)
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    if (!di.Exists)
                        Directory.CreateDirectory(path);

                    SQLiteConnection.CreateFile(path+file);
                    Console.WriteLine($"Banco de dados criado em {path} ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Não foi possível criar o banco de dados criado em {path} ");
                    Console.WriteLine($"Erro : {ex.Message}");
                }
            }
        }
    }
}
