namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(
            string number, string model, string imei, int memory
        ) : base(number, model, imei, memory) {}

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"{Model} installing {appName} via Nokia Store");
        }
    }
}
