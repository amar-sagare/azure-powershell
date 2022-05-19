// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Extensions;

    /// <summary>The error exception.</summary>
    public partial class DedicatedHsmError :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IDedicatedHsmError,
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IDedicatedHsmErrorInternal
    {

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError _error;

        /// <summary>The error detail of the operation if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.Error()); }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IDedicatedHsmErrorInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.Error()); set { {_error = value;} } }

        /// <summary>Creates an new <see cref="DedicatedHsmError" /> instance.</summary>
        public DedicatedHsmError()
        {

        }
    }
    /// The error exception.
    public partial interface IDedicatedHsmError :
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.IJsonSerializable
    {
        /// <summary>The error detail of the operation if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error detail of the operation if any.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError Error { get;  }

    }
    /// The error exception.
    internal partial interface IDedicatedHsmErrorInternal

    {
        /// <summary>The error detail of the operation if any.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DedicatedHsm.Models.Api20211130.IError Error { get; set; }

    }
}