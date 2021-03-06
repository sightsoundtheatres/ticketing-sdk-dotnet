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
    /// Defines ShopperInteractionEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopperInteractionEnum
    {
        /// <summary>
        /// Enum Ecommerce for value: Ecommerce
        /// </summary>
        [EnumMember(Value = "Ecommerce")]
        Ecommerce = 1,

        /// <summary>
        /// Enum ContAuth for value: ContAuth
        /// </summary>
        [EnumMember(Value = "ContAuth")]
        ContAuth = 2,

        /// <summary>
        /// Enum Moto for value: Moto
        /// </summary>
        [EnumMember(Value = "Moto")]
        Moto = 3,

        /// <summary>
        /// Enum POS for value: POS
        /// </summary>
        [EnumMember(Value = "POS")]
        POS = 4

    }

}
