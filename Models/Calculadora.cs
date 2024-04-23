namespace ExemploPOO.Models
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3) //polimorfismo em tempo de compilação (overload / early binding)
        {
            return num1 + num2 + num3;
        }
    }
}