namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero) : base(numero,"Modelo Iphone", "123456789", 16)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string iosapp)
        {
            Console.WriteLine(iosapp);
        }
    }
}