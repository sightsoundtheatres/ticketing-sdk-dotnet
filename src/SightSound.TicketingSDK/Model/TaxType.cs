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
    /// Defines TaxType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxType
    {
        /// <summary>
        /// Enum EN for value: EN
        /// </summary>
        [EnumMember(Value = "EN")]
        EN = 1,

        /// <summary>
        /// Enum XC for value: XC
        /// </summary>
        [EnumMember(Value = "XC")]
        XC = 2,

        /// <summary>
        /// Enum SC for value: SC
        /// </summary>
        [EnumMember(Value = "SC")]
        SC = 3,

        /// <summary>
        /// Enum SP for value: SP
        /// </summary>
        [EnumMember(Value = "SP")]
        SP = 4,

        /// <summary>
        /// Enum SH for value: SH
        /// </summary>
        [EnumMember(Value = "SH")]
        SH = 5,

        /// <summary>
        /// Enum PT for value: PT
        /// </summary>
        [EnumMember(Value = "PT")]
        PT = 6

    }

}
