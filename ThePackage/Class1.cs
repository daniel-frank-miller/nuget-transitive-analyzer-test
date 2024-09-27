using Riok.Mapperly.Abstractions;

namespace ThePackage;

public class Class1
{

}

public record Foo1(
	int X,
	int Y
);
public record Foo2(
	int X,
	int Y
);

[Mapper]
public static partial class Mappers
{
	public static partial Foo1 ToFoo1(this Foo2 foo2);
}
