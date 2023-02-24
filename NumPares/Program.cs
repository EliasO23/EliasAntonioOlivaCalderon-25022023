// See https://aka.ms/new-console-template for more information

Console.WriteLine(" ");
Console.WriteLine("BIENVENIDO ING AL BUSCADOR DE NUMEROS PARES");
Console.WriteLine("----- Segun el intervalo determinado -----");
Console.WriteLine(" ");

Console.WriteLine("Escribe el valor inicial del intervalo:");
int ValorI = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Escribe el valor final del intervalo:");
int ValorF = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine($"Los numeros pares del intervalo de {ValorI} a {ValorF} son:");
for (int i = ValorI; i<=ValorF; i++){
    if (i % 2 == 0){
         Console.WriteLine(i);
    }
}
Console.WriteLine(" ");

    
    


