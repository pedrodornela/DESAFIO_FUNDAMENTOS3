using DESAFIO_FUNDAMENTOS3.Models;


Console.WriteLine("Smartphone IPHONE: ");
Smartphone iphone = new Iphone(numero: "(88) 3435-4234", modelo: "Modelo NK1", imei: "652314897", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine();

Console.WriteLine("Smartphone NOKIA: ");
Smartphone nokia = new Nokia(numero: "(63) 2657-3527", modelo: "MODELO I2024", imei: "253698417", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");