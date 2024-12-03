using DesafioPOO.Models;

Iphone iphone = new Iphone("123456","15","11111", 5 );

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsApp");

Console.WriteLine("\n");

Nokia nokia = new Nokia("987456321","3300","22222",65);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");