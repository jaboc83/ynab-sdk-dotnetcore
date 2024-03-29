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
    /// PayeeLocationsResponseData
    /// </summary>
    [DataContract(Name = "PayeeLocationsResponse_data")]
    public partial class PayeeLocationsResponseData : IEquatable<PayeeLocationsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationsResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayeeLocationsResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationsResponseData" /> class.
        /// </summary>
        /// <param name="payeeLocations">payeeLocations (required).</param>
        public PayeeLocationsResponseData(List<PayeeLocation> payeeLocations = default(List<PayeeLocation>))
        {
            // to ensure "payeeLocations" is required (not null)
            this.PayeeLocations = payeeLocations ?? throw new ArgumentNullException("payeeLocations is a required property for PayeeLocationsResponseData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PayeeLocations
        /// </summary>
        [DataMember(Name = "payee_locations", IsRequired = true, EmitDefaultValue = false)]
        public List<PayeeLocation> PayeeLocations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayeeLocationsResponseData {\n");
            sb.Append("  PayeeLocations: ").Append(PayeeLocations).Append("\n");
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
            return this.Equals(input as PayeeLocationsResponseData);
        }

        /// <summary>
        /// Returns true if PayeeLocationsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of PayeeLocationsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayeeLocationsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayeeLocations == input.PayeeLocations ||
                    this.PayeeLocations != null &&
                    input.PayeeLocations != null &&
                    this.PayeeLocations.SequenceEqual(input.PayeeLocations)
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
                if (this.PayeeLocations != null)
                    hashCode = hashCode * 59 + this.PayeeLocations.GetHashCode();
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
