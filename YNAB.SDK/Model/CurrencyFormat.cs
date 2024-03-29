/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// The currency format setting for the budget.  In some cases the format will not be available and will be specified as null.
    /// </summary>
    [DataContract(Name = "CurrencyFormat")]
    public partial class CurrencyFormat : IEquatable<CurrencyFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrencyFormat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyFormat" /> class.
        /// </summary>
        /// <param name="isoCode">isoCode (required).</param>
        /// <param name="exampleFormat">exampleFormat (required).</param>
        /// <param name="decimalDigits">decimalDigits (required).</param>
        /// <param name="decimalSeparator">decimalSeparator (required).</param>
        /// <param name="symbolFirst">symbolFirst (required).</param>
        /// <param name="groupSeparator">groupSeparator (required).</param>
        /// <param name="currencySymbol">currencySymbol (required).</param>
        /// <param name="displaySymbol">displaySymbol (required).</param>
        public CurrencyFormat(string isoCode = default(string), string exampleFormat = default(string), int decimalDigits = default(int), string decimalSeparator = default(string), bool symbolFirst = default(bool), string groupSeparator = default(string), string currencySymbol = default(string), bool displaySymbol = default(bool))
        {
            // to ensure "isoCode" is required (not null)
            this.IsoCode = isoCode ?? throw new ArgumentNullException("isoCode is a required property for CurrencyFormat and cannot be null");
            // to ensure "exampleFormat" is required (not null)
            this.ExampleFormat = exampleFormat ?? throw new ArgumentNullException("exampleFormat is a required property for CurrencyFormat and cannot be null");
            this.DecimalDigits = decimalDigits;
            // to ensure "decimalSeparator" is required (not null)
            this.DecimalSeparator = decimalSeparator ?? throw new ArgumentNullException("decimalSeparator is a required property for CurrencyFormat and cannot be null");
            this.SymbolFirst = symbolFirst;
            // to ensure "groupSeparator" is required (not null)
            this.GroupSeparator = groupSeparator ?? throw new ArgumentNullException("groupSeparator is a required property for CurrencyFormat and cannot be null");
            // to ensure "currencySymbol" is required (not null)
            this.CurrencySymbol = currencySymbol ?? throw new ArgumentNullException("currencySymbol is a required property for CurrencyFormat and cannot be null");
            this.DisplaySymbol = displaySymbol;
        }

        /// <summary>
        /// Gets or Sets IsoCode
        /// </summary>
        [DataMember(Name = "iso_code", IsRequired = true, EmitDefaultValue = false)]
        public string IsoCode { get; set; }

        /// <summary>
        /// Gets or Sets ExampleFormat
        /// </summary>
        [DataMember(Name = "example_format", IsRequired = true, EmitDefaultValue = false)]
        public string ExampleFormat { get; set; }

        /// <summary>
        /// Gets or Sets DecimalDigits
        /// </summary>
        [DataMember(Name = "decimal_digits", IsRequired = true, EmitDefaultValue = false)]
        public int DecimalDigits { get; set; }

        /// <summary>
        /// Gets or Sets DecimalSeparator
        /// </summary>
        [DataMember(Name = "decimal_separator", IsRequired = true, EmitDefaultValue = false)]
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Gets or Sets SymbolFirst
        /// </summary>
        [DataMember(Name = "symbol_first", IsRequired = true, EmitDefaultValue = true)]
        public bool SymbolFirst { get; set; }

        /// <summary>
        /// Gets or Sets GroupSeparator
        /// </summary>
        [DataMember(Name = "group_separator", IsRequired = true, EmitDefaultValue = false)]
        public string GroupSeparator { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name = "currency_symbol", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets DisplaySymbol
        /// </summary>
        [DataMember(Name = "display_symbol", IsRequired = true, EmitDefaultValue = true)]
        public bool DisplaySymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyFormat {\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
            sb.Append("  ExampleFormat: ").Append(ExampleFormat).Append("\n");
            sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
            sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
            sb.Append("  SymbolFirst: ").Append(SymbolFirst).Append("\n");
            sb.Append("  GroupSeparator: ").Append(GroupSeparator).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  DisplaySymbol: ").Append(DisplaySymbol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CurrencyFormat);
        }

        /// <summary>
        /// Returns true if CurrencyFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsoCode == input.IsoCode ||
                    (this.IsoCode != null &&
                    this.IsoCode.Equals(input.IsoCode))
                ) && 
                (
                    this.ExampleFormat == input.ExampleFormat ||
                    (this.ExampleFormat != null &&
                    this.ExampleFormat.Equals(input.ExampleFormat))
                ) && 
                (
                    this.DecimalDigits == input.DecimalDigits ||
                    this.DecimalDigits.Equals(input.DecimalDigits)
                ) && 
                (
                    this.DecimalSeparator == input.DecimalSeparator ||
                    (this.DecimalSeparator != null &&
                    this.DecimalSeparator.Equals(input.DecimalSeparator))
                ) && 
                (
                    this.SymbolFirst == input.SymbolFirst ||
                    this.SymbolFirst.Equals(input.SymbolFirst)
                ) && 
                (
                    this.GroupSeparator == input.GroupSeparator ||
                    (this.GroupSeparator != null &&
                    this.GroupSeparator.Equals(input.GroupSeparator))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.DisplaySymbol == input.DisplaySymbol ||
                    this.DisplaySymbol.Equals(input.DisplaySymbol)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IsoCode != null)
                    hashCode = hashCode * 59 + this.IsoCode.GetHashCode();
                if (this.ExampleFormat != null)
                    hashCode = hashCode * 59 + this.ExampleFormat.GetHashCode();
                hashCode = hashCode * 59 + this.DecimalDigits.GetHashCode();
                if (this.DecimalSeparator != null)
                    hashCode = hashCode * 59 + this.DecimalSeparator.GetHashCode();
                hashCode = hashCode * 59 + this.SymbolFirst.GetHashCode();
                if (this.GroupSeparator != null)
                    hashCode = hashCode * 59 + this.GroupSeparator.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                hashCode = hashCode * 59 + this.DisplaySymbol.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
