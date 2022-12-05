namespace oopApp;

public class items
{
    public string? name;
    public string? description;
}
    public class dictionary 

    {
    Dictionary<string, items> People = new Dictionary<string, items>();
        public void getDictionary()
        {
        People.Add("First",new items (){name = "Jessica", description = "tall beautiful lady" });
        People.Add("Second", new items() { name = "Egodimma", description = "tall dark beautiful lady" });
        People.Add("Third", new items() { name = "Daniella", description = "Average height black lady" });
        People.Add("Fourth", new items() { name = "Rose", description = "tall slim beautiful lady" });

        items first = People["Fourth"];
        Console.WriteLine(first.name);
        Console.WriteLine(first.description);

    }
    }

