using DesafioPOO.Models;

Nokia nokia = new Nokia("11111111111", "N1", "IMEINOKIA", 16);
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApp("WhatsApp");

Iphone iphone = new("22222222222", "I1", "IMEIIPHONE", 16);
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApp("Facebook");

Console.WriteLine("\nBefore change");

Console.WriteLine(nokia.Number);
Console.WriteLine(iphone.Number);

Console.WriteLine("\nAfter change");

nokia.Number = "33333333333";
iphone.Number = "44444444444";
Console.WriteLine(nokia.Number);
Console.WriteLine(iphone.Number);

// This will fail because this attribute is init-only
// nokia.Model = "N2";
// iphone.Model = "I2";
// Console.WriteLine(nokia.Model);
// Console.WriteLine(iphone.Model);