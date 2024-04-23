namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }

        public Professor(string nome) : base(nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar() //polimorfismo em tempo de execução override / late binding
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}