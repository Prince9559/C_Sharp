using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Currency c = new Currency(20,40);
Console.WriteLine("Constractor Answer : "+c);


Currency c1 = new Currency();
Console.WriteLine("Method Answer : " + c1);

Console.WriteLine("Plus : "+(c1 + c1));


Console.WriteLine("Minus : " + (c1 - c1));

Console.WriteLine("LessThen : " + (c1 < c1));

Console.WriteLine("GreaterThen : "+(c1>c1));

Console.WriteLine("Equal : " + (c1 == c1));

Console.WriteLine("Not_Equal : " + (c1 != c1));