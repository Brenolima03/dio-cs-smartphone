namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number {get; set;}
        public string Model {get; private init;}
        public string IMEI {get; private init;}
        public int Memory {get; private init;}

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void Call()
        {
            Console.WriteLine($"{Model} is calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine($"{Model} is receiving a call...");
        }

        public abstract void InstallApp(string appName);
    }
}
