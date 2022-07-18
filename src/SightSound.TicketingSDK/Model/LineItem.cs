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
    /// LineItem
    /// </summary>
    [DataContract(Name = "LineItem")]
    public partial class LineItem : IEquatable<LineItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name = "taxCategory", EmitDefaultValue = false)]
        public TaxCategoryEnum? TaxCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        /// <param name="amountExcludingTax">amountExcludingTax.</param>
        /// <param name="amountIncludingTax">amountIncludingTax.</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="taxPercentage">taxPercentage.</param>
        /// <param name="productUrl">productUrl.</param>
        /// <param name="imageUrl">imageUrl.</param>
        public LineItem(long amountExcludingTax = default(long), long amountIncludingTax = default(long), string description = default(string), string id = default(string), long quantity = default(long), long taxAmount = default(long), TaxCategoryEnum? taxCategory = default(TaxCategoryEnum?), long taxPercentage = default(long), string productUrl = default(string), string imageUrl = default(string))
        {
            this.AmountExcludingTax = amountExcludingTax;
            this.AmountIncludingTax = amountIncludingTax;
            this.Description = description;
            this.Id = id;
            this.Quantity = quantity;
            this.TaxAmount = taxAmount;
            this.TaxCategory = taxCategory;
            this.TaxPercentage = taxPercentage;
            this.ProductUrl = productUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Gets or Sets AmountExcludingTax
        /// </summary>
        [DataMember(Name = "amountExcludingTax", EmitDefaultValue = false)]
        public long AmountExcludingTax { get; set; }

        /// <summary>
        /// Gets or Sets AmountIncludingTax
        /// </summary>
        [DataMember(Name = "amountIncludingTax", EmitDefaultValue = false)]
        public long AmountIncludingTax { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public long TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercentage
        /// </summary>
        [DataMember(Name = "taxPercentage", EmitDefaultValue = false)]
        public long TaxPercentage { get; set; }

        /// <summary>
        /// Gets or Sets ProductUrl
        /// </summary>
        [DataMember(Name = "productUrl", EmitDefaultValue = false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
            sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountExcludingTax == input.AmountExcludingTax ||
                    this.AmountExcludingTax.Equals(input.AmountExcludingTax)
                ) && 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    this.TaxAmount.Equals(input.TaxAmount)
                ) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    this.TaxCategory.Equals(input.TaxCategory)
                ) && 
                (
                    this.TaxPercentage == input.TaxPercentage ||
                    this.TaxPercentage.Equals(input.TaxPercentage)
                ) && 
                (
                    this.ProductUrl == input.ProductUrl ||
                    (this.ProductUrl != null &&
                    this.ProductUrl.Equals(input.ProductUrl))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                hashCode = (hashCode * 59) + this.AmountExcludingTax.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountIncludingTax.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxCategory.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxPercentage.GetHashCode();
                if (this.ProductUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ProductUrl.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
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
