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
    /// Defines TaxJurisdictionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxJurisdictionType
    {
        /// <summary>
        /// Enum ET for value: ET
        /// </summary>
        [EnumMember(Value = "ET")]
        ET = 1,

        /// <summary>
        /// Enum MO for value: MO
        /// </summary>
        [EnumMember(Value = "MO")]
        MO = 2,

        /// <summary>
        /// Enum PA for value: PA
        /// </summary>
        [EnumMember(Value = "PA")]
        PA = 3

    }

}
