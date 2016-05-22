namespace PropertiesApplication
{
	using PropertiesLibrary;


	class Program
	{
		static void Main( string[] args )
		{
			var p = PropertyCreator.Create( "TP_OBJREPAIRWATERSYS", "true", 10.2m );

			System.Diagnostics.Trace.WriteLine( p.ToString() );
		}
	}
}
