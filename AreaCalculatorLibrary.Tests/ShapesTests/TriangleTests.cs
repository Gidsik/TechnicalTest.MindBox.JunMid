using AreaCalculatorLibrary.Shapes;

namespace AreaCalculatorLibrary.Tests.ShapesTests;

public class TriangleTests
{
	[Theory]
	[InlineData(3, 4, 0)]
	[InlineData(3, 0, 5)]
	[InlineData(0, 4, 5)]
	[InlineData(3, 4, -5)]
	[InlineData(3, -4, 5)]
	[InlineData(-3, 4, 5)]
	[InlineData(2, 1, 1)]
	[InlineData(3, 1, 1)]
	[InlineData(1, 2, 1)]
	[InlineData(1, 3, 1)]
	[InlineData(1, 1, 2)]
	[InlineData(1, 1, 3)]
	public void Triangle_Initializers_ThrowsOnBadSides(double side1, double side2, double side3)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			Triangle triangle = new Triangle(side1, side2, side3);
		});
	}

	[Fact]
	public void Triangle_GetArea_ReturnsDouble()
	{
		Triangle triangle = new Triangle(3, 4, 5);

		var result = triangle.GetArea();

		Assert.IsType<double>(result);
	}

	[Theory]
	[InlineData(1, 1, 1, 0.4330127018)]
	[InlineData(3, 4, 5, 6)]
	[InlineData(3, 3, 3, 3.897114317)]
	[InlineData(5, 5, 7.07106781, 12.5)]
	[InlineData(5, 5, 7.07106781, 12.49999999)]
	[InlineData(1, 1, 1.999999, 0.0009999993)]
	public void Triangle_GetArea_ReturnsActualArea(double side1, double side2, double side3, double expected)
	{
		Triangle triangle = new Triangle(side1, side2, side3);

		var result = triangle.GetArea();

		Assert.Equal(expected, result, 5);
	}

	[Theory]
	[InlineData(1, 1, 1)]
	[InlineData(3, 4, 5)]
	[InlineData(5, 5, 7.07106781)]
	[InlineData(1, 1, 1.999999)]
	public void Triangle_Sides_SameAsGiven(double side1, double side2, double side3)
	{
		Triangle triangle = new Triangle(side1, side2, side3);

		var result = triangle.Sides;

		Assert.Contains(side1, result);
		Assert.Contains(side2, result);
		Assert.Contains(side3, result);
	}


	[Theory]
	[InlineData(3, 4, 5)]
	[InlineData(5, 5, 7.07106781)]
	public void Triangle_IsRight_True(double side1, double side2, double side3)
	{
		Triangle triangle = new Triangle(side1, side2, side3);

		var result = triangle.IsRight;

		Assert.True(result);
	}

	[Theory]
	[InlineData(1, 1, 1)]
	[InlineData(1, 1, 1.999999)]
	public void Triangle_IsRight_False(double side1, double side2, double side3)
	{
		Triangle triangle = new Triangle(side1, side2, side3);

		var result = triangle.IsRight;

		Assert.False(result);
	}

}