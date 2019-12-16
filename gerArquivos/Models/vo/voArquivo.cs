using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerArquivos.Models.vo
{
    public class voArquivo
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataInclusao { get; set; }
        public String pastaArquivo { get; set; }
        public List<string> Erros { get; set; }
        
        public voArquivo()
        {
            this.Erros = new List<string>();
           this.pastaArquivo = ConfigurationManager.AppSetting["caminhoimagem:Key"];
        }
    }
}
