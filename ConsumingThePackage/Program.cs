using Riok.Mapperly.Abstractions;
using ThePackage;

var foo2 = new Foo2(1, 2);
var foo1 = foo2.ToFoo1();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public record Bar1(
	int X,
	int Y
);
public record Bar2(
	int X,
	int Y
);

[Mapper]
public static partial class MyMappers
{
	public static partial Bar2 ToBar2(this Bar1 bar1);
}
