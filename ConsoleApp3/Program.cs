


var sale = new SaleWithTax(15, 1.20m);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWithTax : Sale /// para utilizar herancia se utiliza : y la clase que se quiere heredar 
{
    public decimal Tax { get; set; } /// no se puede declarar solo set 
    public SaleWithTax(decimal total, decimal tax): base(total) /// para declarar la herencia en el constructor
    {
        Tax = tax;
    }
    public override string GetInfo()/// override se utiliza para sobre escribir el metodo 
    {
        return "El total es: " + Total + " El impuesto es : " + Tax;

    }

    public string GetInfo(string message)///sobre carga 
    {
        return message;
    }
}

class Sale
{
    public decimal Total { get; set; }
    private decimal _some ; /// si se declara como privado no se puede acceder fuera de la clase el _ es igual que en python indica que es privado
    
    public Sale(decimal total)
    {
        Total = total;
        _some = 8;
    }

    public virtual string GetInfo()/// virtual es para indicar que este metodo puede ser sobreescrito 
    {
        return "El total es " + Total;
    }
}