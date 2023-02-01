using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary.Shapes;

public class Triangle : IShapeWithArea
{
	private double _area;

	/// <summary>
	/// True - if Triangle is right-angled, right-angleness calculates with precision of 5
	/// </summary>
	public readonly bool IsRightAngled;

	/// <summary>
	/// Given sides sizes of a triangle, sorted descending 
	/// </summary>
	public double[] Sides { get; private set; }

	/// <summary>
	/// Represents Triangle by three sides
	/// </summary>
	/// <param name="side1"></param>
	/// <param name="side2"></param>
	/// <param name="side3"></param>
	public Triangle(double side1, double side2, double side3)
	{
		if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1), side1, "Sides can't be less or equal to zero");
		if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2), side2, "Sides can't be less or equal to zero");
		if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3), side3, "Sides can't be less or equal to zero");

		Sides = new double[3] {side1, side2, side3};

		Array.Sort(Sides, (x,y) => y.CompareTo(x));

		if (Sides[0] >= Sides[1] + Sides[2]) throw new ArgumentOutOfRangeException(nameof(Sides), Sides, "Biggest side of triangle must be always lesser than the sum of two lesser sides");

		IsRightAngled = CheckIfRightAngled();

		if (IsRightAngled) {
			_area = CalculateAreaByTwoSides();
		}
		else
		{
			_area = CalculateAreaByThreeSides();
		}
	}

	public double GetArea() => _area;


	//private void SortSidesBySize()
	//{
	//	double lesser1, lesser2;
	//	double bigger;
	//	double temp;

	//	bigger = _side1;
	//	lesser1 = _side2;
	//	lesser2 = _side3;

	//	if (lesser1 > bigger)
	//	{
	//		temp = bigger;
	//		bigger = lesser1;
	//		lesser1 = temp;
	//	}
	//	if (lesser2 > bigger)
	//	{
	//		temp = bigger;
	//		bigger = lesser2;
	//		lesser2 = temp;
	//	}
	//	if (lesser2 > lesser1)
	//	{
	//		temp = lesser2;
	//		lesser2 = lesser1;
	//		lesser1 = temp;
	//	}

	//	_side1 = bigger;
	//	_side2 = lesser1;
	//	_side3 = lesser2;
	//}


	private bool CheckIfRightAngled() => Math.Abs(Math.Pow(Sides[0], 2) - (Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2))) < 0.00001;

	private double CalculateAreaByThreeSides()
	{
		double semiPerimeter = Sides.Sum() / 2;

		return Math.Sqrt(semiPerimeter * (semiPerimeter - Sides[0]) * (semiPerimeter - Sides[1]) * (semiPerimeter - Sides[2]));
	}
	private double CalculateAreaByTwoSides() => 0.5 * Sides[1] * Sides[2];
}
