using Celular.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "999999", modelo: "Modelo G10", imei: "15154848", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine();

Console.WriteLine("IPhone:");
Smartphone iphone = new Iphone(numero: "87878787", modelo: "Modelo MC40", imei: "211649451", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Jogo da Velha");


