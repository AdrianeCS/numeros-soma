int primeiroNumero, segundoNumero, soma;
Console.WriteLine("soma de dois numeros");
Console.Write ("digite o primeiro Numero: ");
primeiroNumero= Convert.ToInt32 (Console.ReadLine());
 
Console.Write ("digite o segundo Numero: ");
segundoNumero= Convert.ToInt32 (Console.ReadLine());

 soma = primeiroNumero + segundoNumero; 

Console.WriteLine($"\nSoma: {soma}");