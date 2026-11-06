using AtividadePOO;

//Ex. 1
Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Idade = 25;
p1.Cidade = "São Paulo";
p1.ExibirDados();

Pessoa p2 = new Pessoa();
p2.Nome = "Maria";
p2.Idade = 30;
p2.Cidade = "Rio de Janeiro";
p2.ExibirDados();

//Ex. 2
Calculadora calc = new Calculadora();
calc.Somar(10, 5);
calc.Subtrair(10, 5);
calc.Multiplicar(10, 5);
Calculadora.Dividir(10, 5);

//Ex. 3
Veiculo veiculo = new Veiculo();
veiculo.AlterarVelocidade(100);


//Ex. 4
Funcionario funcionario = new Funcionario
{
    Nome = "Carlos",
    Cargo = "Desenvolvedor",
};
funcionario.AumentarSalario(10);
funcionario.ConsultarSalario();

//Ex. 5
Livro l1 = new Livro();
l1.ExibirDadosLivro();

Livro l2 = new Livro("O Senhor dos Anéis");
l2.ExibirDadosLivro();

Livro l3 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkin");
l3.ExibirDadosLivro();

Livro l4 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkin", 1000);
l4.ExibirDadosLivro();