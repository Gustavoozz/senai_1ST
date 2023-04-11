﻿
int homens = 0;
int mulheres = 0;
int idadeHomens = 0;
int idadeMulheres = 0;

for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine($"Digite o sexo do usúario: H/M ");
    string sexo = (Console.ReadLine()!.ToUpper());
    
    while (sexo != "H" && sexo != "M")
    {
        Console.WriteLine($"Informação inválida. Informe o sexo do usúario novamente: H/M");
        sexo = (Console.ReadLine()!.ToUpper());
    }

    Console.WriteLine($"Digite a idade do usúario: ");
    int idade = int.Parse(Console.ReadLine()!);
    while (idade < 0)
    {
        Console.WriteLine($"Informação inválida. Informe a idade do usúario novamente: ");
        idade = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine($"Digite o peso do usúario: ");
    int peso = int.Parse(Console.ReadLine()!);
    while(peso < 0)
    {
        Console.WriteLine($"Informação inválida. Informe o peso do usúario novamente: ");
        peso = int.Parse(Console.ReadLine()!);
    }

    if (sexo == "H")
    {
        homens++;
        idadeHomens += idade;
    }
    else
    {
        mulheres++;
        idadeMulheres += idade;
    }
}

Console.WriteLine($"O total de homens é: {homens}");
Console.WriteLine($"O total de mulheres é: {mulheres}");
if(homens == 0)
{
    Console.WriteLine($"A média de idade dos homens é: 0");
}
else
{
    Console.WriteLine($"A média de idade dos homens é: {idadeHomens/homens}");
}

if(mulheres == 0)
{
    Console.WriteLine($"A média de idade das mulheres é: 0");
}
else
{
    Console.WriteLine($"A média de idade das mulheres é: {idadeMulheres/mulheres}");
}