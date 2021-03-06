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
    /// CartRequest
    /// </summary>
    [DataContract(Name = "CartRequest")]
    public partial class CartRequest : IEquatable<CartRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TicketBatch
        /// </summary>
        [DataMember(Name = "ticketBatch", EmitDefaultValue = false)]
        public TicketBatch? TicketBatch { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartRequest" /> class.
        /// </summary>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="promoCode">promoCode.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="items">items.</param>
        /// <param name="customer">customer.</param>
        /// <param name="ticketBatch">ticketBatch.</param>
        /// <param name="ticketDelivery">ticketDelivery.</param>
        public CartRequest(long orderNumber = default(long), string promoCode = default(string), string groupName = default(string), string referenceNumber = default(string), List<OrderItemPriceRequest> items = default(List<OrderItemPriceRequest>), OrderCustomerRequest customer = default(OrderCustomerRequest), TicketBatch? ticketBatch = default(TicketBatch?), OrderTicketDeliveryRequest ticketDelivery = default(OrderTicketDeliveryRequest))
        {
            this.OrderNumber = orderNumber;
            this.PromoCode = promoCode;
            this.GroupName = groupName;
            this.ReferenceNumber = referenceNumber;
            this.Items = items;
            this.Customer = customer;
            this.TicketBatch = ticketBatch;
            this.TicketDelivery = ticketDelivery;
        }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public long OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets PromoCode
        /// </summary>
        [DataMember(Name = "promoCode", EmitDefaultValue = false)]
        public string PromoCode { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderItemPriceRequest> Items { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public OrderCustomerRequest Customer { get; set; }

        /// <summary>
        /// Gets or Sets TicketDelivery
        /// </summary>
        [DataMember(Name = "ticketDelivery", EmitDefaultValue = false)]
        public OrderTicketDeliveryRequest TicketDelivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartRequest {\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  PromoCode: ").Append(PromoCode).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  TicketBatch: ").Append(TicketBatch).Append("\n");
            sb.Append("  TicketDelivery: ").Append(TicketDelivery).Append("\n");
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
            return this.Equals(input as CartRequest);
        }

        /// <summary>
        /// Returns true if CartRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderNumber == input.OrderNumber ||
                    this.OrderNumber.Equals(input.OrderNumber)
                ) && 
                (
                    this.PromoCode == input.PromoCode ||
                    (this.PromoCode != null &&
                    this.PromoCode.Equals(input.PromoCode))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.TicketBatch == input.TicketBatch ||
                    this.TicketBatch.Equals(input.TicketBatch)
                ) && 
                (
                    this.TicketDelivery == input.TicketDelivery ||
                    (this.TicketDelivery != null &&
                    this.TicketDelivery.Equals(input.TicketDelivery))
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
                hashCode = (hashCode * 59) + this.OrderNumber.GetHashCode();
                if (this.PromoCode != null)
                {
                    hashCode = (hashCode * 59) + this.PromoCode.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.ReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNumber.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TicketBatch.GetHashCode();
                if (this.TicketDelivery != null)
                {
                    hashCode = (hashCode * 59) + this.TicketDelivery.GetHashCode();
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
            // GroupName (string) pattern
            Regex regexGroupName = new Regex(@"^[a-zA-Z0-9\\s\\-&]*", RegexOptions.CultureInvariant);
            if (false == regexGroupName.Match(this.GroupName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupName, must match a pattern of " + regexGroupName, new [] { "GroupName" });
            }

            yield break;
        }
    }

}
