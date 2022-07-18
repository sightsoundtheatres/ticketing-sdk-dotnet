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
    /// OrderItemPriceResponse
    /// </summary>
    [DataContract(Name = "OrderItemPriceResponse")]
    public partial class OrderItemPriceResponse : IEquatable<OrderItemPriceResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ItemType? Type { get; set; }

        /// <summary>
        /// Gets or Sets ItemStatus
        /// </summary>
        [DataMember(Name = "itemStatus", EmitDefaultValue = false)]
        public OrderItemStatus? ItemStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemPriceResponse" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="itemNumber">itemNumber.</param>
        /// <param name="subtotalPrice">subtotalPrice.</param>
        /// <param name="totalDiscount">totalDiscount.</param>
        /// <param name="itemStatus">itemStatus.</param>
        /// <param name="bus">bus.</param>
        /// <param name="busCount">busCount.</param>
        public OrderItemPriceResponse(ItemType? type = default(ItemType?), long orderNumber = default(long), int itemNumber = default(int), decimal subtotalPrice = default(decimal), decimal totalDiscount = default(decimal), OrderItemStatus? itemStatus = default(OrderItemStatus?), bool bus = default(bool), int busCount = default(int))
        {
            this.Type = type;
            this.OrderNumber = orderNumber;
            this.ItemNumber = itemNumber;
            this.SubtotalPrice = subtotalPrice;
            this.TotalDiscount = totalDiscount;
            this.ItemStatus = itemStatus;
            this.Bus = bus;
            this.BusCount = busCount;
        }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public long OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets ItemNumber
        /// </summary>
        [DataMember(Name = "itemNumber", EmitDefaultValue = false)]
        public int ItemNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubtotalPrice
        /// </summary>
        [DataMember(Name = "subtotalPrice", EmitDefaultValue = false)]
        public decimal SubtotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscount
        /// </summary>
        [DataMember(Name = "totalDiscount", EmitDefaultValue = false)]
        public decimal TotalDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Bus
        /// </summary>
        [DataMember(Name = "bus", EmitDefaultValue = true)]
        public bool Bus { get; set; }

        /// <summary>
        /// Gets or Sets BusCount
        /// </summary>
        [DataMember(Name = "busCount", EmitDefaultValue = false)]
        public int BusCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderItemPriceResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  SubtotalPrice: ").Append(SubtotalPrice).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  ItemStatus: ").Append(ItemStatus).Append("\n");
            sb.Append("  Bus: ").Append(Bus).Append("\n");
            sb.Append("  BusCount: ").Append(BusCount).Append("\n");
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
            return this.Equals(input as OrderItemPriceResponse);
        }

        /// <summary>
        /// Returns true if OrderItemPriceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemPriceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemPriceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    this.OrderNumber.Equals(input.OrderNumber)
                ) && 
                (
                    this.ItemNumber == input.ItemNumber ||
                    this.ItemNumber.Equals(input.ItemNumber)
                ) && 
                (
                    this.SubtotalPrice == input.SubtotalPrice ||
                    this.SubtotalPrice.Equals(input.SubtotalPrice)
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    this.TotalDiscount.Equals(input.TotalDiscount)
                ) && 
                (
                    this.ItemStatus == input.ItemStatus ||
                    this.ItemStatus.Equals(input.ItemStatus)
                ) && 
                (
                    this.Bus == input.Bus ||
                    this.Bus.Equals(input.Bus)
                ) && 
                (
                    this.BusCount == input.BusCount ||
                    this.BusCount.Equals(input.BusCount)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.SubtotalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalDiscount.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.Bus.GetHashCode();
                hashCode = (hashCode * 59) + this.BusCount.GetHashCode();
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