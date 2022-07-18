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
    /// Defines EmployeeBenefitType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmployeeBenefitType
    {
        /// <summary>
        /// Enum EMPDISC for value: EMPDISC
        /// </summary>
        [EnumMember(Value = "EMPDISC")]
        EMPDISC = 1,

        /// <summary>
        /// Enum EMPCOMP for value: EMPCOMP
        /// </summary>
        [EnumMember(Value = "EMPCOMP")]
        EMPCOMP = 2,

        /// <summary>
        /// Enum EMPDAY for value: EMPDAY
        /// </summary>
        [EnumMember(Value = "EMPDAY")]
        EMPDAY = 3,

        /// <summary>
        /// Enum TOUREMPCOMP for value: TOUR_EMPCOMP
        /// </summary>
        [EnumMember(Value = "TOUR_EMPCOMP")]
        TOUREMPCOMP = 4

    }

}