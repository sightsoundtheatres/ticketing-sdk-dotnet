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
    /// Defines SdkInterfaceEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SdkInterfaceEnum
    {
        /// <summary>
        /// Enum Html for value: html
        /// </summary>
        [EnumMember(Value = "html")]
        Html = 1,

        /// <summary>
        /// Enum Native for value: native
        /// </summary>
        [EnumMember(Value = "native")]
        Native = 2,

        /// <summary>
        /// Enum Both for value: both
        /// </summary>
        [EnumMember(Value = "both")]
        Both = 3

    }

}
