using AreaCalculatorLibrary.Shapes;

namespace AreaCalculatorLibrary
{
	public partial class Calculator
	{
		public partial class ThingsToCalc
		{
			/// <summary>
			/// Contains methods to get areas of different shapes
			/// </summary>
			public class ShapesAreas
			{
				public double Triangle(double side1, double side2, double side3) => (new Triangle(side1, side2, side3)).GetArea();
				public double Triangle(Triangle triangle) => (triangle).GetArea();

				public double Circle(double radius) => (new Circle(radius)).GetArea();
				public double Circle(Circle circle) => (circle).GetArea();

				public double Shape(IShapeWithArea shape) => (shape).GetArea();

			}
		}

	}
}