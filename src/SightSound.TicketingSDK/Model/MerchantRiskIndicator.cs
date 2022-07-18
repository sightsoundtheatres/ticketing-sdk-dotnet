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
    /// MerchantRiskIndicator
    /// </summary>
    [DataContract(Name = "MerchantRiskIndicator")]
    public partial class MerchantRiskIndicator : IEquatable<MerchantRiskIndicator>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeliveryAddressIndicator
        /// </summary>
        [DataMember(Name = "deliveryAddressIndicator", EmitDefaultValue = false)]
        public DeliveryAddressIndicatorEnum? DeliveryAddressIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTimeframe
        /// </summary>
        [DataMember(Name = "deliveryTimeframe", EmitDefaultValue = false)]
        public DeliveryTimeframeEnum? DeliveryTimeframe { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRiskIndicator" /> class.
        /// </summary>
        /// <param name="addressMatch">addressMatch.</param>
        /// <param name="deliveryAddressIndicator">deliveryAddressIndicator.</param>
        /// <param name="deliveryEmail">deliveryEmail.</param>
        /// <param name="deliveryTimeframe">deliveryTimeframe.</param>
        /// <param name="giftCardAmount">giftCardAmount.</param>
        /// <param name="giftCardCount">giftCardCount.</param>
        /// <param name="preOrderDate">preOrderDate.</param>
        /// <param name="preOrderPurchase">preOrderPurchase.</param>
        /// <param name="reorderItems">reorderItems.</param>
        public MerchantRiskIndicator(bool addressMatch = default(bool), DeliveryAddressIndicatorEnum? deliveryAddressIndicator = default(DeliveryAddressIndicatorEnum?), string deliveryEmail = default(string), DeliveryTimeframeEnum? deliveryTimeframe = default(DeliveryTimeframeEnum?), Amount giftCardAmount = default(Amount), int giftCardCount = default(int), DateTime preOrderDate = default(DateTime), bool preOrderPurchase = default(bool), bool reorderItems = default(bool))
        {
            this.AddressMatch = addressMatch;
            this.DeliveryAddressIndicator = deliveryAddressIndicator;
            this.DeliveryEmail = deliveryEmail;
            this.DeliveryTimeframe = deliveryTimeframe;
            this.GiftCardAmount = giftCardAmount;
            this.GiftCardCount = giftCardCount;
            this.PreOrderDate = preOrderDate;
            this.PreOrderPurchase = preOrderPurchase;
            this.ReorderItems = reorderItems;
        }

        /// <summary>
        /// Gets or Sets AddressMatch
        /// </summary>
        [DataMember(Name = "addressMatch", EmitDefaultValue = true)]
        public bool AddressMatch { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryEmail
        /// </summary>
        [DataMember(Name = "deliveryEmail", EmitDefaultValue = false)]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// Gets or Sets GiftCardAmount
        /// </summary>
        [DataMember(Name = "giftCardAmount", EmitDefaultValue = false)]
        public Amount GiftCardAmount { get; set; }

        /// <summary>
        /// Gets or Sets GiftCardCount
        /// </summary>
        [DataMember(Name = "giftCardCount", EmitDefaultValue = false)]
        public int GiftCardCount { get; set; }

        /// <summary>
        /// Gets or Sets PreOrderDate
        /// </summary>
        [DataMember(Name = "preOrderDate", EmitDefaultValue = false)]
        public DateTime PreOrderDate { get; set; }

        /// <summary>
        /// Gets or Sets PreOrderPurchase
        /// </summary>
        [DataMember(Name = "preOrderPurchase", EmitDefaultValue = true)]
        public bool PreOrderPurchase { get; set; }

        /// <summary>
        /// Gets or Sets ReorderItems
        /// </summary>
        [DataMember(Name = "reorderItems", EmitDefaultValue = true)]
        public bool ReorderItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantRiskIndicator {\n");
            sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
            sb.Append("  DeliveryAddressIndicator: ").Append(DeliveryAddressIndicator).Append("\n");
            sb.Append("  DeliveryEmail: ").Append(DeliveryEmail).Append("\n");
            sb.Append("  DeliveryTimeframe: ").Append(DeliveryTimeframe).Append("\n");
            sb.Append("  GiftCardAmount: ").Append(GiftCardAmount).Append("\n");
            sb.Append("  GiftCardCount: ").Append(GiftCardCount).Append("\n");
            sb.Append("  PreOrderDate: ").Append(PreOrderDate).Append("\n");
            sb.Append("  PreOrderPurchase: ").Append(PreOrderPurchase).Append("\n");
            sb.Append("  ReorderItems: ").Append(ReorderItems).Append("\n");
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
            return this.Equals(input as MerchantRiskIndicator);
        }

        /// <summary>
        /// Returns true if MerchantRiskIndicator instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantRiskIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantRiskIndicator input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressMatch == input.AddressMatch ||
                    this.AddressMatch.Equals(input.AddressMatch)
                ) && 
                (
                    this.DeliveryAddressIndicator == input.DeliveryAddressIndicator ||
                    this.DeliveryAddressIndicator.Equals(input.DeliveryAddressIndicator)
                ) && 
                (
                    this.DeliveryEmail == input.DeliveryEmail ||
                    (this.DeliveryEmail != null &&
                    this.DeliveryEmail.Equals(input.DeliveryEmail))
                ) && 
                (
                    this.DeliveryTimeframe == input.DeliveryTimeframe ||
                    this.DeliveryTimeframe.Equals(input.DeliveryTimeframe)
                ) && 
                (
                    this.GiftCardAmount == input.GiftCardAmount ||
                    (this.GiftCardAmount != null &&
                    this.GiftCardAmount.Equals(input.GiftCardAmount))
                ) && 
                (
                    this.GiftCardCount == input.GiftCardCount ||
                    this.GiftCardCount.Equals(input.GiftCardCount)
                ) && 
                (
                    this.PreOrderDate == input.PreOrderDate ||
                    (this.PreOrderDate != null &&
                    this.PreOrderDate.Equals(input.PreOrderDate))
                ) && 
                (
                    this.PreOrderPurchase == input.PreOrderPurchase ||
                    this.PreOrderPurchase.Equals(input.PreOrderPurchase)
                ) && 
                (
                    this.ReorderItems == input.ReorderItems ||
                    this.ReorderItems.Equals(input.ReorderItems)
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
                hashCode = (hashCode * 59) + this.AddressMatch.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryAddressIndicator.GetHashCode();
                if (this.DeliveryEmail != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeliveryTimeframe.GetHashCode();
                if (this.GiftCardAmount != null)
                {
                    hashCode = (hashCode * 59) + this.GiftCardAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GiftCardCount.GetHashCode();
                if (this.PreOrderDate != null)
                {
                    hashCode = (hashCode * 59) + this.PreOrderDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PreOrderPurchase.GetHashCode();
                hashCode = (hashCode * 59) + this.ReorderItems.GetHashCode();
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