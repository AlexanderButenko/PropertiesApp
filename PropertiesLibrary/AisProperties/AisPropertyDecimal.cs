namespace PropertiesLibrary.AisProperties
{
	using System;


	/// <summary>
	/// Десятичное свойство.
	/// </summary>
	[Serializable]
	public sealed class AisPropertyDecimal: AisProperty
	{
		public AisPropertyDecimal( string code, string caption, string value, decimal sum ) : base( code, caption, sum )
		{
			this.Value = Convert.ToDecimal( value );
		}
	}
}
