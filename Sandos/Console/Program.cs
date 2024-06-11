var array = new[] {"1", "2", "3", "4", "5"};

var a = array[2];
var b = array[3];

void Swap<T>(ref T one, ref T two)
{
  (two, one) = (one, two);
}

Swap(ref a, ref b);

foreach (var i in array) 
  Console.WriteLine(i);