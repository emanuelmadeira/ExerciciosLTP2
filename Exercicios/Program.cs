// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;


int opçao;
do
{
    Console.WriteLine("\n ===== Menu Principal ===== \n");
    Console.WriteLine("0 - encerrar o programa");
    Console.WriteLine("1 - Somar 2 números");
    Console.WriteLine("2 - transformar metros em milimetros");
    Console.WriteLine("3 - calcular o aumento");
    Console.WriteLine("4 - calcular o desconto");
    Console.WriteLine("5 - calcular o aluguel do carro");
    Console.WriteLine("6 - calcular o IMC");
    Console.WriteLine("7 - calcular o tabuada");
    Console.WriteLine("8 - Multiplos de 3");
    Console.WriteLine("9 - Calcular Fatorial");
    Console.WriteLine("10 - Calcular o imposto de renda");
    Console.WriteLine("11 - Adivinhar um numero ");
    Console.WriteLine("12 - Financiamento");
    Console.WriteLine("13 - Aposentadoria");
    Console.WriteLine("DIgite Sua opção: ");
    string entrada = Console.ReadLine();
    opçao = int.Parse(entrada);


    switch (opçao)
    {
        case 0:
            Console.WriteLine("Encerrando o programa");
            return;
        case 1:
            some();
            break;

        case 2:
            metromn();
            break;

        case 3:
            aumento();
            break;

        case 4:
            desconto();
            break;
        case 5:
            aluguel(); 
            break;
        case 6:
            imc();
            break;
        case 7:
            tabuada();
            break;
        case 8:
            multiplos3();
            break;
        case 9:
            fatorial();
            break;
        case 10:
            impostorenda();
            break;
        case 11:
            adivinhar();
            break;
        case 12:
            financiamento();
            break;
        case 13:
            aposentadoria();
            break;
      

    }

} while (opçao != 0);

aposentadoria();
financiamento();
aumento();
some();
metromn();
desconto();
imc();
impostorenda();
aluguel();
fatorial();
tabuada();
multiplos3();
adivinhar();






void adivinhar()
{
    int tentativas = 0;
    int num = 0;
    Random r = new Random();
    int a = r.Next(0, 100);
    while (true)
    {
        tentativas ++;
        



        Console.WriteLine("Advinha o numero!");
        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch { Console.WriteLine("Eu disse número."); }
        if (num < a) { Console.WriteLine("Maior..."); }
        else if (num > a) { Console.WriteLine("Menor..."); }
        if (tentativas >= 10)
        {
            Console.WriteLine("Voce errou");
            Console.WriteLine("O numero era " + a);
            break;
           
        }
        if (num == a)
        {
            Console.WriteLine("Acertou!");
            Console.WriteLine("\nDepois de {0} tentativas.", tentativas);

            break;

        }
        

    }
}
void multiplos3()
{
    float[] multiplosde3 = new float[101];
    multiplosde3[0] = 3;
    for (int i = 1; i < multiplosde3.Length; i++)
    {
        multiplosde3[i] = i + 1 ;
        if(i % 3 == 0 )
        {
            Console.WriteLine("É  multiplo de 3 " + i);
        }
        
    }
    Console.WriteLine("Esses são os multiplos de 3");
}
void financiamento ()
{

    Console.WriteLine("Informe o valor do veiculo");
    double valorVeiculo = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o numero de parcelas");
    double NumeroParcelas = double.Parse(Console.ReadLine());
    double taxamensal = 0.0193;
    double juros = valorVeiculo * taxamensal * NumeroParcelas;
    double taxaadministrativa = 0.0001;
    double jurosadminstrativos = taxaadministrativa * valorVeiculo;
    for (int i = 0; i <= NumeroParcelas; i++)
    {
        juros *= 1 + taxamensal;
        jurosadminstrativos *= 1 + taxaadministrativa;
    }

    double dinheiro = valorVeiculo + juros + jurosadminstrativos;
    double valorsemjuros = dinheiro - jurosadminstrativos - juros;
    Console.WriteLine("Valor sem juros :" + valorsemjuros);
    Console.WriteLine("Valor do Veiculo Total igual a :" + dinheiro);

}

void tabuada()
{
    int form, cont, num;


    Console.Write("Digite o Numero para Obter a Taboada : ");
    num = int.Parse(Console.ReadLine());

   
    for (cont = 1; cont <= 10; ++cont)
    {
        form = num * cont;
        Console.WriteLine(num + " X " + cont + " = " + form);

    }
}
void some()
{
     

    Console.WriteLine("Informe num 1 ");
    byte num1 = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe num 2 ");
    byte num2 = byte.Parse(Console.ReadLine());
    byte soma = (byte)(num1 + num2);
    Console.WriteLine("A soma deu" +  soma);
   
}
void metromn()
{

    Console.WriteLine("Informe o valor em metro ");
    float metro = float.Parse(Console.ReadLine());
    Console.WriteLine("O valor informado em  metro foi : " + metro);
     double milimetros = metro * 1000;
    Console.WriteLine($"Valor informado em milimetros foi " + milimetros);

}
void desconto()
{
    Console.WriteLine("Informe o valor ");
    float real = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a porcentagem do desconto");
    float desconto = float.Parse(Console.ReadLine());
    float valorcomdesconto = real - (real * desconto) / 100;
    Console.WriteLine("Valor com desconto igual a " +  valorcomdesconto);
    Console.WriteLine("Valor sem desconto " + real);
    Console.WriteLine("Desconto foi de " + desconto + "%");
}
void imc()
{
    Console.WriteLine("Informe a altura em metros : ");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe o peso em kg : ");
    float peso = float.Parse(Console.ReadLine());
    float imc = peso / (altura * altura);
    Console.WriteLine("Imc igual:" + imc);
    if (imc < 18.5)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc <=24.9)
    {
        Console.WriteLine("Peso ideal");
    }
    else if (imc <= 29.9)
    {
        Console.WriteLine("Levemente acima do peso");
    }
    else if (imc <= 34.9 )
    {
        Console.WriteLine("Obesidade grau 1");
    }
    else if(imc <= 39.9)
    {
        Console.WriteLine("Obesidade grau 2");
    }
    else if (imc >= 40)
    {
        Console.WriteLine("Obesidade morbida");
    }
}
void impostorenda()
{
    Console.WriteLine("Informe seu salario");
    double salarioBruto = double.Parse(Console.ReadLine());
    if (salarioBruto < 1903.93)
    {
        Console.WriteLine("Não recebe desconto");
    }
    else if (salarioBruto <= 2826.65)
    { 
        double porcentagemdesconto = 7.5 / 100;
       double Salariocomdesconto = salarioBruto - (salarioBruto *porcentagemdesconto);
        Console.WriteLine("Salario com desconto igual a R$" + Salariocomdesconto);
        double valorapagar = salarioBruto * porcentagemdesconto;
        Console.WriteLine("Valor a Pagar é de R$" + valorapagar);
    }
    else if (salarioBruto <= 3751.05)
    {
        double porcentagemdedesconto = 15.0 / 100;
        double salariocomdesconto = salarioBruto-(salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a R$" + salariocomdesconto);
        double valorapagar = salarioBruto * porcentagemdedesconto;
        Console.WriteLine("Valor a Pagar é de R$" + valorapagar);
    }
    else if (salarioBruto <= 4664.68)
    {
        double porcentagemdedesconto = 22.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a R$" + salariocomdesconto);
        double valorapagar = salarioBruto * porcentagemdedesconto;
        Console.WriteLine("Valor a Pagar é de R$" + valorapagar);
    }
    else if (salarioBruto > 4664.68)
    {
        double porcentagemdedesconto = 27.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
        double valorapagar = salarioBruto * porcentagemdedesconto;
        Console.WriteLine("Valor a Pagar é de R$" + valorapagar);
    }
}
void aluguel()
{
    Console.WriteLine("Informe o numero de dias ");
    byte numerosdedias = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro inicial");
    byte quilometroinicial = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro Final");
    byte quilometrofinal= byte.Parse(Console.ReadLine());
    
    int valorpordia = (int)(numerosdedias * 95);
    double valorporquilometro = (double)(quilometrofinal - quilometroinicial) * 0.35;
   double valortotal = (double)(valorporquilometro + valorpordia);
    Console.WriteLine("Valor a ser pago é :" + valortotal);

}
void fatorial()
{

    float[] fatorial = new float[11];
    fatorial[0] = 1;

    for (int i = 1; i < fatorial.Length; i++)
    {
        fatorial[i] = fatorial[i - 1] * i;
        Console.WriteLine($"O fatorial de: {i} é: {fatorial[i]}");
    }
}
void aumento ()
{
    Console.WriteLine("Informe o salario ");
    double salario = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe percentual de aumento");
    double porcentagemdeaumento = double.Parse(Console.ReadLine())/100;
    double percentualaumento = (double)(salario * porcentagemdeaumento);
    Console.WriteLine("Percentual de aumento é " + percentualaumento);
    double novosalario = (double)(salario + percentualaumento);
    Console.WriteLine("Valor do novo salario é " + novosalario);
    Console.WriteLine("Salario inicial é " + salario);

}
void aposentadoria()
{
    Console.WriteLine("Informe a sua idade");
    double idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a idade que quer se aposentar");
    double idadefinal = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor para aposentadoria");
    double valoraposentadoria = double.Parse(Console.ReadLine());
    double taxarendimento = 0.01;
    double anosrendimento = (idadefinal - idade) * 12;
    double juros = (valoraposentadoria * taxarendimento) * anosrendimento;
    double juroscompostos = valoraposentadoria + juros;

    for (int i = 0; i < anosrendimento; i++)
    {
        juros *= 1 + taxarendimento;

    }
    double montante = valoraposentadoria + juros;
    double dinheiroliquido = valoraposentadoria + juros;
    double salarioliquido = dinheiroliquido * taxarendimento;
    Console.WriteLine("Juros compostos igual a " + juroscompostos);
    Console.WriteLine("Montante igua a " + montante);
    Console.WriteLine("Juros igual a " + juros);
    Console.WriteLine($"Salario liquido igual a {salarioliquido}");
    Console.WriteLine("valor para aposentadoria " + dinheiroliquido);
}
    

