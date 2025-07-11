using DesafioPOO.Models;

Console.WriteLine("Testing Nokia Smartphone:");
Nokia nokia = new Nokia(number: "1234-5678", model: "Nokia 3310", imei: "111222333", memory: 64);
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApplication("Snake Xenzia");
Console.WriteLine($"Nokia Info - Number: {nokia.Number}, Model: {nokia.Model}, IMEI: {nokia.IMEI}, Memory: {nokia.Memory}GB\n");

Console.WriteLine("-------------------------------------------\n");

Console.WriteLine("Testing iPhone Smartphone:");
Iphone iphone = new Iphone(number: "9876-5432", model: "iPhone 15 Pro", imei: "999888777", memory: 512);
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApplication("Instagram");
iphone.InstallApplication("WhatsApp");
Console.WriteLine($"iPhone Info - Number: {iphone.Number}, Model: {iphone.Model}, IMEI: {iphone.IMEI}, Memory: {iphone.Memory}GB\n");