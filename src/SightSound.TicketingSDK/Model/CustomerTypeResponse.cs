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
    /// Defines CustomerTypeResponse
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerTypeResponse
    {
        /// <summary>
        /// Enum CONSUMER for value: CONSUMER
        /// </summary>
        [EnumMember(Value = "CONSUMER")]
        CONSUMER = 1,

        /// <summary>
        /// Enum ORGANIZATION for value: ORGANIZATION
        /// </summary>
        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION = 2,

        /// <summary>
        /// Enum RESELLER for value: RESELLER
        /// </summary>
        [EnumMember(Value = "RESELLER")]
        RESELLER = 3,

        /// <summary>
        /// Enum EMPLOYEE for value: EMPLOYEE
        /// </summary>
        [EnumMember(Value = "EMPLOYEE")]
        EMPLOYEE = 4

    }

}
