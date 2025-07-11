namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory)
            : base(number, model, imei, memory)
        {
        }

        public override void InstallApplication(string appName)
        {
            Console.WriteLine($"Installing the application \"{appName}\" on your Nokia");
        }
    }
}