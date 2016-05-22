namespace PropertiesLibrary
{
	using System;


	/// <summary>
	/// Интерфейс свойств.
	/// </summary>
	public interface IAisProperty
	{
		string Code { get; }
		decimal Sum { get; }
		string Caption { get; }
		object Value { get; }
	}
}
