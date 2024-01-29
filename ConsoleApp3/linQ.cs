var names = new List<string>() ///Origen
{
    "Hector", "Francisco" , "Ana", "hugo", "Pedro"
};

var namesResult = from n in names///Consulta esta es la forma de consulta con LinQ
                  where n.Length > 5 &&  n.Length < 8
                  orderby n descending
                  select n;

var namesResult2 = names.Where(n => n.Length > 3 && n.Length < 8).OrderByDescending(n => n).Select(n=>n);/// consulta en forma de funcion

foreach (var name in namesResult) ///ejecuicon
{ 
    Console.WriteLine(name);

}
/// .ToList() para ejecutra la consulta en el momento de la consula y saltarce el bloque de ejecucion
