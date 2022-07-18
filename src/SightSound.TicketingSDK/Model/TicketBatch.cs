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
    /// Defines TicketBatch
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketBatch
    {
        /// <summary>
        /// Enum AGENT for value: AGENT
        /// </summary>
        [EnumMember(Value = "AGENT")]
        AGENT = 1,

        /// <summary>
        /// Enum ETICKET for value: ETICKET
        /// </summary>
        [EnumMember(Value = "ETICKET")]
        ETICKET = 2,

        /// <summary>
        /// Enum HELD for value: HELD
        /// </summary>
        [EnumMember(Value = "HELD")]
        HELD = 3

    }

}
