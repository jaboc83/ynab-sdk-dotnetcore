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
    /// BudgetSettingsResponseData
    /// </summary>
    [DataContract]
    public partial class BudgetSettingsResponseData :  IEquatable<BudgetSettingsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSettingsResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetSettingsResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSettingsResponseData" /> class.
        /// </summary>
        /// <param name="settings">settings (required).</param>
        public BudgetSettingsResponseData(BudgetSettings settings = default(BudgetSettings))
        {
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new InvalidDataException("settings is a required property for BudgetSettingsResponseData and cannot be null");
            }
            else
            {
                this.Settings = settings;
            }

        }
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public BudgetSettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetSettingsResponseData {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as BudgetSettingsResponseData);
        }

        /// <summary>
        /// Returns true if BudgetSettingsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetSettingsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetSettingsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
