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
    /// PaymentCreditCard
    /// </summary>
    [DataContract(Name = "PaymentCreditCard")]
    public partial class PaymentCreditCard : IEquatable<PaymentCreditCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCreditCard" /> class.
        /// </summary>
        /// <param name="firstDigit">firstDigit.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="merchantReference">merchantReference.</param>
        /// <param name="cardHolderName">cardHolderName.</param>
        /// <param name="amount">amount.</param>
        /// <param name="cardSummary">cardSummary.</param>
        /// <param name="applied">applied.</param>
        public PaymentCreditCard(string firstDigit = default(string), string pspReference = default(string), string merchantReference = default(string), string cardHolderName = default(string), decimal amount = default(decimal), string cardSummary = default(string), bool applied = default(bool))
        {
            this.FirstDigit = firstDigit;
            this.PspReference = pspReference;
            this.MerchantReference = merchantReference;
            this.CardHolderName = cardHolderName;
            this.Amount = amount;
            this.CardSummary = cardSummary;
            this.Applied = applied;
        }

        /// <summary>
        /// Gets or Sets FirstDigit
        /// </summary>
        [DataMember(Name = "firstDigit", EmitDefaultValue = false)]
        public string FirstDigit { get; set; }

        /// <summary>
        /// Gets or Sets PspReference
        /// </summary>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Gets or Sets MerchantReference
        /// </summary>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets CardHolderName
        /// </summary>
        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets CardSummary
        /// </summary>
        [DataMember(Name = "cardSummary", EmitDefaultValue = false)]
        public string CardSummary { get; set; }

        /// <summary>
        /// Gets or Sets Applied
        /// </summary>
        [DataMember(Name = "applied", EmitDefaultValue = true)]
        public bool Applied { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentCreditCard {\n");
            sb.Append("  FirstDigit: ").Append(FirstDigit).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CardSummary: ").Append(CardSummary).Append("\n");
            sb.Append("  Applied: ").Append(Applied).Append("\n");
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
            return this.Equals(input as PaymentCreditCard);
        }

        /// <summary>
        /// Returns true if PaymentCreditCard instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCreditCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstDigit == input.FirstDigit ||
                    (this.FirstDigit != null &&
                    this.FirstDigit.Equals(input.FirstDigit))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.CardHolderName == input.CardHolderName ||
                    (this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.CardSummary == input.CardSummary ||
                    (this.CardSummary != null &&
                    this.CardSummary.Equals(input.CardSummary))
                ) && 
                (
                    this.Applied == input.Applied ||
                    this.Applied.Equals(input.Applied)
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
                if (this.FirstDigit != null)
                {
                    hashCode = (hashCode * 59) + this.FirstDigit.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.CardHolderName != null)
                {
                    hashCode = (hashCode * 59) + this.CardHolderName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.CardSummary != null)
                {
                    hashCode = (hashCode * 59) + this.CardSummary.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Applied.GetHashCode();
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
            yield break;
        }
    }

}
