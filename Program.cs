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
        }
    }
}
