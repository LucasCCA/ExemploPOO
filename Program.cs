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

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

#endregion
