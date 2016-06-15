// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SnowballTokenFilterLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SnowballTokenFilterLanguage
    {
        [EnumMember(Value = "Armenian")]
        Armenian,
        [EnumMember(Value = "Basque")]
        Basque,
        [EnumMember(Value = "Catalan")]
        Catalan,
        [EnumMember(Value = "Danish")]
        Danish,
        [EnumMember(Value = "Dutch")]
        Dutch,
        [EnumMember(Value = "English")]
        English,
        [EnumMember(Value = "Finnish")]
        Finnish,
        [EnumMember(Value = "French")]
        French,
        [EnumMember(Value = "German")]
        German,
        [EnumMember(Value = "German2")]
        German2,
        [EnumMember(Value = "Hungarian")]
        Hungarian,
        [EnumMember(Value = "Italian")]
        Italian,
        [EnumMember(Value = "Kp")]
        Kp,
        [EnumMember(Value = "Lovins")]
        Lovins,
        [EnumMember(Value = "Norwegian")]
        Norwegian,
        [EnumMember(Value = "Porter")]
        Porter,
        [EnumMember(Value = "Portuguese")]
        Portuguese,
        [EnumMember(Value = "Romanian")]
        Romanian,
        [EnumMember(Value = "Russian")]
        Russian,
        [EnumMember(Value = "Spanish")]
        Spanish,
        [EnumMember(Value = "Swedish")]
        Swedish,
        [EnumMember(Value = "Turkish")]
        Turkish
    }
}