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
    /// Defines FrequencyEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyEnum
    {
        /// <summary>
        /// Enum Adhoc for value: adhoc
        /// </summary>
        [EnumMember(Value = "adhoc")]
        Adhoc = 1,

        /// <summary>
        /// Enum Daily for value: daily
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily = 2,

        /// <summary>
        /// Enum Weekly for value: weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly = 3,

        /// <summary>
        /// Enum BiWeekly for value: biWeekly
        /// </summary>
        [EnumMember(Value = "biWeekly")]
        BiWeekly = 4,

        /// <summary>
        /// Enum Monthly for value: monthly
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly = 5,

        /// <summary>
        /// Enum Quarterly for value: quarterly
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly = 6,

        /// <summary>
        /// Enum HalfYearly for value: halfYearly
        /// </summary>
        [EnumMember(Value = "halfYearly")]
        HalfYearly = 7,

        /// <summary>
        /// Enum Yearly for value: yearly
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly = 8

    }

}