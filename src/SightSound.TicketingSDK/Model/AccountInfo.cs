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
    /// AccountInfo
    /// </summary>
    [DataContract(Name = "AccountInfo")]
    public partial class AccountInfo : IEquatable<AccountInfo>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccountAgeIndicator
        /// </summary>
        [DataMember(Name = "accountAgeIndicator", EmitDefaultValue = false)]
        public AccountAgeIndicatorEnum? AccountAgeIndicator { get; set; }

        /// <summary>
        /// Gets or Sets AccountChangeIndicator
        /// </summary>
        [DataMember(Name = "accountChangeIndicator", EmitDefaultValue = false)]
        public AccountChangeIndicatorEnum? AccountChangeIndicator { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddressUsageIndicator
        /// </summary>
        [DataMember(Name = "deliveryAddressUsageIndicator", EmitDefaultValue = false)]
        public DeliveryAddressUsageIndicatorEnum? DeliveryAddressUsageIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PasswordChangeIndicator
        /// </summary>
        [DataMember(Name = "passwordChangeIndicator", EmitDefaultValue = false)]
        public PasswordChangeIndicatorEnum? PasswordChangeIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountIndicator
        /// </summary>
        [DataMember(Name = "paymentAccountIndicator", EmitDefaultValue = false)]
        public PaymentAccountIndicatorEnum? PaymentAccountIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo" /> class.
        /// </summary>
        /// <param name="accountAgeIndicator">accountAgeIndicator.</param>
        /// <param name="accountChangeDate">accountChangeDate.</param>
        /// <param name="accountChangeIndicator">accountChangeIndicator.</param>
        /// <param name="accountCreationDate">accountCreationDate.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="addCardAttemptsDay">addCardAttemptsDay.</param>
        /// <param name="deliveryAddressUsageDate">deliveryAddressUsageDate.</param>
        /// <param name="deliveryAddressUsageIndicator">deliveryAddressUsageIndicator.</param>
        /// <param name="homePhone">homePhone.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="passwordChangeDate">passwordChangeDate.</param>
        /// <param name="passwordChangeIndicator">passwordChangeIndicator.</param>
        /// <param name="pastTransactionsDay">pastTransactionsDay.</param>
        /// <param name="pastTransactionsYear">pastTransactionsYear.</param>
        /// <param name="paymentAccountAge">paymentAccountAge.</param>
        /// <param name="paymentAccountIndicator">paymentAccountIndicator.</param>
        /// <param name="purchasesLast6Months">purchasesLast6Months.</param>
        /// <param name="suspiciousActivity">suspiciousActivity.</param>
        /// <param name="workPhone">workPhone.</param>
        public AccountInfo(AccountAgeIndicatorEnum? accountAgeIndicator = default(AccountAgeIndicatorEnum?), DateTime accountChangeDate = default(DateTime), AccountChangeIndicatorEnum? accountChangeIndicator = default(AccountChangeIndicatorEnum?), DateTime accountCreationDate = default(DateTime), AccountTypeEnum? accountType = default(AccountTypeEnum?), int addCardAttemptsDay = default(int), DateTime deliveryAddressUsageDate = default(DateTime), DeliveryAddressUsageIndicatorEnum? deliveryAddressUsageIndicator = default(DeliveryAddressUsageIndicatorEnum?), string homePhone = default(string), string mobilePhone = default(string), DateTime passwordChangeDate = default(DateTime), PasswordChangeIndicatorEnum? passwordChangeIndicator = default(PasswordChangeIndicatorEnum?), int pastTransactionsDay = default(int), int pastTransactionsYear = default(int), DateTime paymentAccountAge = default(DateTime), PaymentAccountIndicatorEnum? paymentAccountIndicator = default(PaymentAccountIndicatorEnum?), int purchasesLast6Months = default(int), bool suspiciousActivity = default(bool), string workPhone = default(string))
        {
            this.AccountAgeIndicator = accountAgeIndicator;
            this.AccountChangeDate = accountChangeDate;
            this.AccountChangeIndicator = accountChangeIndicator;
            this.AccountCreationDate = accountCreationDate;
            this.AccountType = accountType;
            this.AddCardAttemptsDay = addCardAttemptsDay;
            this.DeliveryAddressUsageDate = deliveryAddressUsageDate;
            this.DeliveryAddressUsageIndicator = deliveryAddressUsageIndicator;
            this.HomePhone = homePhone;
            this.MobilePhone = mobilePhone;
            this.PasswordChangeDate = passwordChangeDate;
            this.PasswordChangeIndicator = passwordChangeIndicator;
            this.PastTransactionsDay = pastTransactionsDay;
            this.PastTransactionsYear = pastTransactionsYear;
            this.PaymentAccountAge = paymentAccountAge;
            this.PaymentAccountIndicator = paymentAccountIndicator;
            this.PurchasesLast6Months = purchasesLast6Months;
            this.SuspiciousActivity = suspiciousActivity;
            this.WorkPhone = workPhone;
        }

        /// <summary>
        /// Gets or Sets AccountChangeDate
        /// </summary>
        [DataMember(Name = "accountChangeDate", EmitDefaultValue = false)]
        public DateTime AccountChangeDate { get; set; }

        /// <summary>
        /// Gets or Sets AccountCreationDate
        /// </summary>
        [DataMember(Name = "accountCreationDate", EmitDefaultValue = false)]
        public DateTime AccountCreationDate { get; set; }

        /// <summary>
        /// Gets or Sets AddCardAttemptsDay
        /// </summary>
        [DataMember(Name = "addCardAttemptsDay", EmitDefaultValue = false)]
        public int AddCardAttemptsDay { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddressUsageDate
        /// </summary>
        [DataMember(Name = "deliveryAddressUsageDate", EmitDefaultValue = false)]
        public DateTime DeliveryAddressUsageDate { get; set; }

        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>
        [DataMember(Name = "homePhone", EmitDefaultValue = false)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets PasswordChangeDate
        /// </summary>
        [DataMember(Name = "passwordChangeDate", EmitDefaultValue = false)]
        public DateTime PasswordChangeDate { get; set; }

        /// <summary>
        /// Gets or Sets PastTransactionsDay
        /// </summary>
        [DataMember(Name = "pastTransactionsDay", EmitDefaultValue = false)]
        public int PastTransactionsDay { get; set; }

        /// <summary>
        /// Gets or Sets PastTransactionsYear
        /// </summary>
        [DataMember(Name = "pastTransactionsYear", EmitDefaultValue = false)]
        public int PastTransactionsYear { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountAge
        /// </summary>
        [DataMember(Name = "paymentAccountAge", EmitDefaultValue = false)]
        public DateTime PaymentAccountAge { get; set; }

        /// <summary>
        /// Gets or Sets PurchasesLast6Months
        /// </summary>
        [DataMember(Name = "purchasesLast6Months", EmitDefaultValue = false)]
        public int PurchasesLast6Months { get; set; }

        /// <summary>
        /// Gets or Sets SuspiciousActivity
        /// </summary>
        [DataMember(Name = "suspiciousActivity", EmitDefaultValue = true)]
        public bool SuspiciousActivity { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>
        [DataMember(Name = "workPhone", EmitDefaultValue = false)]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  AccountAgeIndicator: ").Append(AccountAgeIndicator).Append("\n");
            sb.Append("  AccountChangeDate: ").Append(AccountChangeDate).Append("\n");
            sb.Append("  AccountChangeIndicator: ").Append(AccountChangeIndicator).Append("\n");
            sb.Append("  AccountCreationDate: ").Append(AccountCreationDate).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AddCardAttemptsDay: ").Append(AddCardAttemptsDay).Append("\n");
            sb.Append("  DeliveryAddressUsageDate: ").Append(DeliveryAddressUsageDate).Append("\n");
            sb.Append("  DeliveryAddressUsageIndicator: ").Append(DeliveryAddressUsageIndicator).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  PasswordChangeDate: ").Append(PasswordChangeDate).Append("\n");
            sb.Append("  PasswordChangeIndicator: ").Append(PasswordChangeIndicator).Append("\n");
            sb.Append("  PastTransactionsDay: ").Append(PastTransactionsDay).Append("\n");
            sb.Append("  PastTransactionsYear: ").Append(PastTransactionsYear).Append("\n");
            sb.Append("  PaymentAccountAge: ").Append(PaymentAccountAge).Append("\n");
            sb.Append("  PaymentAccountIndicator: ").Append(PaymentAccountIndicator).Append("\n");
            sb.Append("  PurchasesLast6Months: ").Append(PurchasesLast6Months).Append("\n");
            sb.Append("  SuspiciousActivity: ").Append(SuspiciousActivity).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
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
            return this.Equals(input as AccountInfo);
        }

        /// <summary>
        /// Returns true if AccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountAgeIndicator == input.AccountAgeIndicator ||
                    this.AccountAgeIndicator.Equals(input.AccountAgeIndicator)
                ) && 
                (
                    this.AccountChangeDate == input.AccountChangeDate ||
                    (this.AccountChangeDate != null &&
                    this.AccountChangeDate.Equals(input.AccountChangeDate))
                ) && 
                (
                    this.AccountChangeIndicator == input.AccountChangeIndicator ||
                    this.AccountChangeIndicator.Equals(input.AccountChangeIndicator)
                ) && 
                (
                    this.AccountCreationDate == input.AccountCreationDate ||
                    (this.AccountCreationDate != null &&
                    this.AccountCreationDate.Equals(input.AccountCreationDate))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.AddCardAttemptsDay == input.AddCardAttemptsDay ||
                    this.AddCardAttemptsDay.Equals(input.AddCardAttemptsDay)
                ) && 
                (
                    this.DeliveryAddressUsageDate == input.DeliveryAddressUsageDate ||
                    (this.DeliveryAddressUsageDate != null &&
                    this.DeliveryAddressUsageDate.Equals(input.DeliveryAddressUsageDate))
                ) && 
                (
                    this.DeliveryAddressUsageIndicator == input.DeliveryAddressUsageIndicator ||
                    this.DeliveryAddressUsageIndicator.Equals(input.DeliveryAddressUsageIndicator)
                ) && 
                (
                    this.HomePhone == input.HomePhone ||
                    (this.HomePhone != null &&
                    this.HomePhone.Equals(input.HomePhone))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.PasswordChangeDate == input.PasswordChangeDate ||
                    (this.PasswordChangeDate != null &&
                    this.PasswordChangeDate.Equals(input.PasswordChangeDate))
                ) && 
                (
                    this.PasswordChangeIndicator == input.PasswordChangeIndicator ||
                    this.PasswordChangeIndicator.Equals(input.PasswordChangeIndicator)
                ) && 
                (
                    this.PastTransactionsDay == input.PastTransactionsDay ||
                    this.PastTransactionsDay.Equals(input.PastTransactionsDay)
                ) && 
                (
                    this.PastTransactionsYear == input.PastTransactionsYear ||
                    this.PastTransactionsYear.Equals(input.PastTransactionsYear)
                ) && 
                (
                    this.PaymentAccountAge == input.PaymentAccountAge ||
                    (this.PaymentAccountAge != null &&
                    this.PaymentAccountAge.Equals(input.PaymentAccountAge))
                ) && 
                (
                    this.PaymentAccountIndicator == input.PaymentAccountIndicator ||
                    this.PaymentAccountIndicator.Equals(input.PaymentAccountIndicator)
                ) && 
                (
                    this.PurchasesLast6Months == input.PurchasesLast6Months ||
                    this.PurchasesLast6Months.Equals(input.PurchasesLast6Months)
                ) && 
                (
                    this.SuspiciousActivity == input.SuspiciousActivity ||
                    this.SuspiciousActivity.Equals(input.SuspiciousActivity)
                ) && 
                (
                    this.WorkPhone == input.WorkPhone ||
                    (this.WorkPhone != null &&
                    this.WorkPhone.Equals(input.WorkPhone))
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
                hashCode = (hashCode * 59) + this.AccountAgeIndicator.GetHashCode();
                if (this.AccountChangeDate != null)
                {
                    hashCode = (hashCode * 59) + this.AccountChangeDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountChangeIndicator.GetHashCode();
                if (this.AccountCreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.AccountCreationDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                hashCode = (hashCode * 59) + this.AddCardAttemptsDay.GetHashCode();
                if (this.DeliveryAddressUsageDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddressUsageDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeliveryAddressUsageIndicator.GetHashCode();
                if (this.HomePhone != null)
                {
                    hashCode = (hashCode * 59) + this.HomePhone.GetHashCode();
                }
                if (this.MobilePhone != null)
                {
                    hashCode = (hashCode * 59) + this.MobilePhone.GetHashCode();
                }
                if (this.PasswordChangeDate != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordChangeDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PasswordChangeIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.PastTransactionsDay.GetHashCode();
                hashCode = (hashCode * 59) + this.PastTransactionsYear.GetHashCode();
                if (this.PaymentAccountAge != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccountAge.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentAccountIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.PurchasesLast6Months.GetHashCode();
                hashCode = (hashCode * 59) + this.SuspiciousActivity.GetHashCode();
                if (this.WorkPhone != null)
                {
                    hashCode = (hashCode * 59) + this.WorkPhone.GetHashCode();
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
