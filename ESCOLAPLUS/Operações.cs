using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ESCOLAPLUS
{
    class Operações
    {
        FormHOME MeuForm = new FormHOME();
        Dados MeusDados = new Dados();
        Aluno MeuAluno = new Aluno();

        public void CodigoAluno()
        {

        }
        public void Inserir()
        {
            MeuAluno.Nome = MeuForm.txtNOME.Text;
            MeuAluno.Telefone = MeuForm.mskTELEFONE.Text;
            MeuAluno.eMail = MeuForm.txtEMAIL.Text;
            MeusDados.InserirAluno(MeuAluno);
            MeusDados.SalvarXMLAlunos();
            MeuForm.txtEMAIL.Clear();
            MeuForm.txtNOME.Clear();
            MeuForm.mskTELEFONE.Clear();
            MessageBox.Show("Aluno salvo com sucesso!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Listar()
        {
            ArrayList Lista = MeusDados.ListarAlunos();
            Console.Clear();

            Console.WriteLine("Listagem geral do cadastro de alunos.");
            Console.WriteLine("=====================================");


            foreach (Aluno x in Lista)
            {
                Console.WriteLine("{0} ({1})", x.Nome, x.Código);
                Console.WriteLine("Telefone: {0}", x.Telefone);
                Console.WriteLine("eMail...:\n", x.eMail);
            }

            Console.WriteLine("\nTotal de registros: {0}", Lista.Count);
            Console.ReadKey();
        }
        public void Pesquisar()
        {
            //Aluno MeuAluno;
            string CodPesq;
            Console.Clear();
            Console.WriteLine("Pesquisa de alunos no cadastro: ");
            Console.WriteLine("==============================\n");

            Console.Write("Código:::::::::");
            CodPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);

            if (MeuAluno != null)
            {
                Console.WriteLine("\nNome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.WriteLine("Telefone:::: {0} ", MeuAluno.Telefone);
                Console.WriteLine("E-mail:::::: {0} ", MeuAluno.eMail);
            }
            else
                Console.WriteLine("\nAluno não cadastrado!!!!");

            Console.ReadKey();


        }
        public void Excluir()
        {
            Aluno MeuAluno;
            string CodPesq;
            Console.Clear();
            Console.WriteLine("Exclusão de alunos no cadastro: ");
            Console.WriteLine("==============================\n");

            Console.Write("Código:::::::::");
            CodPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);

            if (MeuAluno != null)
            {
                Console.WriteLine("\nNome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.WriteLine("Telefone:::: {0} ", MeuAluno.Telefone);
                Console.WriteLine("E-mail:::::: {0} ", MeuAluno.eMail);
                MeusDados.ExcluirAluno(MeuAluno);
                Console.WriteLine("O aluno foi excluído do cadastro:::");
            }
            else
                Console.WriteLine("\nAluno não cadastrado!!!!");
            Console.ReadKey();
        }
        public void Alterar()
        {
            Aluno MeuAluno;
            Aluno MeuAlunoAlterado;
            string CodPesq;
            Console.Clear();
            Console.WriteLine("Alteração de dados de alunos: ");
            Console.WriteLine("==============================\n");

            Console.Write("Código:::::::::");
            CodPesq = Console.ReadLine();

            MeuAluno = MeusDados.PesquisarAluno(CodPesq);

            if (MeuAluno != null)
            {
                MeuAlunoAlterado = new Aluno();
                Console.WriteLine("\nNome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.WriteLine("Telefone:::: {0} ", MeuAluno.Telefone);
                Console.WriteLine("E-mail:::::: {0} ", MeuAluno.eMail);

                Console.WriteLine("\n\nDados para atualização: \n");

                Console.WriteLine("     Nome do aluno: ");
                MeuAlunoAlterado.Nome = Console.ReadLine();
                Console.WriteLine("     Telefone do aluno: ");
                MeuAlunoAlterado.Telefone = Console.ReadLine();
                Console.WriteLine("     E-mail do aluno: ");
                MeuAlunoAlterado.eMail = Console.ReadLine();

                MeuAlunoAlterado.Código = MeuAluno.Código;
                MeusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);

                Console.WriteLine("\n\nDados alterados com sucesso:::");
            }
            else
                Console.WriteLine("\nAluno não cadastrado!!!!");
            Console.ReadKey();
        }
        public void Ordenar()
        {
            Console.Clear();

            int Registros;
            Console.WriteLine("Ordenação de registros no cadastro: ");
            Console.WriteLine("===================================\n");
            Registros = MeusDados.OrdenarAlunos();
            Console.WriteLine("Total de registros: {0}", Registros);

            Console.ReadKey();
        }
        public void SalvarXML()
        {
            int TotReg;
            Console.Clear();
            Console.WriteLine("Gravar registros em arquivo");
            Console.WriteLine("===========================");

            TotReg = MeusDados.SalvarXMLAlunos();
            Console.WriteLine("Arquivo XML gerado com sucesso...");
            Console.WriteLine("Total de registros: {0}", TotReg);
            Console.ReadKey();
        }
        public void LerXML()
        {
            int TotReg;
            Console.Clear();
            Console.WriteLine("Recuperar registros de arquivo XML");
            Console.WriteLine("==================================");

            TotReg = MeusDados.LerXMLAlunos();
            Console.WriteLine("Arquivo XML carregado com sucesso...");
            Console.WriteLine("Total de registros: {0}", TotReg);
            Console.ReadKey();
        }
    }
}
