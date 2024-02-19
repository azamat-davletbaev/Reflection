using ReflectionApp;

Console.WriteLine("Домашнее задание по рефлексии: Reflection application");
Console.WriteLine("-----------------------------------------------------");
var timer = new MyTimer();

Console.WriteLine($"Сериализация/десерилазация класса F кастомным методом {timer.Count} раз = {timer.GetSerializatorTime()} миллисекунд");
Console.WriteLine($"Сериализация/десерилазация класса F методами Newtonsoft.Json 13.0.3 {timer.Count} раз = {timer.GetJsonSerilizeTime()} миллисекунд");
Console.WriteLine("-----------------------------------------------------");

Console.ReadLine();
