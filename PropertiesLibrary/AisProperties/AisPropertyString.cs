namespace PropertiesLibrary.AisProperties
{
	using System;


	/// <summary>
	/// Строковое свойство.
	/// </summary>
	[Serializable]
	public sealed class AisPropertyString: AisProperty
	{
		public AisPropertyString( string code, string caption, string value, decimal sum ) : base( code, caption, sum )
		{
			this.Value = value;
		}
	}
}
