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
    /// SpecialAssociatedEvent
    /// </summary>
    [DataContract(Name = "SpecialAssociatedEvent")]
    public partial class SpecialAssociatedEvent : IEquatable<SpecialAssociatedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialAssociatedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpecialAssociatedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialAssociatedEvent" /> class.
        /// </summary>
        /// <param name="specialCode">specialCode (required).</param>
        /// <param name="eventCode">eventCode (required).</param>
        /// <param name="specialRangeStartDate">specialRangeStartDate (required).</param>
        /// <param name="specialRangeEndDate">specialRangeEndDate (required).</param>
        /// <param name="comboEventNumber">comboEventNumber.</param>
        /// <param name="special">special.</param>
        public SpecialAssociatedEvent(string specialCode = default(string), string eventCode = default(string), DateTime specialRangeStartDate = default(DateTime), DateTime specialRangeEndDate = default(DateTime), int comboEventNumber = default(int), Special special = default(Special))
        {
            // to ensure "specialCode" is required (not null)
            if (specialCode == null)
            {
                throw new ArgumentNullException("specialCode is a required property for SpecialAssociatedEvent and cannot be null");
            }
            this.SpecialCode = specialCode;
            // to ensure "eventCode" is required (not null)
            if (eventCode == null)
            {
                throw new ArgumentNullException("eventCode is a required property for SpecialAssociatedEvent and cannot be null");
            }
            this.EventCode = eventCode;
            this.SpecialRangeStartDate = specialRangeStartDate;
            this.SpecialRangeEndDate = specialRangeEndDate;
            this.ComboEventNumber = comboEventNumber;
            this.Special = special;
        }

        /// <summary>
        /// Gets or Sets SpecialCode
        /// </summary>
        [DataMember(Name = "specialCode", IsRequired = true, EmitDefaultValue = false)]
        public string SpecialCode { get; set; }

        /// <summary>
        /// Gets or Sets EventCode
        /// </summary>
        [DataMember(Name = "eventCode", IsRequired = true, EmitDefaultValue = false)]
        public string EventCode { get; set; }

        /// <summary>
        /// Gets or Sets SpecialRangeStartDate
        /// </summary>
        [DataMember(Name = "specialRangeStartDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime SpecialRangeStartDate { get; set; }

        /// <summary>
        /// Gets or Sets SpecialRangeEndDate
        /// </summary>
        [DataMember(Name = "specialRangeEndDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime SpecialRangeEndDate { get; set; }

        /// <summary>
        /// Gets or Sets ComboEventNumber
        /// </summary>
        [DataMember(Name = "comboEventNumber", EmitDefaultValue = false)]
        public int ComboEventNumber { get; set; }

        /// <summary>
        /// Gets or Sets Special
        /// </summary>
        [DataMember(Name = "special", EmitDefaultValue = false)]
        public Special Special { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpecialAssociatedEvent {\n");
            sb.Append("  SpecialCode: ").Append(SpecialCode).Append("\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  SpecialRangeStartDate: ").Append(SpecialRangeStartDate).Append("\n");
            sb.Append("  SpecialRangeEndDate: ").Append(SpecialRangeEndDate).Append("\n");
            sb.Append("  ComboEventNumber: ").Append(ComboEventNumber).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
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
            return this.Equals(input as SpecialAssociatedEvent);
        }

        /// <summary>
        /// Returns true if SpecialAssociatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecialAssociatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecialAssociatedEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SpecialCode == input.SpecialCode ||
                    (this.SpecialCode != null &&
                    this.SpecialCode.Equals(input.SpecialCode))
                ) && 
                (
                    this.EventCode == input.EventCode ||
                    (this.EventCode != null &&
                    this.EventCode.Equals(input.EventCode))
                ) && 
                (
                    this.SpecialRangeStartDate == input.SpecialRangeStartDate ||
                    (this.SpecialRangeStartDate != null &&
                    this.SpecialRangeStartDate.Equals(input.SpecialRangeStartDate))
                ) && 
                (
                    this.SpecialRangeEndDate == input.SpecialRangeEndDate ||
                    (this.SpecialRangeEndDate != null &&
                    this.SpecialRangeEndDate.Equals(input.SpecialRangeEndDate))
                ) && 
                (
                    this.ComboEventNumber == input.ComboEventNumber ||
                    this.ComboEventNumber.Equals(input.ComboEventNumber)
                ) && 
                (
                    this.Special == input.Special ||
                    (this.Special != null &&
                    this.Special.Equals(input.Special))
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
                if (this.SpecialCode != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialCode.GetHashCode();
                }
                if (this.EventCode != null)
                {
                    hashCode = (hashCode * 59) + this.EventCode.GetHashCode();
                }
                if (this.SpecialRangeStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialRangeStartDate.GetHashCode();
                }
                if (this.SpecialRangeEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialRangeEndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ComboEventNumber.GetHashCode();
                if (this.Special != null)
                {
                    hashCode = (hashCode * 59) + this.Special.GetHashCode();
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
            // SpecialCode (string) maxLength
            if (this.SpecialCode != null && this.SpecialCode.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialCode, length must be less than 40.", new [] { "SpecialCode" });
            }

            // SpecialCode (string) minLength
            if (this.SpecialCode != null && this.SpecialCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialCode, length must be greater than 0.", new [] { "SpecialCode" });
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

            yield break;
        }
    }

}