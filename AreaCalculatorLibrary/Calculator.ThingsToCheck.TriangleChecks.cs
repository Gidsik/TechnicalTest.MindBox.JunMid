using AreaCalculatorLibrary.Shapes;

namespace AreaCalculatorLibrary
{
	public partial class Calculator
	{
		public partial class ThingsToCheck
		{
			/// <summary>
			/// Contains triangle shape related checks
			/// </summary>
			public class TriangleChecks
			{
				/// <summary>
				/// Check if triangle is right-angled using three sides, right-angleness calculates with precision of 5
				/// </summary>
				/// <returns><see langword="true"/> - if Triangle is right-angled</returns>
				public bool IsRightAngled(double side1, double side2, double side3) => (new Triangle(side1, side2, side3)).IsRightAngled;

				/// <summary>
				/// Check if given triangle is right-angled, right-angleness calculates with precision of 5
				/// </summary>
				/// <param name="triangle">existing instance</param>
				/// <returns><see langword="true"/> - if Triangle is right-angled</returns>
				public bool IsRightAngled(Triangle triangle) => (triangle).IsRightAngled;

			}
		}

	}
}