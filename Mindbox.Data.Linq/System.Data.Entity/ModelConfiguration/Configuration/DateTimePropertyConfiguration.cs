﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	/// <summary>
	/// Used to configure a <see cref="T:System.DateTime" /> property of an entity type or complex type.
	/// </summary>
	public class DateTimePropertyConfiguration : PrimitivePropertyConfiguration
	{
		private byte? precision;


		internal DateTimePropertyConfiguration(PropertyInfo property) 
			: base(property)
		{
		}


		/// <summary>
		/// Configures the property to be optional.
		/// The database column used to store this property will be nullable.
		/// </summary>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration IsOptional()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be required.
		/// The database column used to store this property will be non-nullable.
		/// <see cref="T:System.DateTime" /> properties are required by default.
		/// </summary>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration IsRequired()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures how values for the property are generated by the database.
		/// </summary>
		/// <param name="databaseGeneratedOption">
		/// The pattern used to generate values for the property in the database.
		/// Setting 'null' will cause the default option to be used, which may be 'None', 'Identity', or 'Computed' depending
		/// on the type of the property, its semantics in the model (e.g. primary keys are treated differently), and which
		/// set of conventions are being used.
		/// </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration HasDatabaseGeneratedOption(
			DatabaseGeneratedOption? databaseGeneratedOption)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be used as an optimistic concurrency token.
		/// </summary>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration IsConcurrencyToken()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures whether or not the property is to be used as an optimistic concurrency token.
		/// </summary>
		/// <param name="concurrencyToken"> Value indicating if the property is a concurrency token or not. Specifying 'null' will remove the concurrency token facet from the property. Specifying 'null' will cause the same runtime behavior as specifying 'false'. </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the name of the database column used to store the property.
		/// </summary>
		/// <param name="columnName"> The name of the column. </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration HasColumnName(string columnName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the data type of the database column used to store the property.
		/// </summary>
		/// <param name="columnType"> Name of the database provider specific data type. </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration HasColumnType(string columnType)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the order of the database column used to store the property.
		/// This method is also used to specify key ordering when an entity type has a composite key.
		/// </summary>
		/// <param name="columnOrder"> The order that this column should appear in the database table. </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new DateTimePropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the precision of the property.
		/// If the database provider does not support precision for the data type of the column then the value is ignored.
		/// </summary>
		/// <param name="value"> Precision of the property. </param>
		/// <returns> The same DateTimePropertyConfiguration instance so that multiple calls can be chained. </returns>
		public DateTimePropertyConfiguration HasPrecision(byte value)
		{
			precision = value;
			return this;
		}


		internal override string GetEffectiveColumnType()
		{
			return base.GetEffectiveColumnType() ?? (precision >= 7 ? "datetime2" : "datetime");
		}
	}
}
