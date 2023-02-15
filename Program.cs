double Lado1,Lado2,Lado3;

Console.WriteLine("Digite o valor do 1° lado;");
Lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do 2° lado;");
Lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do 3° lado;");
Lado3 = double.Parse(Console.ReadLine());

if(Lado1 + Lado2 > Lado3 || Lado3 + Lado2 > Lado1 || Lado3 + Lado1 > Lado2){
    Console.WriteLine("As medidas informadas formam um triângulo!");
}else{
    Console.WriteLine("As medidas informadas não formam um triângulo!");
    return;
}

if (Lado1 == Lado2 && Lado2 == Lado3 && Lado1==Lado3){
    Console.WriteLine("O triângulo é Equilátero");
}

if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1==Lado3){
    Console.WriteLine("O triângulo é Isósceles");
}

if (Lado1 != Lado2 && Lado2 != Lado3 && Lado1 != Lado3){
    Console.WriteLine("O triângulo é Escaleno");
}