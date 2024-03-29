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
    /// PayeesResponseData
    /// </summary>
    [DataContract(Name = "PayeesResponse_data")]
    public partial class PayeesResponseData : IEquatable<PayeesResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayeesResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesResponseData" /> class.
        /// </summary>
        /// <param name="payees">payees (required).</param>
        /// <param name="serverKnowledge">The knowledge of the server (required).</param>
        public PayeesResponseData(List<Payee> payees = default(List<Payee>), long serverKnowledge = default(long))
        {
            // to ensure "payees" is required (not null)
            this.Payees = payees ?? throw new ArgumentNullException("payees is a required property for PayeesResponseData and cannot be null");
            this.ServerKnowledge = serverKnowledge;
        }

        /// <summary>
        /// Gets or Sets Payees
        /// </summary>
        [DataMember(Name = "payees", IsRequired = true, EmitDefaultValue = false)]
        public List<Payee> Payees { get; set; }

        /// <summary>
        /// The knowledge of the server
        /// </summary>
        /// <value>The knowledge of the server</value>
        [DataMember(Name = "server_knowledge", IsRequired = true, EmitDefaultValue = false)]
        public long ServerKnowledge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayeesResponseData {\n");
            sb.Append("  Payees: ").Append(Payees).Append("\n");
            sb.Append("  ServerKnowledge: ").Append(ServerKnowledge).Append("\n");
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
            return this.Equals(input as PayeesResponseData);
        }

        /// <summary>
        /// Returns true if PayeesResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of PayeesResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayeesResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Payees == input.Payees ||
                    this.Payees != null &&
                    input.Payees != null &&
                    this.Payees.SequenceEqual(input.Payees)
                ) && 
                (
                    this.ServerKnowledge == input.ServerKnowledge ||
                    this.ServerKnowledge.Equals(input.ServerKnowledge)
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
                if (this.Payees != null)
                    hashCode = hashCode * 59 + this.Payees.GetHashCode();
                hashCode = hashCode * 59 + this.ServerKnowledge.GetHashCode();
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
