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
    /// Defines AdditionalContactRole
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdditionalContactRole
    {
        /// <summary>
        /// Enum MANAGER for value: MANAGER
        /// </summary>
        [EnumMember(Value = "MANAGER")]
        MANAGER = 1,

        /// <summary>
        /// Enum ACCOUNTING for value: ACCOUNTING
        /// </summary>
        [EnumMember(Value = "ACCOUNTING")]
        ACCOUNTING = 2,

        /// <summary>
        /// Enum MARKETING for value: MARKETING
        /// </summary>
        [EnumMember(Value = "MARKETING")]
        MARKETING = 3,

        /// <summary>
        /// Enum GENERAL for value: GENERAL
        /// </summary>
        [EnumMember(Value = "GENERAL")]
        GENERAL = 4

    }

}