using gerArquivos.Models.vo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace gerArquivos.Models
{
    public class repoArquivo : IDisposable
    {
        conexao conn = null;

        public void Dispose()
        {
            if (conn != null)
            {
                conn.fechar();
                conn.Dispose();
            }
        }

        public repoArquivo()
        {
            this.conn = new conexao();
        }

        
      
        public Boolean addArquivo(voArquivo vo)
        {
            SQLiteCommand command = null;

            try
            {
                String sql = "insert into tbarquivo(nomArq, datIncArq) values ('{0}', '{1}' )";

                command = new SQLiteCommand();
                command.Connection = conn.open();
                command.CommandText = string.Format(sql, vo.Nome, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                command.ExecuteNonQuery();
                command.Dispose();


                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + command.Connection.ConnectionString);                
            }
            finally
            {
                if (command != null) command.Dispose();
            }

        }

        public Boolean delItem(voArquivo vo)
        {
            SQLiteCommand command = null;

            try
            {
                String sql = "delete from where idArq={0} ";

                command = new SQLiteCommand();
                command.Connection = conn.open();
                command.CommandText = string.Format(sql, vo.Id);

                command.ExecuteNonQuery();
                command.Dispose();


                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command != null) command.Dispose();
            }

        }
                     

        public List<voArquivo> Lista()
        {
            List<voArquivo> lista = new List<voArquivo>();

            try
            {
                voArquivo vo = null;

                string sql = "select idArq, nomArq, datIncArq from tbarquivo order by datIncArq  ";                

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn.open();

                command.CommandText = sql;

                SQLiteDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<voArquivo>();

                    while (dr.Read())
                    {
                        vo = new voArquivo()
                        {
                            Id = Convert.ToInt32(dr["idArq"]),
                            Nome = Convert.ToString(dr["nomArq"]),
                            DataInclusao = Convert.ToDateTime(dr["datIncArq"])
                        };

                        lista.Add(vo);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }        
    }
}
