using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCOLAPLUS
{
    public class Aluno
    {
        public string Código { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string eMail { get; set; }
        //public string Nascimento { get; set; }

        public Aluno()
        {
            /*string Result = "";

            DateTime x = new DateTime();
            x = DateTime.Now;

            Result += x.Date.ToString().Substring(0, 2);
            Result += x.Minute.ToString();
            Result += x.Second.ToString();

            Código = Result;*/
            Código = Guid.NewGuid().ToString().Substring(1, 7);

        }
    }
}
