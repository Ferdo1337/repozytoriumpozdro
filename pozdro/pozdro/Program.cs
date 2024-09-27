using pozdro;

Console.WriteLine("podaj co chcesz odciac: ");
string? data = Console.ReadLine();

Console.WriteLine("podaj indeks: ");
int index = int.Parse(Console.ReadLine());

Class1 cutData = new Class1();
string result = cutData.Zadanie1(data, index);

Console.WriteLine("Wynik: ");
Console.WriteLine(result);