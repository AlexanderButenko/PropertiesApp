namespace PropertiesLibrary.AisProperties
{
	using System;


	/// <summary>
	/// Булевое свойствою
	/// </summary>
	[Serializable]
	public sealed class AisPropertyBool: AisProperty
	{
		public AisPropertyBool( string code, string caption, string value, decimal sum ) : base( code, caption, sum )
		{
			this.Value = Convert.ToBoolean( value );
		}
	}
}
