using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Celular iphone = new Celular();
            iphone.modelo = "11";
            iphone.tamanho = 20f;
            iphone.ligado = true;

            if(iphone.ligado){
                Console.WriteLine(iphone.FazerLigacao() );
                Console.WriteLine(iphone.EnviarMensagem() );

            }else{
                Console.WriteLine("O celular está desligando!");
            }

        }
    }
}
