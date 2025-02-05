using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "12345678", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
//nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone (numero: "87654321", modelo: "Modelo 2", imei: "22222222", memoria: 128);
//iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");