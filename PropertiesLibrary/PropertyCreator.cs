namespace PropertiesLibrary
{
	using AisProperties;
	using System;
	using System.Collections.Generic;


	/// <summary>
	/// Построитель свойств.
	/// </summary>
	public static class PropertyCreator
	{
		#region Map

		private static Dictionary<string, Func<string, string, decimal, IAisProperty>> __codeMap = new Dictionary<string, Func<string, string, decimal, IAisProperty>>()
		{
			//	{ "", ( code, value, sum ) => CreateBool( code, "", value, sum ) },

			{ "TP_OBJREPAIRWATERSYS", ( code, value, sum ) => CreateBool( code, "Планируется проведение ремонтных работ в период действия договора", value, sum ) },
			{ "TP_PRESSYSAUTOSTOPDELWATER", ( code, value, sum ) => CreateBool( code, "Наличие системы автоматического прекращения подачи воды", value, sum ) },
			{ "TP_AGREEDNOTREPLAN", ( code, value, sum ) => CreateBool( code, "Несогласованная перепланировка", value, sum ) },
			{ "TP_AGREEDREPLAN", ( code, value, sum ) => CreateBool( code, "Согласованная перепланировка", value, sum ) },
			{ "TP_OBJTOILET", ( code, value, sum ) => CreateBool( code, "Наличие двух и более санузлов", value, sum ) },
			{ "LastFloor", ( code, value, sum ) => CreateBool( code, "Последний этаж", value, sum ) },
			{ "TP_OBJTOTALAREA", ( code, value, sum ) => CreateDecimal( code, "Площадь, м2", value, sum ) },
			{ "HOMECARCASS", ( code, value, sum ) => CreateString( code, "", value, sum ) },
			{ "TP_MATERIALWALLS", ( code, value, sum ) => CreateString( code, "Материал стен/перекрытий", value, sum ) },
			{ "TP_OBJTYPE", ( code, value, sum ) => CreateString( code, "Тип объекта, в котором расположено имущество", value, sum ) },
			{ "TP_OBJSECALARMCOMEGROUP", ( code, value, sum ) => CreateBool( code, "Наличие охранной сигнализации с гнр (с выездом группы реагирования)", value, sum ) },
		};

		#endregion


		/// <summary>
		/// Метод-построитель.
		/// </summary>
		public static IAisProperty Create( string code, string value, decimal sum )
		{
			if( !__codeMap.ContainsKey( code ) ) throw new NotImplementedException( string.Format( "Type for code '{0}' does not implemented.", code ) );
			return __codeMap[code]( code, value, sum );
		}


		private static IAisProperty CreateBool( string code, string caption, string value, decimal sum )
		{
			return new AisPropertyBool( code, caption, value, sum );
		}


		private static IAisProperty CreateDecimal( string code, string caption, string value, decimal sum )
		{
			return new AisPropertyDecimal( code, caption, value, sum );
		}


		private static IAisProperty CreateString( string code, string caption, string value, decimal sum )
		{
			return new AisPropertyString( code, caption, value, sum );
		}
	}
}
