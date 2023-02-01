namespace AreaCalculatorLibrary
{
	public partial class Calculator
	{
		/// <summary>
		/// Contains methods to
		/// </summary>
		public partial class ThingsToCalc
		{
			static Lazy<ShapesAreas> _shapesArea = new Lazy<ShapesAreas>();

			/// <summary>
			/// Contains methods that can get areas of shapes
			/// </summary>
			/// <returns><see cref="ShapesAreas"/></returns>
			public ShapesAreas AreaOf() => _shapesArea.Value;
		}

	}
}