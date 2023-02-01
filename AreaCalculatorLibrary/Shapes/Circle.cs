using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary.Shapes;

public class Circle : IShapeWithArea
{
	private double _area;

	/// <summary>
	/// Given radius of a circle
	/// </summary>
	public double Radius { get; private set; }

	/// <summary>
	/// Represents circle by radius
	/// </summary>
	/// <param name="radius">radius of a circle</param>
	public Circle(double radius)
	{
		if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), radius, "Radius can't be less or equal to zero");

		Radius = radius;
		CalculateAreaByRadius();
	}

	public double GetArea()
	{
		return _area;
	}
	
	private void CalculateAreaByRadius()
	{
		_area = Math.PI * Math.Pow(Radius, 2);
	}
}

