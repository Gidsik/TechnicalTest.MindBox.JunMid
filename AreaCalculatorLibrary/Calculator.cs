using System.Xml.Linq;

namespace AreaCalculatorLibrary
{
	/// <summary>
	/// Class with chain-based access to all library features
	/// </summary>
	public partial class Calculator
	{
		static Lazy<ThingsToCalc> _thingsToCalc = new Lazy<ThingsToCalc>();
		static Lazy<ThingsToCheck> _thingsToCheck = new Lazy<ThingsToCheck>();

		/// <summary>
		/// Contains methods with different calculations
		/// </summary>
		/// <returns><see cref="ThingsToCalc"/></returns>
		public static ThingsToCalc Calculate() => _thingsToCalc.Value;

		/// <summary>
		/// Contains methods with different checks
		/// </summary>
		/// <returns><see cref="ThingsToCheck"/></returns>
		public static ThingsToCheck Check() => _thingsToCheck.Value;

	}
}