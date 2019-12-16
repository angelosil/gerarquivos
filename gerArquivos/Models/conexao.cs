using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

using gerArquivos.Models;

namespace gerArquivos.Models
{
    public class conexao : IDisposable
    {

        
        public void Dispose()
        {
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        SQLiteConnection conn = null;

        private String caminhodb = string.Concat(Environment.CurrentDirectory, ConfigurationManager.AppSetting["caminhobanco:key"]);

        public conexao()
        {
            //if (conn == null) conn = new SQLiteConnection();                
        }

        public SQLiteConnection open()
        {
            try
            {
                String strConn = @"Data Source=" + caminhodb + ";UseUTF8Encoding=True;";

                if (conn == null) conn = new SQLiteConnection(strConn);


                if (conn.State != System.Data.ConnectionState.Open) conn.Open();

                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fechar()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
