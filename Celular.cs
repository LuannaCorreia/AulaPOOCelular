namespace CelularPOO
{
    public class Celular
    {
        //Atributos
        public string cor;

        public string modelo;

        public float tamanho;
        
        public bool ligado;

        //Métodos
            public string Ligar(){
            ligado = true;
            return "Celular ligando";
        }    

        public string Desligar(){
            ligado = false;
            return "Celular desligando";
        }

        public string FazerLigacao(){
            return "Fazendo ligação";
        }

        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

        }

    }