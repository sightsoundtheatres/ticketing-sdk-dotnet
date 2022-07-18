/*
 * Partner Ticketing API
 *
 * Sight & Sound Theatres Partner Ticketing API
 *
 * The version of the OpenAPI document: 0.0.1-SNAPSHOT
 * Contact: DeveloperTeam@sight-sound.com
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
using OpenAPIDateConverter = SightSound.TicketingSDK.Client.OpenAPIDateConverter;

namespace SightSound.TicketingSDK.Model
{
    /// <summary>
    /// OrderItemTax
    /// </summary>
    [DataContract(Name = "OrderItemTax")]
    public partial class OrderItemTax : IEquatable<OrderItemTax>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [DataMember(Name = "taxType", IsRequired = true, EmitDefaultValue = false)]
        public TaxType TaxType { get; set; }

        /// <summary>
        /// Gets or Sets Jurisdiction
        /// </summary>
        [DataMember(Name = "jurisdiction", IsRequired = true, EmitDefaultValue = false)]
        public TaxJurisdictionType Jurisdiction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemTax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderItemTax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemTax" /> class.
        /// </summary>
        /// <param name="orderItem">orderItem.</param>
        /// <param name="taxType">taxType (required).</param>
        /// <param name="jurisdiction">jurisdiction (required).</param>
        /// <param name="taxDescription">taxDescription.</param>
        /// <param name="taxPercent">taxPercent.</param>
        /// <param name="taxPercentAmount">taxPercentAmount.</param>
        /// <param name="tax">tax.</param>
        /// <param name="entryDate">entryDate.</param>
        public OrderItemTax(OrderItem orderItem = default(OrderItem), TaxType taxType = default(TaxType), TaxJurisdictionType jurisdiction = default(TaxJurisdictionType), string taxDescription = default(string), decimal taxPercent = default(decimal), decimal taxPercentAmount = default(decimal), decimal tax = default(decimal), DateTime entryDate = default(DateTime))
        {
            this.TaxType = taxType;
            this.Jurisdiction = jurisdiction;
            this.OrderItem = orderItem;
            this.TaxDescription = taxDescription;
            this.TaxPercent = taxPercent;
            this.TaxPercentAmount = taxPercentAmount;
            this.Tax = tax;
            this.EntryDate = entryDate;
        }

        /// <summary>
        /// Gets or Sets OrderItem
        /// </summary>
        [DataMember(Name = "orderItem", EmitDefaultValue = false)]
        public OrderItem OrderItem { get; set; }

        /// <summary>
        /// Gets or Sets TaxDescription
        /// </summary>
        [DataMember(Name = "taxDescription", EmitDefaultValue = false)]
        public string TaxDescription { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name = "taxPercent", EmitDefaultValue = false)]
        public decimal TaxPercent { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercentAmount
        /// </summary>
        [DataMember(Name = "taxPercentAmount", EmitDefaultValue = false)]
        public decimal TaxPercentAmount { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or Sets EntryDate
        /// </summary>
        [DataMember(Name = "entryDate", EmitDefaultValue = false)]
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderItemTax {\n");
            sb.Append("  OrderItem: ").Append(OrderItem).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  TaxDescription: ").Append(TaxDescription).Append("\n");
            sb.Append("  TaxPercent: ").Append(TaxPercent).Append("\n");
            sb.Append("  TaxPercentAmount: ").Append(TaxPercentAmount).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
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
            return this.Equals(input as OrderItemTax);
        }

        /// <summary>
        /// Returns true if OrderItemTax instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemTax input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderItem == input.OrderItem ||
                    (this.OrderItem != null &&
                    this.OrderItem.Equals(input.OrderItem))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    this.TaxType.Equals(input.TaxType)
                ) && 
                (
                    this.Jurisdiction == input.Jurisdiction ||
                    this.Jurisdiction.Equals(input.Jurisdiction)
                ) && 
                (
                    this.TaxDescription == input.TaxDescription ||
                    (this.TaxDescription != null &&
                    this.TaxDescription.Equals(input.TaxDescription))
                ) && 
                (
                    this.TaxPercent == input.TaxPercent ||
                    this.TaxPercent.Equals(input.TaxPercent)
                ) && 
                (
                    this.TaxPercentAmount == input.TaxPercentAmount ||
                    this.TaxPercentAmount.Equals(input.TaxPercentAmount)
                ) && 
                (
                    this.Tax == input.Tax ||
                    this.Tax.Equals(input.Tax)
                ) && 
                (
                    this.EntryDate == input.EntryDate ||
                    (this.EntryDate != null &&
                    this.EntryDate.Equals(input.EntryDate))
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
                if (this.OrderItem != null)
                {
                    hashCode = (hashCode * 59) + this.OrderItem.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
                hashCode = (hashCode * 59) + this.Jurisdiction.GetHashCode();
                if (this.TaxDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TaxDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxPercent.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxPercentAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Tax.GetHashCode();
                if (this.EntryDate != null)
                {
                    hashCode = (hashCode * 59) + this.EntryDate.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // TaxDescription (string) maxLength
            if (this.TaxDescription != null && this.TaxDescription.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxDescription, length must be less than 30.", new [] { "TaxDescription" });
            }

            // TaxDescription (string) minLength
            if (this.TaxDescription != null && this.TaxDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxDescription, length must be greater than 0.", new [] { "TaxDescription" });
            }

            yield break;
        }
    }

}
