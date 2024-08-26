using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "123456", imei: "1243", modelo: "Galaxy", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Roblox");
Console.WriteLine("\n");
Smartphone iphone = new Iphone(numero: "54623", imei: "2123", modelo: "Pocket", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");