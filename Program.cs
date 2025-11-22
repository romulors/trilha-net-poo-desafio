using DesafioPOO.Models;

Console.WriteLine("\nCriando Smartphone Nokia:");
Nokia nokia = new("23846587456", "Nokia G05", "456456456", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nCriando Smartphone Iphone:");
Iphone iphone = new("51999999999", "Iphone 8S", "123123123123", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");