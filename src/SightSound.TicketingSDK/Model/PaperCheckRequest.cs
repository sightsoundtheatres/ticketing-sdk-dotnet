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
    /// PaperCheckRequest
    /// </summary>
    [DataContract(Name = "PaperCheckRequest")]
    public partial class PaperCheckRequest : IEquatable<PaperCheckRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaperCheckRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaperCheckRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaperCheckRequest" /> class.
        /// </summary>
        /// <param name="checkAmount">checkAmount (required).</param>
        /// <param name="checkNumber">checkNumber (required).</param>
        /// <param name="ach">ach.</param>
        public PaperCheckRequest(decimal checkAmount = default(decimal), string checkNumber = default(string), bool ach = default(bool))
        {
            this.CheckAmount = checkAmount;
            // to ensure "checkNumber" is required (not null)
            if (checkNumber == null)
            {
                throw new ArgumentNullException("checkNumber is a required property for PaperCheckRequest and cannot be null");
            }
            this.CheckNumber = checkNumber;
            this.Ach = ach;
        }

        /// <summary>
        /// Gets or Sets CheckAmount
        /// </summary>
        [DataMember(Name = "checkAmount", IsRequired = true, EmitDefaultValue = false)]
        public decimal CheckAmount { get; set; }

        /// <summary>
        /// Gets or Sets CheckNumber
        /// </summary>
        [DataMember(Name = "checkNumber", IsRequired = true, EmitDefaultValue = false)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Gets or Sets Ach
        /// </summary>
        [DataMember(Name = "ach", EmitDefaultValue = true)]
        public bool Ach { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaperCheckRequest {\n");
            sb.Append("  CheckAmount: ").Append(CheckAmount).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  Ach: ").Append(Ach).Append("\n");
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
            return this.Equals(input as PaperCheckRequest);
        }

        /// <summary>
        /// Returns true if PaperCheckRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaperCheckRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaperCheckRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckAmount == input.CheckAmount ||
                    this.CheckAmount.Equals(input.CheckAmount)
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    (this.CheckNumber != null &&
                    this.CheckNumber.Equals(input.CheckNumber))
                ) && 
                (
                    this.Ach == input.Ach ||
                    this.Ach.Equals(input.Ach)
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
                hashCode = (hashCode * 59) + this.CheckAmount.GetHashCode();
                if (this.CheckNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CheckNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ach.GetHashCode();
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
            // CheckNumber (string) maxLength
            if (this.CheckNumber != null && this.CheckNumber.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, length must be less than 300.", new [] { "CheckNumber" });
            }

            // CheckNumber (string) minLength
            if (this.CheckNumber != null && this.CheckNumber.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, length must be greater than 0.", new [] { "CheckNumber" });
            }

            yield break;
        }
    }

}
