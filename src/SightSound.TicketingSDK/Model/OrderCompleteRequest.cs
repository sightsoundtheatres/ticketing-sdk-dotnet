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
    /// OrderCompleteRequest
    /// </summary>
    [DataContract(Name = "OrderCompleteRequest")]
    public partial class OrderCompleteRequest : IEquatable<OrderCompleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCompleteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCompleteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCompleteRequest" /> class.
        /// </summary>
        /// <param name="cart">cart (required).</param>
        /// <param name="delivery">delivery.</param>
        /// <param name="payment">payment.</param>
        /// <param name="seatLockToken">seatLockToken.</param>
        /// <param name="overflowSeatCount">overflowSeatCount.</param>
        /// <param name="emailList">emailList.</param>
        /// <param name="sameGroupConfirm">sameGroupConfirm.</param>
        public OrderCompleteRequest(CartRequest cart = default(CartRequest), OrderTicketDeliveryRequest delivery = default(OrderTicketDeliveryRequest), PaymentRequest payment = default(PaymentRequest), long seatLockToken = default(long), int overflowSeatCount = default(int), bool emailList = default(bool), bool sameGroupConfirm = default(bool))
        {
            // to ensure "cart" is required (not null)
            if (cart == null)
            {
                throw new ArgumentNullException("cart is a required property for OrderCompleteRequest and cannot be null");
            }
            this.Cart = cart;
            this.Delivery = delivery;
            this.Payment = payment;
            this.SeatLockToken = seatLockToken;
            this.OverflowSeatCount = overflowSeatCount;
            this.EmailList = emailList;
            this.SameGroupConfirm = sameGroupConfirm;
        }

        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name = "cart", IsRequired = true, EmitDefaultValue = false)]
        public CartRequest Cart { get; set; }

        /// <summary>
        /// Gets or Sets Delivery
        /// </summary>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        public OrderTicketDeliveryRequest Delivery { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public PaymentRequest Payment { get; set; }

        /// <summary>
        /// Gets or Sets SeatLockToken
        /// </summary>
        [DataMember(Name = "seatLockToken", EmitDefaultValue = false)]
        public long SeatLockToken { get; set; }

        /// <summary>
        /// Gets or Sets OverflowSeatCount
        /// </summary>
        [DataMember(Name = "overflowSeatCount", EmitDefaultValue = false)]
        public int OverflowSeatCount { get; set; }

        /// <summary>
        /// Gets or Sets EmailList
        /// </summary>
        [DataMember(Name = "emailList", EmitDefaultValue = true)]
        [Obsolete]
        public bool EmailList { get; set; }

        /// <summary>
        /// Gets or Sets SameGroupConfirm
        /// </summary>
        [DataMember(Name = "sameGroupConfirm", EmitDefaultValue = true)]
        public bool SameGroupConfirm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCompleteRequest {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  SeatLockToken: ").Append(SeatLockToken).Append("\n");
            sb.Append("  OverflowSeatCount: ").Append(OverflowSeatCount).Append("\n");
            sb.Append("  EmailList: ").Append(EmailList).Append("\n");
            sb.Append("  SameGroupConfirm: ").Append(SameGroupConfirm).Append("\n");
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
            return this.Equals(input as OrderCompleteRequest);
        }

        /// <summary>
        /// Returns true if OrderCompleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCompleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCompleteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cart == input.Cart ||
                    (this.Cart != null &&
                    this.Cart.Equals(input.Cart))
                ) && 
                (
                    this.Delivery == input.Delivery ||
                    (this.Delivery != null &&
                    this.Delivery.Equals(input.Delivery))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.SeatLockToken == input.SeatLockToken ||
                    this.SeatLockToken.Equals(input.SeatLockToken)
                ) && 
                (
                    this.OverflowSeatCount == input.OverflowSeatCount ||
                    this.OverflowSeatCount.Equals(input.OverflowSeatCount)
                ) && 
                (
                    this.EmailList == input.EmailList ||
                    this.EmailList.Equals(input.EmailList)
                ) && 
                (
                    this.SameGroupConfirm == input.SameGroupConfirm ||
                    this.SameGroupConfirm.Equals(input.SameGroupConfirm)
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
                if (this.Cart != null)
                {
                    hashCode = (hashCode * 59) + this.Cart.GetHashCode();
                }
                if (this.Delivery != null)
                {
                    hashCode = (hashCode * 59) + this.Delivery.GetHashCode();
                }
                if (this.Payment != null)
                {
                    hashCode = (hashCode * 59) + this.Payment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SeatLockToken.GetHashCode();
                hashCode = (hashCode * 59) + this.OverflowSeatCount.GetHashCode();
                hashCode = (hashCode * 59) + this.EmailList.GetHashCode();
                hashCode = (hashCode * 59) + this.SameGroupConfirm.GetHashCode();
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
