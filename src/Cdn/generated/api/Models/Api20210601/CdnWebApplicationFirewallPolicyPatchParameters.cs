// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Properties required to update a CdnWebApplicationFirewallPolicy.</summary>
    public partial class CdnWebApplicationFirewallPolicyPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersTags _tag;

        /// <summary>CdnWebApplicationFirewallPolicy tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.CdnWebApplicationFirewallPolicyPatchParametersTags()); set => this._tag = value; }

        /// <summary>
        /// Creates an new <see cref="CdnWebApplicationFirewallPolicyPatchParameters" /> instance.
        /// </summary>
        public CdnWebApplicationFirewallPolicyPatchParameters()
        {

        }
    }
    /// Properties required to update a CdnWebApplicationFirewallPolicy.
    public partial interface ICdnWebApplicationFirewallPolicyPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>CdnWebApplicationFirewallPolicy tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CdnWebApplicationFirewallPolicy tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersTags Tag { get; set; }

    }
    /// Properties required to update a CdnWebApplicationFirewallPolicy.
    internal partial interface ICdnWebApplicationFirewallPolicyPatchParametersInternal

    {
        /// <summary>CdnWebApplicationFirewallPolicy tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnWebApplicationFirewallPolicyPatchParametersTags Tag { get; set; }

    }
}