// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The routes that specify the endpoints used for login and logout requests.</summary>
    public partial class LoginRoutes :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ILoginRoutes,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ILoginRoutesInternal
    {

        /// <summary>Backing field for <see cref="LogoutEndpoint" /> property.</summary>
        private string _logoutEndpoint;

        /// <summary>The endpoint at which a logout request should be made.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string LogoutEndpoint { get => this._logoutEndpoint; set => this._logoutEndpoint = value; }

        /// <summary>Creates an new <see cref="LoginRoutes" /> instance.</summary>
        public LoginRoutes()
        {

        }
    }
    /// The routes that specify the endpoints used for login and logout requests.
    public partial interface ILoginRoutes :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The endpoint at which a logout request should be made.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint at which a logout request should be made.",
        SerializedName = @"logoutEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string LogoutEndpoint { get; set; }

    }
    /// The routes that specify the endpoints used for login and logout requests.
    internal partial interface ILoginRoutesInternal

    {
        /// <summary>The endpoint at which a logout request should be made.</summary>
        string LogoutEndpoint { get; set; }

    }
}