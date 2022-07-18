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
    /// SeatingProfile
    /// </summary>
    [DataContract(Name = "SeatingProfile")]
    public partial class SeatingProfile : IEquatable<SeatingProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeatingProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingProfile" /> class.
        /// </summary>
        /// <param name="seatProfileCode">seatProfileCode (required).</param>
        /// <param name="seatProfileDescription">seatProfileDescription.</param>
        /// <param name="details">details.</param>
        /// <param name="templates">templates.</param>
        public SeatingProfile(string seatProfileCode = default(string), string seatProfileDescription = default(string), List<SeatingProfileDetail> details = default(List<SeatingProfileDetail>), List<SeatingTemplate> templates = default(List<SeatingTemplate>))
        {
            // to ensure "seatProfileCode" is required (not null)
            if (seatProfileCode == null)
            {
                throw new ArgumentNullException("seatProfileCode is a required property for SeatingProfile and cannot be null");
            }
            this.SeatProfileCode = seatProfileCode;
            this.SeatProfileDescription = seatProfileDescription;
            this.Details = details;
            this.Templates = templates;
        }

        /// <summary>
        /// Gets or Sets SeatProfileCode
        /// </summary>
        [DataMember(Name = "seatProfileCode", IsRequired = true, EmitDefaultValue = false)]
        public string SeatProfileCode { get; set; }

        /// <summary>
        /// Gets or Sets SeatProfileDescription
        /// </summary>
        [DataMember(Name = "seatProfileDescription", EmitDefaultValue = false)]
        public string SeatProfileDescription { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<SeatingProfileDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name = "templates", EmitDefaultValue = false)]
        public List<SeatingTemplate> Templates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeatingProfile {\n");
            sb.Append("  SeatProfileCode: ").Append(SeatProfileCode).Append("\n");
            sb.Append("  SeatProfileDescription: ").Append(SeatProfileDescription).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
            return this.Equals(input as SeatingProfile);
        }

        /// <summary>
        /// Returns true if SeatingProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of SeatingProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeatingProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SeatProfileCode == input.SeatProfileCode ||
                    (this.SeatProfileCode != null &&
                    this.SeatProfileCode.Equals(input.SeatProfileCode))
                ) && 
                (
                    this.SeatProfileDescription == input.SeatProfileDescription ||
                    (this.SeatProfileDescription != null &&
                    this.SeatProfileDescription.Equals(input.SeatProfileDescription))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
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
                if (this.SeatProfileCode != null)
                {
                    hashCode = (hashCode * 59) + this.SeatProfileCode.GetHashCode();
                }
                if (this.SeatProfileDescription != null)
                {
                    hashCode = (hashCode * 59) + this.SeatProfileDescription.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Templates != null)
                {
                    hashCode = (hashCode * 59) + this.Templates.GetHashCode();
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
            // SeatProfileCode (string) maxLength
            if (this.SeatProfileCode != null && this.SeatProfileCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatProfileCode, length must be less than 10.", new [] { "SeatProfileCode" });
            }

            // SeatProfileCode (string) minLength
            if (this.SeatProfileCode != null && this.SeatProfileCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatProfileCode, length must be greater than 0.", new [] { "SeatProfileCode" });
            }

            // SeatProfileDescription (string) maxLength
            if (this.SeatProfileDescription != null && this.SeatProfileDescription.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatProfileDescription, length must be less than 50.", new [] { "SeatProfileDescription" });
            }

            // SeatProfileDescription (string) minLength
            if (this.SeatProfileDescription != null && this.SeatProfileDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatProfileDescription, length must be greater than 0.", new [] { "SeatProfileDescription" });
            }

            yield break;
        }
    }

}