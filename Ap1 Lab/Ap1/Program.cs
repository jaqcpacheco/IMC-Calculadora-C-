string resultado;
string faixaEtaria;
int opcao = 1;
do{
    // Dados da pessoa
    Console.WriteLine("Olá, seja bem vindo(a) a calculadora de IMC!");
    Console.WriteLine("Digite seu nome: ");
    string? nome = Console.ReadLine();

    
    int idade;
    while (true) //loop while para que o usuário seja informado se colocar uma idade inválida
    {
        Console.WriteLine("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 0)
        {
            Console.WriteLine("Idade digitada inválida! Digite uma idade válida:");
            continue; 
        }
        break;
    }

    Console.WriteLine("Digite sua altura: (exemplo: 1,70) ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite seu peso: (exemplo: 60,1)");
    double peso = Convert.ToDouble(Console.ReadLine());

    // Cálculo do IMC

    double imc =  peso / (altura * altura);

    if (imc <= 18.5){
        resultado = "Abaixo do peso";
    }

    else if (imc <= 24.9){
        resultado = "Peso normal";
    }

    else if (imc <= 29.9){
        resultado = "Sobrepeso";
    }

    else resultado = "Obeso";

    //If e else para determinar a faixa etaria

    if (idade < 0)
    {
        faixaEtaria = "Idade fora das faixas consideradas";
    }
    else if (idade < 10)
    {
        faixaEtaria = "Criança";
    }
    else if (idade < 20)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade < 60)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    // relatorio do cálculo de IMC 
    Console.WriteLine("Relatório do cálculo de IMC");

    Console.WriteLine($"\n Nome: {nome} \n Idade: {idade} \n Faixa Etária: {faixaEtaria} \n Peso: {peso}");
    Console.WriteLine(" Altura: " + altura);
    Console.WriteLine($"\n Com base nas informações digitadas, seu IMC é {imc.ToString("F1")} resultado : {resultado}");

    Console.WriteLine("Você deseja gerar outro cálculo de IMC? Digite \"1\" para continuar e \"2\" para encerrar.");
    opcao = Convert.ToInt32(Console.ReadLine());

}
while (opcao == 1);


Console.WriteLine("\n Obrigada por usar nossa calculadora, os resultados aqui descritos são apenas valores para consulta. Procure seu médico e peça uma avaliação de saúde.Obrigada! .");