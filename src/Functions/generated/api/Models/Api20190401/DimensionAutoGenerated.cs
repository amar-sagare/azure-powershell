// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Dimension of blobs, possibly be blob type or access tier.</summary>
    public partial class DimensionAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DimensionAutoGenerated" /> instance.</summary>
        public DimensionAutoGenerated()
        {

        }
    }
    /// Dimension of blobs, possibly be blob type or access tier.
    public partial interface IDimensionAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of dimension.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of dimension.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Dimension of blobs, possibly be blob type or access tier.
    internal partial interface IDimensionAutoGeneratedInternal

    {
        /// <summary>Display name of dimension.</summary>
        string DisplayName { get; set; }
        /// <summary>Display name of dimension.</summary>
        string Name { get; set; }

    }
}