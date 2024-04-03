namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone 
    {
        public Iphone(string numero, string modelo) : base(numero, modelo){}

        public override void InstalarAplicativo(string nomeApp)
        {
           System.Console.WriteLine($"Instalando aplicavo Iphone - {nomeApp} ...");
        }
    }
}