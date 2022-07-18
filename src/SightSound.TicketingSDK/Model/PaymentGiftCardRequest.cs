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
    /// PaymentGiftCardRequest
    /// </summary>
    [DataContract(Name = "PaymentGiftCardRequest")]
    public partial class PaymentGiftCardRequest : IEquatable<PaymentGiftCardRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGiftCardRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentGiftCardRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGiftCardRequest" /> class.
        /// </summary>
        /// <param name="amountToCharge">amountToCharge.</param>
        /// <param name="cardNumber">cardNumber (required).</param>
        public PaymentGiftCardRequest(decimal amountToCharge = default(decimal), string cardNumber = default(string))
        {
            // to ensure "cardNumber" is required (not null)
            if (cardNumber == null)
            {
                throw new ArgumentNullException("cardNumber is a required property for PaymentGiftCardRequest and cannot be null");
            }
            this.CardNumber = cardNumber;
            this.AmountToCharge = amountToCharge;
        }

        /// <summary>
        /// Gets or Sets AmountToCharge
        /// </summary>
        [DataMember(Name = "amountToCharge", EmitDefaultValue = false)]
        public decimal AmountToCharge { get; set; }

        /// <summary>
        /// Gets or Sets CardNumber
        /// </summary>
        [DataMember(Name = "cardNumber", IsRequired = true, EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentGiftCardRequest {\n");
            sb.Append("  AmountToCharge: ").Append(AmountToCharge).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
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
            return this.Equals(input as PaymentGiftCardRequest);
        }

        /// <summary>
        /// Returns true if PaymentGiftCardRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentGiftCardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentGiftCardRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountToCharge == input.AmountToCharge ||
                    this.AmountToCharge.Equals(input.AmountToCharge)
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
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
                hashCode = (hashCode * 59) + this.AmountToCharge.GetHashCode();
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
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
            yield break;
        }
    }

}
