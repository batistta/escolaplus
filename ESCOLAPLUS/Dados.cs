using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ESCOLAPLUS
{
    class Dados
    {
        private ArrayList Cadastro;
        
        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }
        public Aluno PesquisarAluno(string Cód)
        {
            foreach (Aluno x in Cadastro)
            {
                if (x.Código == Cód)
                    return x;
            }
            return null;
        }
        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);
        }
        public void AlterarAluno(Aluno x, Aluno y)
        {
            int Posicao;
            Posicao = Cadastro.IndexOf(x);
            Cadastro.Remove(x);
            Cadastro.Insert(Posicao, y);
        }
        public int OrdenarAlunos()
        {
            Cadastro.Sort(new MinhaOrdenacao());
            return Cadastro.Count;
        }
        public class MinhaOrdenacao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
            }
        }
        public int SalvarXMLAlunos()
        {
            TextWriter MeuWriter = new StreamWriter(@"C:\Windows\Temp\ArquivoAluno.xml");

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer MinhaSerialização = new XmlSerializer(ListaAlunoVetor.GetType());
            MinhaSerialização.Serialize(MeuWriter, ListaAlunoVetor);
            MeuWriter.Close();
            return Cadastro.Count;
        }
        public int LerXMLAlunos()
        {
            TextReader Arquivo = new StreamReader(@"C:\Windows\Temp\ArquivoAluno.xml");

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));
            XmlSerializer MinhaSerialização = new XmlSerializer(ListaAlunoVetor.GetType());
            ListaAlunoVetor = (Aluno[])MinhaSerialização.Deserialize(Arquivo);

            Cadastro.Clear();
            Cadastro.AddRange(ListaAlunoVetor);
            Arquivo.Close();

            return Cadastro.Count;
        }
    }
}
