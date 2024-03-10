using System;
using Aula02RH.Models;


namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();
            

            /*Func.Id = 10;
            Func.Nome = "jacinto";
            Func.Cpf ="12345678966";
            Func.DataAdmissao = DateTime.Parse("01/12/14");
            Func.Salario = 48937.00M;
            Func.TipoFuncionario = models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = Func.ExibirPeriodoExperiencia();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(mensagem);
            Console.WriteLine("-------------------------------------------------");*/

            Console.WriteLine("Digite o ID do funcionarrio: ");
            Func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do funcionarrio: ");
            Func.Nome = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CPF do funcionarrio: ");
            Func.Cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de admissão do funcionarrio: ");
            Func.DataAdmissao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario do funcionarrio: ");
            Func.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo de contrato do funcionarrio (sendo 1 para CLT e 2 para aprendiz): ");
            Func.TipoFuncionario = int.Parse(Console.ReadLine());


             string mensagem = Func.ExibirPeriodoExperiencia();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(mensagem);
            Console.WriteLine("-------------------------------------------------");
            
        }
    }
}
