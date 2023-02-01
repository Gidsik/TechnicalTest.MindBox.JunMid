namespace AreaCalculatorLibrary
{
	public partial class Calculator
	{
		/// <summary>
		/// Contains methods with checks
		/// </summary>
		public partial class ThingsToCheck
		{
			static Lazy<TriangleChecks> _triangleChecks = new Lazy<TriangleChecks>();

			/// <summary>
			/// Contains triangle shape related checks
			/// </summary>
			/// <returns><see cref="TriangleChecks"/></returns>
			public TriangleChecks Triangle() => _triangleChecks.Value;
		}

	}
}