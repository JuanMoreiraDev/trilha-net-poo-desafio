namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

   public Nokia(string numero) : base(numero,"Modelo Nokia", "123456789", 16)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string Instalando){
             Console.WriteLine(Instalando);
        }
    }
}