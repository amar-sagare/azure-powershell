// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>requiredResourceAccess</summary>
    public partial class MicrosoftGraphRequiredResourceAccess :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphRequiredResourceAccess,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphRequiredResourceAccessInternal
    {

        /// <summary>Backing field for <see cref="ResourceAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceAccess[] _resourceAccess;

        /// <summary>
        /// The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceAccess[] ResourceAccess { get => this._resourceAccess; set => this._resourceAccess = value; }

        /// <summary>Backing field for <see cref="ResourceAppId" /> property.</summary>
        private string _resourceAppId;

        /// <summary>
        /// The unique identifier for the resource that the application requires access to. This should be equal to the appId declared
        /// on the target resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ResourceAppId { get => this._resourceAppId; set => this._resourceAppId = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphRequiredResourceAccess" /> instance.</summary>
        public MicrosoftGraphRequiredResourceAccess()
        {

        }
    }
    /// requiredResourceAccess
    public partial interface IMicrosoftGraphRequiredResourceAccess :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.",
        SerializedName = @"resourceAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceAccess[] ResourceAccess { get; set; }
        /// <summary>
        /// The unique identifier for the resource that the application requires access to. This should be equal to the appId declared
        /// on the target resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.",
        SerializedName = @"resourceAppId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAppId { get; set; }

    }
    /// requiredResourceAccess
    internal partial interface IMicrosoftGraphRequiredResourceAccessInternal

    {
        /// <summary>
        /// The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceAccess[] ResourceAccess { get; set; }
        /// <summary>
        /// The unique identifier for the resource that the application requires access to. This should be equal to the appId declared
        /// on the target resource application.
        /// </summary>
        string ResourceAppId { get; set; }

    }
}