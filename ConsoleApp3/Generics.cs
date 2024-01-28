/// GENERIC
var numbers = new MyList<int>(5);
var beers = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

beers.Add(new Beer()
{
    Name= "Heiniken",
    Price= 40
});

beers.Add(new Beer()
{
    Name = "Corona",
    Price = 15
});

beers.Add(new Beer()
{
    Name = "Cristal",
    Price = 10
});

beers.Add(new Beer()
{
    Name = "Coca",
    Price = 30
});





Console.WriteLine(numbers.GetContent());
Console.WriteLine(beers.GetContent());
public class MyList<T>
{ 
    private List<T> _list;
    private int _limit;

    public MyList(int limit) {
        _limit = limit;
        _list = new List<T>();

    }

    public void Add(T element) { 
        if (_list.Count < _limit) {
            _list.Add(element);
        }
    }
    public string GetContent() {

        string content = "";
        foreach(var element in _list) {
            content += element + ", ";
        }
        return content;
    }
}
public class Beer
{ 
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()/// para poder cambiar lo que salga cuando se obtenga el content 
    {
        return "Nombre: " + Name + " Precio: " + Price;
    }
}
