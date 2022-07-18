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
    /// FeeItem
    /// </summary>
    [DataContract(Name = "FeeItem")]
    public partial class FeeItem : IEquatable<FeeItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FeeKindCode
        /// </summary>
        [DataMember(Name = "feeKindCode", IsRequired = true, EmitDefaultValue = false)]
        public FeeKind FeeKindCode { get; set; }

        /// <summary>
        /// Gets or Sets FeeTypeCode
        /// </summary>
        [DataMember(Name = "feeTypeCode", IsRequired = true, EmitDefaultValue = false)]
        public FeeType FeeTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets LogActivity
        /// </summary>
        [DataMember(Name = "logActivity", EmitDefaultValue = false)]
        public ActivityType? LogActivity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItem" /> class.
        /// </summary>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="itemNumber">itemNumber.</param>
        /// <param name="feeKindCode">feeKindCode (required).</param>
        /// <param name="feeCount">feeCount.</param>
        /// <param name="feePerCount">feePerCount.</param>
        /// <param name="flatFee">flatFee.</param>
        /// <param name="totalFee">totalFee (required).</param>
        /// <param name="feeId">feeId.</param>
        /// <param name="feeTypeCode">feeTypeCode (required).</param>
        /// <param name="feeDate">feeDate (required).</param>
        /// <param name="active">active.</param>
        /// <param name="addUserId">addUserId.</param>
        /// <param name="percent">percent.</param>
        /// <param name="percentFee">percentFee.</param>
        /// <param name="percentAmount">percentAmount.</param>
        /// <param name="orderItem">orderItem.</param>
        /// <param name="logChanges">logChanges.</param>
        /// <param name="logActivity">logActivity.</param>
        public FeeItem(long orderNumber = default(long), int itemNumber = default(int), FeeKind feeKindCode = default(FeeKind), int feeCount = default(int), decimal feePerCount = default(decimal), decimal flatFee = default(decimal), decimal totalFee = default(decimal), long feeId = default(long), FeeType feeTypeCode = default(FeeType), DateTime feeDate = default(DateTime), bool active = default(bool), string addUserId = default(string), decimal percent = default(decimal), decimal percentFee = default(decimal), decimal percentAmount = default(decimal), OrderItem orderItem = default(OrderItem), bool logChanges = default(bool), ActivityType? logActivity = default(ActivityType?))
        {
            this.FeeKindCode = feeKindCode;
            this.TotalFee = totalFee;
            this.FeeTypeCode = feeTypeCode;
            this.FeeDate = feeDate;
            this.OrderNumber = orderNumber;
            this.ItemNumber = itemNumber;
            this.FeeCount = feeCount;
            this.FeePerCount = feePerCount;
            this.FlatFee = flatFee;
            this.FeeId = feeId;
            this.Active = active;
            this.AddUserId = addUserId;
            this.Percent = percent;
            this.PercentFee = percentFee;
            this.PercentAmount = percentAmount;
            this.OrderItem = orderItem;
            this.LogChanges = logChanges;
            this.LogActivity = logActivity;
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
        /// Gets or Sets FeeCount
        /// </summary>
        [DataMember(Name = "feeCount", EmitDefaultValue = false)]
        public int FeeCount { get; set; }

        /// <summary>
        /// Gets or Sets FeePerCount
        /// </summary>
        [DataMember(Name = "feePerCount", EmitDefaultValue = false)]
        public decimal FeePerCount { get; set; }

        /// <summary>
        /// Gets or Sets FlatFee
        /// </summary>
        [DataMember(Name = "flatFee", EmitDefaultValue = false)]
        public decimal FlatFee { get; set; }

        /// <summary>
        /// Gets or Sets TotalFee
        /// </summary>
        [DataMember(Name = "totalFee", IsRequired = true, EmitDefaultValue = false)]
        public decimal TotalFee { get; set; }

        /// <summary>
        /// Gets or Sets FeeId
        /// </summary>
        [DataMember(Name = "feeId", EmitDefaultValue = false)]
        public long FeeId { get; set; }

        /// <summary>
        /// Gets or Sets FeeDate
        /// </summary>
        [DataMember(Name = "feeDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime FeeDate { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        [Obsolete]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets AddUserId
        /// </summary>
        [DataMember(Name = "addUserId", EmitDefaultValue = false)]
        public string AddUserId { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// Gets or Sets PercentFee
        /// </summary>
        [DataMember(Name = "percentFee", EmitDefaultValue = false)]
        public decimal PercentFee { get; set; }

        /// <summary>
        /// Gets or Sets PercentAmount
        /// </summary>
        [DataMember(Name = "percentAmount", EmitDefaultValue = false)]
        public decimal PercentAmount { get; set; }

        /// <summary>
        /// Gets or Sets OrderItem
        /// </summary>
        [DataMember(Name = "orderItem", EmitDefaultValue = false)]
        public OrderItem OrderItem { get; set; }

        /// <summary>
        /// Gets or Sets LogChanges
        /// </summary>
        [DataMember(Name = "logChanges", EmitDefaultValue = true)]
        public bool LogChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeeItem {\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  FeeKindCode: ").Append(FeeKindCode).Append("\n");
            sb.Append("  FeeCount: ").Append(FeeCount).Append("\n");
            sb.Append("  FeePerCount: ").Append(FeePerCount).Append("\n");
            sb.Append("  FlatFee: ").Append(FlatFee).Append("\n");
            sb.Append("  TotalFee: ").Append(TotalFee).Append("\n");
            sb.Append("  FeeId: ").Append(FeeId).Append("\n");
            sb.Append("  FeeTypeCode: ").Append(FeeTypeCode).Append("\n");
            sb.Append("  FeeDate: ").Append(FeeDate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AddUserId: ").Append(AddUserId).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  PercentFee: ").Append(PercentFee).Append("\n");
            sb.Append("  PercentAmount: ").Append(PercentAmount).Append("\n");
            sb.Append("  OrderItem: ").Append(OrderItem).Append("\n");
            sb.Append("  LogChanges: ").Append(LogChanges).Append("\n");
            sb.Append("  LogActivity: ").Append(LogActivity).Append("\n");
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
            return this.Equals(input as FeeItem);
        }

        /// <summary>
        /// Returns true if FeeItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeItem input)
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
                    this.ItemNumber == input.ItemNumber ||
                    this.ItemNumber.Equals(input.ItemNumber)
                ) && 
                (
                    this.FeeKindCode == input.FeeKindCode ||
                    this.FeeKindCode.Equals(input.FeeKindCode)
                ) && 
                (
                    this.FeeCount == input.FeeCount ||
                    this.FeeCount.Equals(input.FeeCount)
                ) && 
                (
                    this.FeePerCount == input.FeePerCount ||
                    this.FeePerCount.Equals(input.FeePerCount)
                ) && 
                (
                    this.FlatFee == input.FlatFee ||
                    this.FlatFee.Equals(input.FlatFee)
                ) && 
                (
                    this.TotalFee == input.TotalFee ||
                    this.TotalFee.Equals(input.TotalFee)
                ) && 
                (
                    this.FeeId == input.FeeId ||
                    this.FeeId.Equals(input.FeeId)
                ) && 
                (
                    this.FeeTypeCode == input.FeeTypeCode ||
                    this.FeeTypeCode.Equals(input.FeeTypeCode)
                ) && 
                (
                    this.FeeDate == input.FeeDate ||
                    (this.FeeDate != null &&
                    this.FeeDate.Equals(input.FeeDate))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AddUserId == input.AddUserId ||
                    (this.AddUserId != null &&
                    this.AddUserId.Equals(input.AddUserId))
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.PercentFee == input.PercentFee ||
                    this.PercentFee.Equals(input.PercentFee)
                ) && 
                (
                    this.PercentAmount == input.PercentAmount ||
                    this.PercentAmount.Equals(input.PercentAmount)
                ) && 
                (
                    this.OrderItem == input.OrderItem ||
                    (this.OrderItem != null &&
                    this.OrderItem.Equals(input.OrderItem))
                ) && 
                (
                    this.LogChanges == input.LogChanges ||
                    this.LogChanges.Equals(input.LogChanges)
                ) && 
                (
                    this.LogActivity == input.LogActivity ||
                    this.LogActivity.Equals(input.LogActivity)
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
                hashCode = (hashCode * 59) + this.ItemNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.FeeKindCode.GetHashCode();
                hashCode = (hashCode * 59) + this.FeeCount.GetHashCode();
                hashCode = (hashCode * 59) + this.FeePerCount.GetHashCode();
                hashCode = (hashCode * 59) + this.FlatFee.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalFee.GetHashCode();
                hashCode = (hashCode * 59) + this.FeeId.GetHashCode();
                hashCode = (hashCode * 59) + this.FeeTypeCode.GetHashCode();
                if (this.FeeDate != null)
                {
                    hashCode = (hashCode * 59) + this.FeeDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AddUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AddUserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentFee.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentAmount.GetHashCode();
                if (this.OrderItem != null)
                {
                    hashCode = (hashCode * 59) + this.OrderItem.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogChanges.GetHashCode();
                hashCode = (hashCode * 59) + this.LogActivity.GetHashCode();
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
            // AddUserId (string) maxLength
            if (this.AddUserId != null && this.AddUserId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddUserId, length must be less than 50.", new [] { "AddUserId" });
            }

            // AddUserId (string) minLength
            if (this.AddUserId != null && this.AddUserId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddUserId, length must be greater than 0.", new [] { "AddUserId" });
            }

            // Percent (decimal) minimum
            if (this.Percent < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value greater than or equal to 0.", new [] { "Percent" });
            }

            // PercentFee (decimal) minimum
            if (this.PercentFee < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PercentFee, must be a value greater than or equal to 0.", new [] { "PercentFee" });
            }

            // PercentAmount (decimal) minimum
            if (this.PercentAmount < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PercentAmount, must be a value greater than or equal to 0.", new [] { "PercentAmount" });
            }

            yield break;
        }
    }

}