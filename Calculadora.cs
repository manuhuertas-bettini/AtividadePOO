namespace AtividadePOO
{
    public class Calculadora
    {
        public void Somar(decimal a, decimal b)
        {
            Console.WriteLine($"Soma: {a + b}");
        }
        public void Subtrair(decimal a, decimal b)
        {
            Console.WriteLine($"Subtração: {a - b}");
        }
        public void Multiplicar(decimal a, decimal b)
        {
            Console.WriteLine($"Multiplicação: {a * b}");
        }
        public static void Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            Console.WriteLine($"Divisão: {(a/b):F2}");
        }
    }
}