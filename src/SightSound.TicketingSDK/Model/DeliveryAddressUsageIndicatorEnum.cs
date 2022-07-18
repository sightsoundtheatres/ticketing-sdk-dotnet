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
    /// Defines DeliveryAddressUsageIndicatorEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryAddressUsageIndicatorEnum
    {
        /// <summary>
        /// Enum ThisTransaction for value: thisTransaction
        /// </summary>
        [EnumMember(Value = "thisTransaction")]
        ThisTransaction = 1,

        /// <summary>
        /// Enum LessThan30Days for value: lessThan30Days
        /// </summary>
        [EnumMember(Value = "lessThan30Days")]
        LessThan30Days = 2,

        /// <summary>
        /// Enum From30To60Days for value: from30To60Days
        /// </summary>
        [EnumMember(Value = "from30To60Days")]
        From30To60Days = 3,

        /// <summary>
        /// Enum MoreThan60Days for value: moreThan60Days
        /// </summary>
        [EnumMember(Value = "moreThan60Days")]
        MoreThan60Days = 4

    }

}
