using ReflectionApp;

Console.WriteLine("Reflection application");


var f = new F();
f = f.Get();

var serializator = new Serializator();
string s = serializator.Serialize(f);
var ff = serializator.DeSerialize(s);



Console.ReadLine();
