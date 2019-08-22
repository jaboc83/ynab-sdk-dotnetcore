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
    /// BudgetDetailAllOf
    /// </summary>
    [DataContract]
    public partial class BudgetDetailAllOf :  IEquatable<BudgetDetailAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDetailAllOf" /> class.
        /// </summary>
        /// <param name="accounts">accounts.</param>
        /// <param name="payees">payees.</param>
        /// <param name="payeeLocations">payeeLocations.</param>
        /// <param name="categoryGroups">categoryGroups.</param>
        /// <param name="categories">categories.</param>
        /// <param name="months">months.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="subtransactions">subtransactions.</param>
        /// <param name="scheduledTransactions">scheduledTransactions.</param>
        /// <param name="scheduledSubtransactions">scheduledSubtransactions.</param>
        public BudgetDetailAllOf(List<Account> accounts = default(List<Account>), List<Payee> payees = default(List<Payee>), List<PayeeLocation> payeeLocations = default(List<PayeeLocation>), List<CategoryGroup> categoryGroups = default(List<CategoryGroup>), List<Category> categories = default(List<Category>), List<MonthDetail> months = default(List<MonthDetail>), List<TransactionSummary> transactions = default(List<TransactionSummary>), List<SubTransaction> subtransactions = default(List<SubTransaction>), List<ScheduledTransactionSummary> scheduledTransactions = default(List<ScheduledTransactionSummary>), List<ScheduledSubTransaction> scheduledSubtransactions = default(List<ScheduledSubTransaction>))
        {
            this.Accounts = accounts;
            this.Payees = payees;
            this.PayeeLocations = payeeLocations;
            this.CategoryGroups = categoryGroups;
            this.Categories = categories;
            this.Months = months;
            this.Transactions = transactions;
            this.Subtransactions = subtransactions;
            this.ScheduledTransactions = scheduledTransactions;
            this.ScheduledSubtransactions = scheduledSubtransactions;
        }
        
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Payees
        /// </summary>
        [DataMember(Name="payees", EmitDefaultValue=false)]
        public List<Payee> Payees { get; set; }

        /// <summary>
        /// Gets or Sets PayeeLocations
        /// </summary>
        [DataMember(Name="payee_locations", EmitDefaultValue=false)]
        public List<PayeeLocation> PayeeLocations { get; set; }

        /// <summary>
        /// Gets or Sets CategoryGroups
        /// </summary>
        [DataMember(Name="category_groups", EmitDefaultValue=false)]
        public List<CategoryGroup> CategoryGroups { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Months
        /// </summary>
        [DataMember(Name="months", EmitDefaultValue=false)]
        public List<MonthDetail> Months { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<TransactionSummary> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Subtransactions
        /// </summary>
        [DataMember(Name="subtransactions", EmitDefaultValue=false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledTransactions
        /// </summary>
        [DataMember(Name="scheduled_transactions", EmitDefaultValue=false)]
        public List<ScheduledTransactionSummary> ScheduledTransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledSubtransactions
        /// </summary>
        [DataMember(Name="scheduled_subtransactions", EmitDefaultValue=false)]
        public List<ScheduledSubTransaction> ScheduledSubtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetDetailAllOf {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Payees: ").Append(Payees).Append("\n");
            sb.Append("  PayeeLocations: ").Append(PayeeLocations).Append("\n");
            sb.Append("  CategoryGroups: ").Append(CategoryGroups).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
            sb.Append("  ScheduledTransactions: ").Append(ScheduledTransactions).Append("\n");
            sb.Append("  ScheduledSubtransactions: ").Append(ScheduledSubtransactions).Append("\n");
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
            return this.Equals(input as BudgetDetailAllOf);
        }

        /// <summary>
        /// Returns true if BudgetDetailAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetDetailAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetDetailAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Payees == input.Payees ||
                    this.Payees != null &&
                    input.Payees != null &&
                    this.Payees.SequenceEqual(input.Payees)
                ) && 
                (
                    this.PayeeLocations == input.PayeeLocations ||
                    this.PayeeLocations != null &&
                    input.PayeeLocations != null &&
                    this.PayeeLocations.SequenceEqual(input.PayeeLocations)
                ) && 
                (
                    this.CategoryGroups == input.CategoryGroups ||
                    this.CategoryGroups != null &&
                    input.CategoryGroups != null &&
                    this.CategoryGroups.SequenceEqual(input.CategoryGroups)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Months == input.Months ||
                    this.Months != null &&
                    input.Months != null &&
                    this.Months.SequenceEqual(input.Months)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    input.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
                ) && 
                (
                    this.ScheduledTransactions == input.ScheduledTransactions ||
                    this.ScheduledTransactions != null &&
                    input.ScheduledTransactions != null &&
                    this.ScheduledTransactions.SequenceEqual(input.ScheduledTransactions)
                ) && 
                (
                    this.ScheduledSubtransactions == input.ScheduledSubtransactions ||
                    this.ScheduledSubtransactions != null &&
                    input.ScheduledSubtransactions != null &&
                    this.ScheduledSubtransactions.SequenceEqual(input.ScheduledSubtransactions)
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Payees != null)
                    hashCode = hashCode * 59 + this.Payees.GetHashCode();
                if (this.PayeeLocations != null)
                    hashCode = hashCode * 59 + this.PayeeLocations.GetHashCode();
                if (this.CategoryGroups != null)
                    hashCode = hashCode * 59 + this.CategoryGroups.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Months != null)
                    hashCode = hashCode * 59 + this.Months.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
                if (this.ScheduledTransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledTransactions.GetHashCode();
                if (this.ScheduledSubtransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledSubtransactions.GetHashCode();
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
