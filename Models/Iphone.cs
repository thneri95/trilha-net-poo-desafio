namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory)
            : base(number, model, imei, memory)
        {
        }

        public override void InstallApplication(string appName)
        {
            Console.WriteLine($"Installing the application \"{appName}\" on your iPhone");
        }
    }
}