namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria { get; set; }
        
        
        public Smartphone(string numero, string modelo)
        {
            Numero = numero;
            Modelo = modelo;
            CriarIMEI();
            Memoria = 30;
        }

        private void CriarIMEI()
        {
            int numeroImei = new Random().Next(0, 500000);
            IMEI = numeroImei.ToString();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}