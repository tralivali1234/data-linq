﻿using System.ComponentModel.DataAnnotations.Schema;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	/// <summary>
	/// Used to configure a <see cref="T:System.string" /> property of an entity type or complex type.
	/// </summary>
	public class StringPropertyConfiguration : LengthPropertyConfiguration
	{
		/// <summary>
		/// Configures the property to allow the maximum length supported by the database provider.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsMaxLength()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to have the specified maximum length.
		/// </summary>
		/// <param name="value"> The maximum length for the property. Setting 'null' will remove any maximum length restriction from the property and a default length will be used for the database column.. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration HasMaxLength(int? value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be fixed length.
		/// Use HasMaxLength to set the length that the property is fixed to.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsFixedLength()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be variable length.
		/// <see cref="T:System.string" /> properties are variable length by default.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsVariableLength()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be optional.
		/// The database column used to store this property will be nullable.
		/// <see cref="T:System.string" /> properties are optional by default.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsOptional()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be required.
		/// The database column used to store this property will be non-nullable.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsRequired()
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
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration HasDatabaseGeneratedOption(
			DatabaseGeneratedOption? databaseGeneratedOption)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to be used as an optimistic concurrency token.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsConcurrencyToken()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures whether or not the property is to be used as an optimistic concurrency token.
		/// </summary>
		/// <param name="concurrencyToken"> Value indicating if the property is a concurrency token or not. Specifying 'null' will remove the concurrency token facet from the property. Specifying 'null' will cause the same runtime behavior as specifying 'false'. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the name of the database column used to store the property.
		/// </summary>
		/// <param name="columnName"> The name of the column. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration HasColumnName(string columnName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the data type of the database column used to store the property.
		/// </summary>
		/// <param name="columnType"> Name of the database provider specific data type. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration HasColumnType(string columnType)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the order of the database column used to store the property.
		/// This method is also used to specify key ordering when an entity type has a composite key.
		/// </summary>
		/// <param name="columnOrder"> The order that this column should appear in the database table. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public new StringPropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the property to support Unicode string content.
		/// </summary>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public StringPropertyConfiguration IsUnicode()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures whether or not the property supports Unicode string content.
		/// </summary>
		/// <param name="unicode"> Value indicating if the property supports Unicode string content or not. Specifying 'null' will remove the Unicode facet from the property. Specifying 'null' will cause the same runtime behavior as specifying 'false'. </param>
		/// <returns> The same StringPropertyConfiguration instance so that multiple calls can be chained. </returns>
		public StringPropertyConfiguration IsUnicode(bool? unicode)
		{
			throw new NotImplementedException();
		}
	}
}