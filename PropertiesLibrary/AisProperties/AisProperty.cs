namespace PropertiesLibrary.AisProperties
{
	/// <summary>
	/// Базовый класс свойств.
	/// </summary>
	public abstract class AisProperty: IAisProperty
	{
		#region Properties

		public virtual string Caption { get; set; }
		public virtual string Code { get; set; }
		public virtual decimal Sum { get; set; }
		public virtual dynamic Value { get; set; }

		#endregion


		/// <summary>
		/// Базовый конструктор.
		/// </summary>
		public AisProperty( string code, string caption, decimal sum )
		{
			this.Caption = caption;
			this.Code = code;
			this.Sum = sum;
		}


		public override string ToString()
		{
			return string.Format( "type={0} ({1}) ['{2}'], value={3}, sum={4}", this.GetType().Name, this.Code, this.Caption, this.Value, this.Sum );
		}
	}
}
