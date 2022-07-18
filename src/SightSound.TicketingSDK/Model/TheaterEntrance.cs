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
    /// Defines TheaterEntrance
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TheaterEntrance
    {
        /// <summary>
        /// Enum BRECS for value: BR_ECS
        /// </summary>
        [EnumMember(Value = "BR_ECS")]
        BRECS = 1,

        /// <summary>
        /// Enum BREBS for value: BR_EBS
        /// </summary>
        [EnumMember(Value = "BR_EBS")]
        BREBS = 2,

        /// <summary>
        /// Enum BREB for value: BR_EB
        /// </summary>
        [EnumMember(Value = "BR_EB")]
        BREB = 3,

        /// <summary>
        /// Enum BREC for value: BR_EC
        /// </summary>
        [EnumMember(Value = "BR_EC")]
        BREC = 4,

        /// <summary>
        /// Enum SSEB for value: SS_EB
        /// </summary>
        [EnumMember(Value = "SS_EB")]
        SSEB = 5,

        /// <summary>
        /// Enum SSEC for value: SS_EC
        /// </summary>
        [EnumMember(Value = "SS_EC")]
        SSEC = 6,

        /// <summary>
        /// Enum SSEAS for value: SS_EAS
        /// </summary>
        [EnumMember(Value = "SS_EAS")]
        SSEAS = 7,

        /// <summary>
        /// Enum SSEDS for value: SS_EDS
        /// </summary>
        [EnumMember(Value = "SS_EDS")]
        SSEDS = 8

    }

}
