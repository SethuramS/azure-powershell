// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{

    /// <summary>
    /// Defines values for ApiManagementSkuCapacityScaleType.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiManagementSkuCapacityScaleType
    {
        [System.Runtime.Serialization.EnumMember(Value = "Automatic")]
        Automatic,
        [System.Runtime.Serialization.EnumMember(Value = "Manual")]
        Manual,
        [System.Runtime.Serialization.EnumMember(Value = "None")]
        None
    }
    internal static class ApiManagementSkuCapacityScaleTypeEnumExtension
    {
        internal static string ToSerializedValue(this ApiManagementSkuCapacityScaleType? value)
        {
            return value == null ? null : ((ApiManagementSkuCapacityScaleType)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this ApiManagementSkuCapacityScaleType value)
        {
            switch( value )
            {
                case ApiManagementSkuCapacityScaleType.Automatic:
                    return "Automatic";
                case ApiManagementSkuCapacityScaleType.Manual:
                    return "Manual";
                case ApiManagementSkuCapacityScaleType.None:
                    return "None";
            }
            return null;
        }
        internal static ApiManagementSkuCapacityScaleType? ParseApiManagementSkuCapacityScaleType(this string value)
        {
            switch( value )
            {
                case "Automatic":
                    return ApiManagementSkuCapacityScaleType.Automatic;
                case "Manual":
                    return ApiManagementSkuCapacityScaleType.Manual;
                case "None":
                    return ApiManagementSkuCapacityScaleType.None;
            }
            return null;
        }
    }
}