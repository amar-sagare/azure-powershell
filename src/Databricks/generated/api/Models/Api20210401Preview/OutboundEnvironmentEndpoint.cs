// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Egress endpoints which Workspace connects to for common purposes.</summary>
    public partial class OutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IOutboundEnvironmentEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IOutboundEnvironmentEndpointInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// The category of endpoints accessed by the Workspace, e.g. azure-storage, azure-mysql, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDependency[] _endpoint;

        /// <summary>The endpoints that Workspace connect to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDependency[] Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpoint" /> instance.</summary>
        public OutboundEnvironmentEndpoint()
        {

        }
    }
    /// Egress endpoints which Workspace connects to for common purposes.
    public partial interface IOutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The category of endpoints accessed by the Workspace, e.g. azure-storage, azure-mysql, etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The category of endpoints accessed by the Workspace, e.g. azure-storage, azure-mysql, etc.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The endpoints that Workspace connect to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoints that Workspace connect to",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDependency) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDependency[] Endpoint { get; set; }

    }
    /// Egress endpoints which Workspace connects to for common purposes.
    internal partial interface IOutboundEnvironmentEndpointInternal

    {
        /// <summary>
        /// The category of endpoints accessed by the Workspace, e.g. azure-storage, azure-mysql, etc.
        /// </summary>
        string Category { get; set; }
        /// <summary>The endpoints that Workspace connect to</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDependency[] Endpoint { get; set; }

    }
}