namespace AtividadePOO
{
    public class Funcionario
    {
        decimal SalarioBase = 4000;
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; private set; }

        public void AumentarSalario(decimal percentual)
        {
            if (percentual < 0)
            {
                throw new ArgumentException("O percentual de aumento não pode ser negativo.");
            }
            Salario += SalarioBase * (percentual / 100 + 1);
        }
        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário atual de {Nome} ({Cargo}): R$ {Salario:F2}");
        }
    }
}