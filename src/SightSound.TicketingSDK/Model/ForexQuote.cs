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
    /// ForexQuote
    /// </summary>
    [DataContract(Name = "ForexQuote")]
    public partial class ForexQuote : IEquatable<ForexQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexQuote" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="interbank">interbank.</param>
        /// <param name="sell">sell.</param>
        /// <param name="buy">buy.</param>
        /// <param name="validTill">validTill.</param>
        /// <param name="basePoints">basePoints.</param>
        /// <param name="source">source.</param>
        /// <param name="signature">signature.</param>
        /// <param name="type">type.</param>
        /// <param name="baseAmount">baseAmount.</param>
        /// <param name="account">account.</param>
        /// <param name="accountType">accountType.</param>
        public ForexQuote(string reference = default(string), Amount interbank = default(Amount), Amount sell = default(Amount), Amount buy = default(Amount), DateTime validTill = default(DateTime), int basePoints = default(int), string source = default(string), string signature = default(string), string type = default(string), Amount baseAmount = default(Amount), string account = default(string), string accountType = default(string))
        {
            this.Reference = reference;
            this.Interbank = interbank;
            this.Sell = sell;
            this.Buy = buy;
            this.ValidTill = validTill;
            this.BasePoints = basePoints;
            this.Source = source;
            this.Signature = signature;
            this.Type = type;
            this.BaseAmount = baseAmount;
            this.Account = account;
            this.AccountType = accountType;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Interbank
        /// </summary>
        [DataMember(Name = "interbank", EmitDefaultValue = false)]
        public Amount Interbank { get; set; }

        /// <summary>
        /// Gets or Sets Sell
        /// </summary>
        [DataMember(Name = "sell", EmitDefaultValue = false)]
        public Amount Sell { get; set; }

        /// <summary>
        /// Gets or Sets Buy
        /// </summary>
        [DataMember(Name = "buy", EmitDefaultValue = false)]
        public Amount Buy { get; set; }

        /// <summary>
        /// Gets or Sets ValidTill
        /// </summary>
        [DataMember(Name = "validTill", EmitDefaultValue = false)]
        public DateTime ValidTill { get; set; }

        /// <summary>
        /// Gets or Sets BasePoints
        /// </summary>
        [DataMember(Name = "basePoints", EmitDefaultValue = false)]
        public int BasePoints { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets BaseAmount
        /// </summary>
        [DataMember(Name = "baseAmount", EmitDefaultValue = false)]
        public Amount BaseAmount { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForexQuote {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Interbank: ").Append(Interbank).Append("\n");
            sb.Append("  Sell: ").Append(Sell).Append("\n");
            sb.Append("  Buy: ").Append(Buy).Append("\n");
            sb.Append("  ValidTill: ").Append(ValidTill).Append("\n");
            sb.Append("  BasePoints: ").Append(BasePoints).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BaseAmount: ").Append(BaseAmount).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
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
            return this.Equals(input as ForexQuote);
        }

        /// <summary>
        /// Returns true if ForexQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ForexQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForexQuote input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Interbank == input.Interbank ||
                    (this.Interbank != null &&
                    this.Interbank.Equals(input.Interbank))
                ) && 
                (
                    this.Sell == input.Sell ||
                    (this.Sell != null &&
                    this.Sell.Equals(input.Sell))
                ) && 
                (
                    this.Buy == input.Buy ||
                    (this.Buy != null &&
                    this.Buy.Equals(input.Buy))
                ) && 
                (
                    this.ValidTill == input.ValidTill ||
                    (this.ValidTill != null &&
                    this.ValidTill.Equals(input.ValidTill))
                ) && 
                (
                    this.BasePoints == input.BasePoints ||
                    this.BasePoints.Equals(input.BasePoints)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BaseAmount == input.BaseAmount ||
                    (this.BaseAmount != null &&
                    this.BaseAmount.Equals(input.BaseAmount))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
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
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Interbank != null)
                {
                    hashCode = (hashCode * 59) + this.Interbank.GetHashCode();
                }
                if (this.Sell != null)
                {
                    hashCode = (hashCode * 59) + this.Sell.GetHashCode();
                }
                if (this.Buy != null)
                {
                    hashCode = (hashCode * 59) + this.Buy.GetHashCode();
                }
                if (this.ValidTill != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTill.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BasePoints.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.BaseAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BaseAmount.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
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
            yield break;
        }
    }

}
