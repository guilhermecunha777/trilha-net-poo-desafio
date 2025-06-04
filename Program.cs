using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Prgram
{
    static void Main()
    {
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("whatsApp");

        Smartphone iphone = new Iphone("987654321", "iPhone 13", "222222222222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("instagram");
    }
}