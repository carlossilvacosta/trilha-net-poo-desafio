using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
string numero01 = "123456";
string modelo01 = "Modelo 1";
string imei01 = "123456789";
int memoria01 = 64;
Smartphone nokia = new Nokia(numero01,modelo01,imei01,memoria01);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Smartphone Iphone: ");
string numero02 = "987456";
string modelo02 = "Modelo 9";
string imei02 = "987654321";
int memoria02 = 128;
Smartphone iphone = new Iphone(numero02,modelo02,imei02,memoria02);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
