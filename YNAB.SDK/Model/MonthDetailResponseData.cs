/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// MonthDetailResponseData
    /// </summary>
    [DataContract]
    public partial class MonthDetailResponseData :  IEquatable<MonthDetailResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthDetailResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MonthDetailResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthDetailResponseData" /> class.
        /// </summary>
        /// <param name="month">month (required).</param>
        public MonthDetailResponseData(MonthDetail month = default(MonthDetail))
        {
            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new InvalidDataException("month is a required property for MonthDetailResponseData and cannot be null");
            }
            else
            {
                this.Month = month;
            }

        }
        
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public MonthDetail Month { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonthDetailResponseData {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonthDetailResponseData);
        }

        /// <summary>
        /// Returns true if MonthDetailResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthDetailResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthDetailResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
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
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
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
