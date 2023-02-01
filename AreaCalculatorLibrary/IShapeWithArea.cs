using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary;

/// <summary>
/// For shapes that can have area
/// </summary>
public interface IShapeWithArea
{
	/// <summary>
	/// Returns area value of a shape that implements <see cref="IShapeWithArea"/>
	/// </summary>
	/// <returns>Area value</returns>
	public double GetArea();


}

