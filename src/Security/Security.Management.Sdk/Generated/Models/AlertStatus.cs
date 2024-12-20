// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{

    /// <summary>
    /// Defines values for AlertStatus.
    /// </summary>


    public static class AlertStatus
    {
        /// <summary>
        /// An alert which doesn't specify a value is assigned the status 'Active'
        /// </summary>
        public const string Active = "Active";
        /// <summary>
        /// An alert which is in handling state
        /// </summary>
        public const string InProgress = "InProgress";
        /// <summary>
        /// Alert closed after handling
        /// </summary>
        public const string Resolved = "Resolved";
        /// <summary>
        /// Alert dismissed as false positive
        /// </summary>
        public const string Dismissed = "Dismissed";
    }
}