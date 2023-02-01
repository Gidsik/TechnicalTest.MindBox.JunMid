using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Shapes;
using Xunit;
using Xunit.Sdk;

namespace AreaCalculatorLibrary.Tests;

public class ShapesWithAreaFixture
{
	public List<IShapeWithArea> Shapes { get; private set; }

	public ShapesWithAreaFixture()
	{
		Shapes = new List<IShapeWithArea>();
		Random random = new Random();

		var dynSize = random.Next(1,100);
		for (int i = 0; i < dynSize; i++)
		{
			if (random.NextDouble() < 0.5)
			{
				Shapes.Add(new Circle(3));
			}
			else
			{
				Shapes.Add(new Triangle(3, 4, 5));
			}
		}
	}
}


public class IShapeWithAreaTests : IClassFixture<ShapesWithAreaFixture>
{
	ShapesWithAreaFixture shapesFixture;

	public IShapeWithAreaTests(ShapesWithAreaFixture shapesFixture)
	{
		this.shapesFixture = shapesFixture;
	}

	[Fact]
	public void IShapeWithArea_GetArea_AccessToAreaOfRuntimeDefinedShapesInCollection()
	{
		foreach (var shape in shapesFixture.Shapes)
		{
			Assert.IsType<double>(shape.GetArea());
		}
	}

}