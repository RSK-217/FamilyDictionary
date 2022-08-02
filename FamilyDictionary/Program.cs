Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Billy" }, { "age", "46" } });
myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Velma" }, { "age", "76" } });
myFamily.Add("father", new Dictionary<string, string>() { { "name", "William" }, { "age", "75" } });


Console.WriteLine(myFamily["sister"]);

foreach (var person in myFamily)
{
    Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]}");
}