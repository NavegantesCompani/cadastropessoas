// See https://aka.ms/new-console-template for more information
using System;
namespace Atividade
{
    class Program
    {
        //todoas as vezes que entrar na classe prog deve entrar com essa estrutura de main (string [] args)
        static void Main(string[] args)
        {


            float val_pag;
            //aqui voce chama as variaveis em comum as duas classes vinda da classe pai
            // e direciona
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                // --- Pessoa Física ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                //aqui voce atribui a variavel da classe pai e renomeia ela 
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                //aqui voce imprimi e le o que o usuario escreve
                //e faz o estanciamento de classes para chamar elas aqui na program

                Console.WriteLine("Informar CPF:");
                pf.Cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.Rg = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);
                //aqui começa a imprimir na tela tudo que foi pedido acima
                Console.WriteLine("-------- Pessoa Física -------- ");

                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.Cpf);
                Console.WriteLine("RG ............: " + pf.Rg);
                Console.WriteLine("Valor de Compra: " +
               pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " +
               pf.Valor_Imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " +
               pf.Total.ToString("C"));
            }
            if (var_tipo == "j")
            //o segundo caso é para pessoa juridica
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.Ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("--------Pessoa Jurídica -------- ");


                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
                Console.WriteLine("IE ............: " + pj.Ie);
                Console.WriteLine("Valor de Compra: " +
                    pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " +
                    pj.Valor_Imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " +
                    pj.Total.ToString("C"));
            }
        }
    }
}


            

