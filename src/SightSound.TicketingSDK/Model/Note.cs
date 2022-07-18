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
    /// Note
    /// </summary>
    [DataContract(Name = "Note")]
    public partial class Note : IEquatable<Note>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets NoteType
        /// </summary>
        [DataMember(Name = "noteType", EmitDefaultValue = false)]
        public NoteType? NoteType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="noteId">noteId.</param>
        /// <param name="noteType">noteType.</param>
        /// <param name="noteDate">noteDate.</param>
        /// <param name="agent">agent.</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="customerNumber">customerNumber.</param>
        /// <param name="customer">customer.</param>
        /// <param name="note">note.</param>
        /// <param name="eventCode">eventCode.</param>
        /// <param name="itemNumber">itemNumber.</param>
        /// <param name="active">active.</param>
        /// <param name="deleteUserId">deleteUserId.</param>
        /// <param name="deleteDate">deleteDate.</param>
        /// <param name="order">order.</param>
        public Note(long noteId = default(long), NoteType? noteType = default(NoteType?), DateTime noteDate = default(DateTime), string agent = default(string), long orderNumber = default(long), long customerNumber = default(long), Customer customer = default(Customer), string note = default(string), string eventCode = default(string), int itemNumber = default(int), bool active = default(bool), string deleteUserId = default(string), DateTime deleteDate = default(DateTime), Order order = default(Order))
        {
            this.NoteId = noteId;
            this.NoteType = noteType;
            this.NoteDate = noteDate;
            this.Agent = agent;
            this.OrderNumber = orderNumber;
            this.CustomerNumber = customerNumber;
            this.Customer = customer;
            this._Note = note;
            this.EventCode = eventCode;
            this.ItemNumber = itemNumber;
            this.Active = active;
            this.DeleteUserId = deleteUserId;
            this.DeleteDate = deleteDate;
            this.Order = order;
        }

        /// <summary>
        /// Gets or Sets NoteId
        /// </summary>
        [DataMember(Name = "noteId", EmitDefaultValue = false)]
        public long NoteId { get; set; }

        /// <summary>
        /// Gets or Sets NoteDate
        /// </summary>
        [DataMember(Name = "noteDate", EmitDefaultValue = false)]
        public DateTime NoteDate { get; set; }

        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name = "agent", EmitDefaultValue = false)]
        public string Agent { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public long OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [DataMember(Name = "customerNumber", EmitDefaultValue = false)]
        public long CustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or Sets _Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string _Note { get; set; }

        /// <summary>
        /// Gets or Sets EventCode
        /// </summary>
        [DataMember(Name = "eventCode", EmitDefaultValue = false)]
        [Obsolete]
        public string EventCode { get; set; }

        /// <summary>
        /// Gets or Sets ItemNumber
        /// </summary>
        [DataMember(Name = "itemNumber", EmitDefaultValue = false)]
        [Obsolete]
        public int ItemNumber { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets DeleteUserId
        /// </summary>
        [DataMember(Name = "deleteUserId", EmitDefaultValue = false)]
        public string DeleteUserId { get; set; }

        /// <summary>
        /// Gets or Sets DeleteDate
        /// </summary>
        [DataMember(Name = "deleteDate", EmitDefaultValue = false)]
        public DateTime DeleteDate { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public Order Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Note {\n");
            sb.Append("  NoteId: ").Append(NoteId).Append("\n");
            sb.Append("  NoteType: ").Append(NoteType).Append("\n");
            sb.Append("  NoteDate: ").Append(NoteDate).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  _Note: ").Append(_Note).Append("\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DeleteUserId: ").Append(DeleteUserId).Append("\n");
            sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as Note);
        }

        /// <summary>
        /// Returns true if Note instances are equal
        /// </summary>
        /// <param name="input">Instance of Note to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Note input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoteId == input.NoteId ||
                    this.NoteId.Equals(input.NoteId)
                ) && 
                (
                    this.NoteType == input.NoteType ||
                    this.NoteType.Equals(input.NoteType)
                ) && 
                (
                    this.NoteDate == input.NoteDate ||
                    (this.NoteDate != null &&
                    this.NoteDate.Equals(input.NoteDate))
                ) && 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    this.OrderNumber.Equals(input.OrderNumber)
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    this.CustomerNumber.Equals(input.CustomerNumber)
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this._Note == input._Note ||
                    (this._Note != null &&
                    this._Note.Equals(input._Note))
                ) && 
                (
                    this.EventCode == input.EventCode ||
                    (this.EventCode != null &&
                    this.EventCode.Equals(input.EventCode))
                ) && 
                (
                    this.ItemNumber == input.ItemNumber ||
                    this.ItemNumber.Equals(input.ItemNumber)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.DeleteUserId == input.DeleteUserId ||
                    (this.DeleteUserId != null &&
                    this.DeleteUserId.Equals(input.DeleteUserId))
                ) && 
                (
                    this.DeleteDate == input.DeleteDate ||
                    (this.DeleteDate != null &&
                    this.DeleteDate.Equals(input.DeleteDate))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                hashCode = (hashCode * 59) + this.NoteId.GetHashCode();
                hashCode = (hashCode * 59) + this.NoteType.GetHashCode();
                if (this.NoteDate != null)
                {
                    hashCode = (hashCode * 59) + this.NoteDate.GetHashCode();
                }
                if (this.Agent != null)
                {
                    hashCode = (hashCode * 59) + this.Agent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomerNumber.GetHashCode();
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this._Note != null)
                {
                    hashCode = (hashCode * 59) + this._Note.GetHashCode();
                }
                if (this.EventCode != null)
                {
                    hashCode = (hashCode * 59) + this.EventCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.DeleteUserId != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteUserId.GetHashCode();
                }
                if (this.DeleteDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteDate.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
            // Agent (string) maxLength
            if (this.Agent != null && this.Agent.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Agent, length must be less than 50.", new [] { "Agent" });
            }

            // Agent (string) minLength
            if (this.Agent != null && this.Agent.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Agent, length must be greater than 0.", new [] { "Agent" });
            }

            // _Note (string) maxLength
            if (this._Note != null && this._Note.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Note, length must be less than 4000.", new [] { "_Note" });
            }

            // _Note (string) minLength
            if (this._Note != null && this._Note.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Note, length must be greater than 0.", new [] { "_Note" });
            }

            // EventCode (string) maxLength
            if (this.EventCode != null && this.EventCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventCode, length must be less than 10.", new [] { "EventCode" });
            }

            // EventCode (string) minLength
            if (this.EventCode != null && this.EventCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventCode, length must be greater than 0.", new [] { "EventCode" });
            }

            // DeleteUserId (string) maxLength
            if (this.DeleteUserId != null && this.DeleteUserId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeleteUserId, length must be less than 50.", new [] { "DeleteUserId" });
            }

            // DeleteUserId (string) minLength
            if (this.DeleteUserId != null && this.DeleteUserId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeleteUserId, length must be greater than 0.", new [] { "DeleteUserId" });
            }

            yield break;
        }
    }

}
