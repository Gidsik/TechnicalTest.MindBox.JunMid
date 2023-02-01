using AreaCalculatorLibrary.Shapes;

namespace AreaCalculatorLibrary.Tests.ShapesTests;

public class CircleTests
{
	[Fact]
	public void Circle_Initializers_ThrowsOnBadRadius()
	{
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			Circle circle = new Circle(-10);
		});

		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			Circle circle = new Circle(0);
		});
	}

	[Fact]
	public void Circle_GetArea_ReturnsDouble()
	{
		Circle circle = new Circle(1);

		var result = circle.GetArea();

		Assert.IsType<double>(result);
	}

	[Theory]
	[InlineData(1, 3.1415926535)]
	[InlineData(0.354, 0.3936918249)]
	[InlineData(2256.1, 15990666.4258020081)]
	[InlineData(22222222222, 1551403779519487103896.8699643289)]
	public void Circle_GetArea_ReturnsActualArea(double radius, double expected)
	{
		Circle circle = new Circle(radius);

		var result = circle.GetArea();

		Assert.Equal(expected, result, 5);
	}


	[Theory]
	[InlineData(1)]
	[InlineData(0.354)]
	public void Circle_Radius_SameAsGiven(double radius)
	{
		Circle circle = new Circle(radius);

		var result = circle.Radius;

		Assert.Equal(result, radius);
	}
}