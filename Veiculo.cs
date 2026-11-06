namespace AtividadePOO
{
    public class Veiculo
    {
      public int velocidade { get; set; }
      public void AlterarVelocidade(int novaVelocidade)
      {
        if (velocidade > 0 && velocidade <= 200)
        {
            velocidade = novaVelocidade;
        }
        else
        {
            throw new ArgumentException("A velocidade não pode ser negativa.");
        }
      }
    }
}