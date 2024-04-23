using ExemploPOO.Models;

#region Abstracao

// Pessoa p1 = new Pessoa()
// {
//     Nome = "Lucas",
//     Idade = 21
// };

// p1.Apresentar();

#endregion

#region Encapsulamento

// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();

#endregion

#region HerancaEPolimorfismo

// Aluno aluno = new Aluno()
// {
//     Nome = "Lucas",
//     Idade = 21,
//     Email = "email@gmail.com",
//     Nota = 10
// };

// aluno.Apresentar();

// Professor professor = new Professor()
// {
//     Nome = "Eduardo",
//     Idade = 30,
//     Salario = 1000
// };

// professor.Apresentar();

// Calculadora c = new Calculadora();
// Console.WriteLine(c.Somar(1, 2));
// Console.WriteLine(c.Somar(1, 2, 2));

#endregion

#region ClasseAbstrata

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

#endregion

#region ConstrutorPorHeranca

Aluno a1 = new Aluno("Lucas");
Professor p1 = new Professor("Eduardo");
a1.Apresentar();
p1.Apresentar();
Aluno a2 = new Aluno();

#endregion