using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Shapes;
using Xunit;
using Xunit.Sdk;

namespace AreaCalculatorLibrary.Tests;

public class CalculatorTests
{
	[Fact]
	public void Calculator_Check_ReturnsThingsToCheck()
	{
		var result = Calculator.Check();

		Assert.NotNull(result);
		Assert.IsType<Calculator.ThingsToCheck>(result);
	}

	[Fact]
	public void Calculator_Check_ReturnsStaticInstance()
	{
		var calc1 = new Calculator();
		var calc2 = new Calculator();

		Calculator.ThingsToCheck result1;
		{ result1 = Calculator.Check(); }
		Calculator.ThingsToCheck result2;
		{ result2 = Calculator.Check(); }

		Assert.Same(result1, result2);
	}




	[Fact]
	public void Calculator_Calculate_ReturnsThingsToCalculate()
	{
		var result = Calculator.Calculate();

		Assert.NotNull(result);
		Assert.IsType<Calculator.ThingsToCalc>(result);
	}

	[Fact]
	public void Calculator_Calculate_ReturnsStaticInstance()
	{
		var calc1 = new Calculator();
		var calc2 = new Calculator();

		Calculator.ThingsToCalc result1;
		{ result1 = Calculator.Calculate(); }
		Calculator.ThingsToCalc result2;
		{ result2 = Calculator.Calculate(); }

		Assert.Same(result1, result2);
	}




	[Fact]
	public void ThingsToCalc_AreaOf_ReturnsShapesAreas()
	{
		Calculator.ThingsToCalc thingsToCalc = new Calculator.ThingsToCalc();

		var result = thingsToCalc.AreaOf();

		Assert.NotNull(result);
		Assert.IsType<Calculator.ThingsToCalc.ShapesAreas>(result);
	}

	[Fact]
	public void ThingsToCalc_AreaOf_ReturnsStaticInstance()
	{
		var thingsToCalc1 = Calculator.Calculate();
		var thingsToCalc2 = new Calculator.ThingsToCalc();

		Calculator.ThingsToCalc.ShapesAreas result1;
		{ result1 = thingsToCalc1.AreaOf(); }
		Calculator.ThingsToCalc.ShapesAreas result2;
		{ result2 = thingsToCalc2.AreaOf(); }

		Assert.Same(result1, result2);
	}




	[Fact]
	public void ThingsToCheck_Triangle_ReturnsTriangleChecks()
	{
		Calculator.ThingsToCheck thingsToCheck = new Calculator.ThingsToCheck();

		var result = thingsToCheck.Triangle();

		Assert.NotNull(result);
		Assert.IsType<Calculator.ThingsToCheck.TriangleChecks>(result);
	}

	[Fact]
	public void ThingsToCheck_Triangle_ReturnsStaticInstance()
	{
		var thingsToCheck1 = Calculator.Check();
		var thingsToCheck2 = new Calculator.ThingsToCheck();

		Calculator.ThingsToCheck.TriangleChecks result1;
		{ result1 = thingsToCheck1.Triangle(); }
		Calculator.ThingsToCheck.TriangleChecks result2;
		{ result2 = thingsToCheck2.Triangle(); }

		Assert.Same(result1, result2);
	}




	[Fact]
	public void ShapesAreas_Triangle_OverloadsReturnsEqual()
	{
		Calculator.ThingsToCalc.ShapesAreas shapesAreas = new Calculator.ThingsToCalc.ShapesAreas();
		Triangle triangle = new Triangle(1, 1, 1);


		var result1 = shapesAreas.Triangle(1, 1, 1);
		var result2 = shapesAreas.Triangle(triangle);


		Assert.Equal<Double>(result1, result2);
	}
	
	[Fact]
	public void ShapesAreas_Circle_OverloadsReturnsEqual()
	{
		Calculator.ThingsToCalc.ShapesAreas shapesAreas = new Calculator.ThingsToCalc.ShapesAreas();
		Circle circle = new Circle(1);


		var result1 = shapesAreas.Circle(1);
		var result2 = shapesAreas.Circle(circle);


		Assert.Equal<Double>(result1, result2);
	}
	
	[Fact]
	public void ShapesAreas_Shape_ReturnsAsConcreteCircle()
	{
		Calculator.ThingsToCalc.ShapesAreas shapesAreas = new Calculator.ThingsToCalc.ShapesAreas();
		Circle circle = new Circle(1);


		var result1 = shapesAreas.Shape(circle);
		var result2 = circle.GetArea();


		Assert.Equal<Double>(result1, result2);
	}
	
	[Fact]
	public void ShapesAreas_Shape_ReturnsAsConcreteTriangle()
	{
		Calculator.ThingsToCalc.ShapesAreas shapesAreas = new Calculator.ThingsToCalc.ShapesAreas();
		Triangle triangle = new Triangle(1, 1, 1);


		var result1 = shapesAreas.Shape(triangle);
		var result2 = triangle.GetArea();


		Assert.Equal<Double>(result1, result2);
	}
}