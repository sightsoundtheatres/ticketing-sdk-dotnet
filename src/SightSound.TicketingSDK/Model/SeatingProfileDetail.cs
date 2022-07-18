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
    /// SeatingProfileDetail
    /// </summary>
    [DataContract(Name = "SeatingProfileDetail")]
    public partial class SeatingProfileDetail : IEquatable<SeatingProfileDetail>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SeatTypeCode
        /// </summary>
        [DataMember(Name = "seatTypeCode", IsRequired = true, EmitDefaultValue = false)]
        public SeatType SeatTypeCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingProfileDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeatingProfileDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingProfileDetail" /> class.
        /// </summary>
        /// <param name="seatTypeCode">seatTypeCode (required).</param>
        /// <param name="dollarsOff">dollarsOff (required).</param>
        /// <param name="dayOfShow">dayOfShow (required).</param>
        /// <param name="warningText">warningText.</param>
        /// <param name="countBucketCode">countBucketCode (required).</param>
        /// <param name="seatProfileCode">seatProfileCode (required).</param>
        /// <param name="seatDisplayChar">seatDisplayChar (required).</param>
        /// <param name="profile">profile.</param>
        public SeatingProfileDetail(SeatType seatTypeCode = default(SeatType), decimal dollarsOff = default(decimal), string dayOfShow = default(string), string warningText = default(string), string countBucketCode = default(string), string seatProfileCode = default(string), string seatDisplayChar = default(string), SeatingProfile profile = default(SeatingProfile))
        {
            this.SeatTypeCode = seatTypeCode;
            this.DollarsOff = dollarsOff;
            // to ensure "dayOfShow" is required (not null)
            if (dayOfShow == null)
            {
                throw new ArgumentNullException("dayOfShow is a required property for SeatingProfileDetail and cannot be null");
            }
            this.DayOfShow = dayOfShow;
            // to ensure "countBucketCode" is required (not null)
            if (countBucketCode == null)
            {
                throw new ArgumentNullException("countBucketCode is a required property for SeatingProfileDetail and cannot be null");
            }
            this.CountBucketCode = countBucketCode;
            // to ensure "seatProfileCode" is required (not null)
            if (seatProfileCode == null)
            {
                throw new ArgumentNullException("seatProfileCode is a required property for SeatingProfileDetail and cannot be null");
            }
            this.SeatProfileCode = seatProfileCode;
            // to ensure "seatDisplayChar" is required (not null)
            if (seatDisplayChar == null)
            {
                throw new ArgumentNullException("seatDisplayChar is a required property for SeatingProfileDetail and cannot be null");
            }
            this.SeatDisplayChar = seatDisplayChar;
            this.WarningText = warningText;
            this.Profile = profile;
        }

        /// <summary>
        /// Gets or Sets DollarsOff
        /// </summary>
        [DataMember(Name = "dollarsOff", IsRequired = true, EmitDefaultValue = false)]
        public decimal DollarsOff { get; set; }

        /// <summary>
        /// Gets or Sets DayOfShow
        /// </summary>
        [DataMember(Name = "dayOfShow", IsRequired = true, EmitDefaultValue = false)]
        public string DayOfShow { get; set; }

        /// <summary>
        /// Gets or Sets WarningText
        /// </summary>
        [DataMember(Name = "warningText", EmitDefaultValue = false)]
        public string WarningText { get; set; }

        /// <summary>
        /// Gets or Sets CountBucketCode
        /// </summary>
        [DataMember(Name = "countBucketCode", IsRequired = true, EmitDefaultValue = false)]
        public string CountBucketCode { get; set; }

        /// <summary>
        /// Gets or Sets SeatProfileCode
        /// </summary>
        [DataMember(Name = "seatProfileCode", IsRequired = true, EmitDefaultValue = false)]
        public string SeatProfileCode { get; set; }

        /// <summary>
        /// Gets or Sets SeatDisplayChar
        /// </summary>
        [DataMember(Name = "seatDisplayChar", IsRequired = true, EmitDefaultValue = false)]
        public string SeatDisplayChar { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public SeatingProfile Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeatingProfileDetail {\n");
            sb.Append("  SeatTypeCode: ").Append(SeatTypeCode).Append("\n");
            sb.Append("  DollarsOff: ").Append(DollarsOff).Append("\n");
            sb.Append("  DayOfShow: ").Append(DayOfShow).Append("\n");
            sb.Append("  WarningText: ").Append(WarningText).Append("\n");
            sb.Append("  CountBucketCode: ").Append(CountBucketCode).Append("\n");
            sb.Append("  SeatProfileCode: ").Append(SeatProfileCode).Append("\n");
            sb.Append("  SeatDisplayChar: ").Append(SeatDisplayChar).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as SeatingProfileDetail);
        }

        /// <summary>
        /// Returns true if SeatingProfileDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SeatingProfileDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeatingProfileDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SeatTypeCode == input.SeatTypeCode ||
                    this.SeatTypeCode.Equals(input.SeatTypeCode)
                ) && 
                (
                    this.DollarsOff == input.DollarsOff ||
                    this.DollarsOff.Equals(input.DollarsOff)
                ) && 
                (
                    this.DayOfShow == input.DayOfShow ||
                    (this.DayOfShow != null &&
                    this.DayOfShow.Equals(input.DayOfShow))
                ) && 
                (
                    this.WarningText == input.WarningText ||
                    (this.WarningText != null &&
                    this.WarningText.Equals(input.WarningText))
                ) && 
                (
                    this.CountBucketCode == input.CountBucketCode ||
                    (this.CountBucketCode != null &&
                    this.CountBucketCode.Equals(input.CountBucketCode))
                ) && 
                (
                    this.SeatProfileCode == input.SeatProfileCode ||
                    (this.SeatProfileCode != null &&
                    this.SeatProfileCode.Equals(input.SeatProfileCode))
                ) && 
                (
                    this.SeatDisplayChar == input.SeatDisplayChar ||
                    (this.SeatDisplayChar != null &&
                    this.SeatDisplayChar.Equals(input.SeatDisplayChar))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                hashCode = (hashCode * 59) + this.SeatTypeCode.GetHashCode();
                hashCode = (hashCode * 59) + this.DollarsOff.GetHashCode();
                if (this.DayOfShow != null)
                {
                    hashCode = (hashCode * 59) + this.DayOfShow.GetHashCode();
                }
                if (this.WarningText != null)
                {
                    hashCode = (hashCode * 59) + this.WarningText.GetHashCode();
                }
                if (this.CountBucketCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountBucketCode.GetHashCode();
                }
                if (this.SeatProfileCode != null)
                {
                    hashCode = (hashCode * 59) + this.SeatProfileCode.GetHashCode();
                }
                if (this.SeatDisplayChar != null)
                {
                    hashCode = (hashCode * 59) + this.SeatDisplayChar.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
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
            // DayOfShow (string) maxLength
            if (this.DayOfShow != null && this.DayOfShow.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayOfShow, length must be less than 1.", new [] { "DayOfShow" });
            }

            // DayOfShow (string) minLength
            if (this.DayOfShow != null && this.DayOfShow.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayOfShow, length must be greater than 0.", new [] { "DayOfShow" });
            }

            // WarningText (string) maxLength
            if (this.WarningText != null && this.WarningText.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarningText, length must be less than 60.", new [] { "WarningText" });
            }

            // WarningText (string) minLength
            if (this.WarningText != null && this.WarningText.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarningText, length must be greater than 0.", new [] { "WarningText" });
            }

            // CountBucketCode (string) maxLength
            if (this.CountBucketCode != null && this.CountBucketCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountBucketCode, length must be less than 10.", new [] { "CountBucketCode" });
            }

            // CountBucketCode (string) minLength
            if (this.CountBucketCode != null && this.CountBucketCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountBucketCode, length must be greater than 0.", new [] { "CountBucketCode" });
            }

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

            // SeatDisplayChar (string) maxLength
            if (this.SeatDisplayChar != null && this.SeatDisplayChar.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatDisplayChar, length must be less than 1.", new [] { "SeatDisplayChar" });
            }

            // SeatDisplayChar (string) minLength
            if (this.SeatDisplayChar != null && this.SeatDisplayChar.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatDisplayChar, length must be greater than 0.", new [] { "SeatDisplayChar" });
            }

            yield break;
        }
    }

}