// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.
    /// </summary>
    public partial class SharedPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Internal Acessors for PrivateLink</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourcePropertiesInternal.PrivateLink { get => (this._privateLink = this._privateLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference()); set { {_privateLink = value;} } }

        /// <summary>Backing field for <see cref="PrivateLink" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference _privateLink;

        /// <summary>The resource id of the resource the shared private link resource is for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference PrivateLink { get => (this._privateLink = this._privateLink ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference()); set => this._privateLink = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReferenceInternal)PrivateLink).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReferenceInternal)PrivateLink).Id = value ?? null; }

        /// <summary>Backing field for <see cref="PrivateLinkLocation" /> property.</summary>
        private string _privateLinkLocation;

        /// <summary>The location of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string PrivateLinkLocation { get => this._privateLinkLocation; set => this._privateLinkLocation = value; }

        /// <summary>Backing field for <see cref="RequestMessage" /> property.</summary>
        private string _requestMessage;

        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string RequestMessage { get => this._requestMessage; set => this._requestMessage = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? _status;

        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="SharedPrivateLinkResourceProperties" /> instance.</summary>
        public SharedPrivateLinkResourceProperties()
        {

        }
    }
    /// Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.
    public partial interface ISharedPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id from the provider of resource the shared private link resource is for.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkId { get; set; }
        /// <summary>The location of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the shared private link resource",
        SerializedName = @"privateLinkLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request message for requesting approval of the shared private link resource.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }
        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? Status { get; set; }

    }
    /// Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.
    internal partial interface ISharedPrivateLinkResourcePropertiesInternal

    {
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        string GroupId { get; set; }
        /// <summary>The resource id of the resource the shared private link resource is for.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference PrivateLink { get; set; }
        /// <summary>Resource ID.</summary>
        string PrivateLinkId { get; set; }
        /// <summary>The location of the shared private link resource</summary>
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        string RequestMessage { get; set; }
        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus? Status { get; set; }

    }
}