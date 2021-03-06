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
    /// SeatingTemplateSection
    /// </summary>
    [DataContract(Name = "SeatingTemplateSection")]
    public partial class SeatingTemplateSection : IEquatable<SeatingTemplateSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingTemplateSection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeatingTemplateSection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeatingTemplateSection" /> class.
        /// </summary>
        /// <param name="sectionCode">sectionCode (required).</param>
        /// <param name="sectionDescription">sectionDescription.</param>
        /// <param name="sectionCapacity">sectionCapacity.</param>
        /// <param name="seatingTemplateCode">seatingTemplateCode (required).</param>
        /// <param name="sectionLevel">sectionLevel.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="sectionLevelDescription">sectionLevelDescription.</param>
        /// <param name="sectionStairNote">sectionStairNote.</param>
        /// <param name="template">template.</param>
        /// <param name="seats">seats.</param>
        /// <param name="xcoordinate">xcoordinate.</param>
        /// <param name="ycoordinate">ycoordinate.</param>
        public SeatingTemplateSection(string sectionCode = default(string), string sectionDescription = default(string), int sectionCapacity = default(int), string seatingTemplateCode = default(string), string sectionLevel = default(string), int width = default(int), int height = default(int), string sectionLevelDescription = default(string), string sectionStairNote = default(string), SeatingTemplate template = default(SeatingTemplate), List<SeatingTemplateSectionSeat> seats = default(List<SeatingTemplateSectionSeat>), int xcoordinate = default(int), int ycoordinate = default(int))
        {
            // to ensure "sectionCode" is required (not null)
            if (sectionCode == null)
            {
                throw new ArgumentNullException("sectionCode is a required property for SeatingTemplateSection and cannot be null");
            }
            this.SectionCode = sectionCode;
            // to ensure "seatingTemplateCode" is required (not null)
            if (seatingTemplateCode == null)
            {
                throw new ArgumentNullException("seatingTemplateCode is a required property for SeatingTemplateSection and cannot be null");
            }
            this.SeatingTemplateCode = seatingTemplateCode;
            this.SectionDescription = sectionDescription;
            this.SectionCapacity = sectionCapacity;
            this.SectionLevel = sectionLevel;
            this.Width = width;
            this.Height = height;
            this.SectionLevelDescription = sectionLevelDescription;
            this.SectionStairNote = sectionStairNote;
            this.Template = template;
            this.Seats = seats;
            this.Xcoordinate = xcoordinate;
            this.Ycoordinate = ycoordinate;
        }

        /// <summary>
        /// Gets or Sets SectionCode
        /// </summary>
        [DataMember(Name = "sectionCode", IsRequired = true, EmitDefaultValue = false)]
        public string SectionCode { get; set; }

        /// <summary>
        /// Gets or Sets SectionDescription
        /// </summary>
        [DataMember(Name = "sectionDescription", EmitDefaultValue = false)]
        public string SectionDescription { get; set; }

        /// <summary>
        /// Gets or Sets SectionCapacity
        /// </summary>
        [DataMember(Name = "sectionCapacity", EmitDefaultValue = false)]
        public int SectionCapacity { get; set; }

        /// <summary>
        /// Gets or Sets SeatingTemplateCode
        /// </summary>
        [DataMember(Name = "seatingTemplateCode", IsRequired = true, EmitDefaultValue = false)]
        public string SeatingTemplateCode { get; set; }

        /// <summary>
        /// Gets or Sets SectionLevel
        /// </summary>
        [DataMember(Name = "sectionLevel", EmitDefaultValue = false)]
        public string SectionLevel { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets SectionLevelDescription
        /// </summary>
        [DataMember(Name = "sectionLevelDescription", EmitDefaultValue = false)]
        public string SectionLevelDescription { get; set; }

        /// <summary>
        /// Gets or Sets SectionStairNote
        /// </summary>
        [DataMember(Name = "sectionStairNote", EmitDefaultValue = false)]
        public string SectionStairNote { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public SeatingTemplate Template { get; set; }

        /// <summary>
        /// Gets or Sets Seats
        /// </summary>
        [DataMember(Name = "seats", EmitDefaultValue = false)]
        public List<SeatingTemplateSectionSeat> Seats { get; set; }

        /// <summary>
        /// Gets or Sets Xcoordinate
        /// </summary>
        [DataMember(Name = "xcoordinate", EmitDefaultValue = false)]
        public int Xcoordinate { get; set; }

        /// <summary>
        /// Gets or Sets Ycoordinate
        /// </summary>
        [DataMember(Name = "ycoordinate", EmitDefaultValue = false)]
        public int Ycoordinate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeatingTemplateSection {\n");
            sb.Append("  SectionCode: ").Append(SectionCode).Append("\n");
            sb.Append("  SectionDescription: ").Append(SectionDescription).Append("\n");
            sb.Append("  SectionCapacity: ").Append(SectionCapacity).Append("\n");
            sb.Append("  SeatingTemplateCode: ").Append(SeatingTemplateCode).Append("\n");
            sb.Append("  SectionLevel: ").Append(SectionLevel).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  SectionLevelDescription: ").Append(SectionLevelDescription).Append("\n");
            sb.Append("  SectionStairNote: ").Append(SectionStairNote).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
            sb.Append("  Xcoordinate: ").Append(Xcoordinate).Append("\n");
            sb.Append("  Ycoordinate: ").Append(Ycoordinate).Append("\n");
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
            return this.Equals(input as SeatingTemplateSection);
        }

        /// <summary>
        /// Returns true if SeatingTemplateSection instances are equal
        /// </summary>
        /// <param name="input">Instance of SeatingTemplateSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeatingTemplateSection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SectionCode == input.SectionCode ||
                    (this.SectionCode != null &&
                    this.SectionCode.Equals(input.SectionCode))
                ) && 
                (
                    this.SectionDescription == input.SectionDescription ||
                    (this.SectionDescription != null &&
                    this.SectionDescription.Equals(input.SectionDescription))
                ) && 
                (
                    this.SectionCapacity == input.SectionCapacity ||
                    this.SectionCapacity.Equals(input.SectionCapacity)
                ) && 
                (
                    this.SeatingTemplateCode == input.SeatingTemplateCode ||
                    (this.SeatingTemplateCode != null &&
                    this.SeatingTemplateCode.Equals(input.SeatingTemplateCode))
                ) && 
                (
                    this.SectionLevel == input.SectionLevel ||
                    (this.SectionLevel != null &&
                    this.SectionLevel.Equals(input.SectionLevel))
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.SectionLevelDescription == input.SectionLevelDescription ||
                    (this.SectionLevelDescription != null &&
                    this.SectionLevelDescription.Equals(input.SectionLevelDescription))
                ) && 
                (
                    this.SectionStairNote == input.SectionStairNote ||
                    (this.SectionStairNote != null &&
                    this.SectionStairNote.Equals(input.SectionStairNote))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Seats == input.Seats ||
                    this.Seats != null &&
                    input.Seats != null &&
                    this.Seats.SequenceEqual(input.Seats)
                ) && 
                (
                    this.Xcoordinate == input.Xcoordinate ||
                    this.Xcoordinate.Equals(input.Xcoordinate)
                ) && 
                (
                    this.Ycoordinate == input.Ycoordinate ||
                    this.Ycoordinate.Equals(input.Ycoordinate)
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
                if (this.SectionCode != null)
                {
                    hashCode = (hashCode * 59) + this.SectionCode.GetHashCode();
                }
                if (this.SectionDescription != null)
                {
                    hashCode = (hashCode * 59) + this.SectionDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SectionCapacity.GetHashCode();
                if (this.SeatingTemplateCode != null)
                {
                    hashCode = (hashCode * 59) + this.SeatingTemplateCode.GetHashCode();
                }
                if (this.SectionLevel != null)
                {
                    hashCode = (hashCode * 59) + this.SectionLevel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                if (this.SectionLevelDescription != null)
                {
                    hashCode = (hashCode * 59) + this.SectionLevelDescription.GetHashCode();
                }
                if (this.SectionStairNote != null)
                {
                    hashCode = (hashCode * 59) + this.SectionStairNote.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.Seats != null)
                {
                    hashCode = (hashCode * 59) + this.Seats.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Xcoordinate.GetHashCode();
                hashCode = (hashCode * 59) + this.Ycoordinate.GetHashCode();
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
            // SectionCode (string) maxLength
            if (this.SectionCode != null && this.SectionCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionCode, length must be less than 10.", new [] { "SectionCode" });
            }

            // SectionCode (string) minLength
            if (this.SectionCode != null && this.SectionCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionCode, length must be greater than 0.", new [] { "SectionCode" });
            }

            // SectionDescription (string) maxLength
            if (this.SectionDescription != null && this.SectionDescription.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionDescription, length must be less than 30.", new [] { "SectionDescription" });
            }

            // SectionDescription (string) minLength
            if (this.SectionDescription != null && this.SectionDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionDescription, length must be greater than 0.", new [] { "SectionDescription" });
            }

            // SeatingTemplateCode (string) maxLength
            if (this.SeatingTemplateCode != null && this.SeatingTemplateCode.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatingTemplateCode, length must be less than 30.", new [] { "SeatingTemplateCode" });
            }

            // SeatingTemplateCode (string) minLength
            if (this.SeatingTemplateCode != null && this.SeatingTemplateCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeatingTemplateCode, length must be greater than 0.", new [] { "SeatingTemplateCode" });
            }

            // SectionLevel (string) maxLength
            if (this.SectionLevel != null && this.SectionLevel.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionLevel, length must be less than 10.", new [] { "SectionLevel" });
            }

            // SectionLevel (string) minLength
            if (this.SectionLevel != null && this.SectionLevel.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionLevel, length must be greater than 0.", new [] { "SectionLevel" });
            }

            // SectionLevelDescription (string) maxLength
            if (this.SectionLevelDescription != null && this.SectionLevelDescription.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionLevelDescription, length must be less than 1000.", new [] { "SectionLevelDescription" });
            }

            // SectionLevelDescription (string) minLength
            if (this.SectionLevelDescription != null && this.SectionLevelDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionLevelDescription, length must be greater than 0.", new [] { "SectionLevelDescription" });
            }

            // SectionStairNote (string) maxLength
            if (this.SectionStairNote != null && this.SectionStairNote.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionStairNote, length must be less than 1000.", new [] { "SectionStairNote" });
            }

            // SectionStairNote (string) minLength
            if (this.SectionStairNote != null && this.SectionStairNote.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionStairNote, length must be greater than 0.", new [] { "SectionStairNote" });
            }

            yield break;
        }
    }

}
