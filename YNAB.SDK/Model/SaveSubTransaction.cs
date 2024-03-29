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
    /// SaveSubTransaction
    /// </summary>
    [DataContract(Name = "SaveSubTransaction")]
    public partial class SaveSubTransaction : IEquatable<SaveSubTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveSubTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveSubTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveSubTransaction" /> class.
        /// </summary>
        /// <param name="amount">The subtransaction amount in milliunits format. (required).</param>
        /// <param name="payeeId">The payee for the subtransaction..</param>
        /// <param name="payeeName">The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified on parent transaction) or (2) a payee with the same name or (3) creation of a new payee..</param>
        /// <param name="categoryId">The category for the subtransaction.  Credit Card Payment categories are not permitted and will be ignored if supplied..</param>
        /// <param name="memo">memo.</param>
        public SaveSubTransaction(long amount = default(long), Guid payeeId = default(Guid), string payeeName = default(string), Guid categoryId = default(Guid), string memo = default(string))
        {
            this.Amount = amount;
            this.PayeeId = payeeId;
            this.PayeeName = payeeName;
            this.CategoryId = categoryId;
            this.Memo = memo;
        }

        /// <summary>
        /// The subtransaction amount in milliunits format.
        /// </summary>
        /// <value>The subtransaction amount in milliunits format.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// The payee for the subtransaction.
        /// </summary>
        /// <value>The payee for the subtransaction.</value>
        [DataMember(Name = "payee_id", EmitDefaultValue = false)]
        public Guid PayeeId { get; set; }

        /// <summary>
        /// The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified on parent transaction) or (2) a payee with the same name or (3) creation of a new payee.
        /// </summary>
        /// <value>The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified on parent transaction) or (2) a payee with the same name or (3) creation of a new payee.</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// The category for the subtransaction.  Credit Card Payment categories are not permitted and will be ignored if supplied.
        /// </summary>
        /// <value>The category for the subtransaction.  Credit Card Payment categories are not permitted and will be ignored if supplied.</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveSubTransaction {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
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
            return this.Equals(input as SaveSubTransaction);
        }

        /// <summary>
        /// Returns true if SaveSubTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveSubTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveSubTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
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
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
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
            // PayeeName (string) maxLength
            if(this.PayeeName != null && this.PayeeName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayeeName, length must be less than 50.", new [] { "PayeeName" });
            }

            // Memo (string) maxLength
            if(this.Memo != null && this.Memo.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Memo, length must be less than 200.", new [] { "Memo" });
            }

            yield break;
        }
    }

}
