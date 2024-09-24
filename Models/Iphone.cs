namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(
            string number, string model, string imei, int memory
        ) : base(number, model, imei, memory) {}

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"{Model} installing {appName} via Apple Store");
        }
    }
}
