///serializacion
using System.Text.Json;
var Ivan = new People()
{
    Name = "Ivan",
    Age = 20,
};

String json = JsonSerializer.Serialize(Ivan);

Console.WriteLine(json);

string myJson = @"{
    ""Name"": ""Juan"",
    ""Age"":21
}";

People juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan.Name);
Console.WriteLine(juan.Age);


public class People
{ 
    public string Name {  get; set; }
    public int Age { get; set; }
}
