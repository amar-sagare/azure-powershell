// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>MigrateMySqlStatus resource specific properties</summary>
    public partial class MigrateMySqlStatusProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlStatusProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlStatusPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LocalMySqlEnabled" /> property.</summary>
        private bool? _localMySqlEnabled;

        /// <summary>True if the web app has in app MySql enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public bool? LocalMySqlEnabled { get => this._localMySqlEnabled; }

        /// <summary>Internal Acessors for LocalMySqlEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlStatusPropertiesInternal.LocalMySqlEnabled { get => this._localMySqlEnabled; set { {_localMySqlEnabled = value;} } }

        /// <summary>Internal Acessors for MigrationOperationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlStatusPropertiesInternal.MigrationOperationStatus { get => this._migrationOperationStatus; set { {_migrationOperationStatus = value;} } }

        /// <summary>Internal Acessors for OperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlStatusPropertiesInternal.OperationId { get => this._operationId; set { {_operationId = value;} } }

        /// <summary>Backing field for <see cref="MigrationOperationStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus? _migrationOperationStatus;

        /// <summary>Status of the migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus? MigrationOperationStatus { get => this._migrationOperationStatus; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>Operation ID for the migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; }

        /// <summary>Creates an new <see cref="MigrateMySqlStatusProperties" /> instance.</summary>
        public MigrateMySqlStatusProperties()
        {

        }
    }
    /// MigrateMySqlStatus resource specific properties
    public partial interface IMigrateMySqlStatusProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>True if the web app has in app MySql enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"True if the web app has in app MySql enabled",
        SerializedName = @"localMySqlEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LocalMySqlEnabled { get;  }
        /// <summary>Status of the migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the migration task.",
        SerializedName = @"migrationOperationStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus? MigrationOperationStatus { get;  }
        /// <summary>Operation ID for the migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation ID for the migration task.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get;  }

    }
    /// MigrateMySqlStatus resource specific properties
    internal partial interface IMigrateMySqlStatusPropertiesInternal

    {
        /// <summary>True if the web app has in app MySql enabled</summary>
        bool? LocalMySqlEnabled { get; set; }
        /// <summary>Status of the migration task.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.OperationStatus? MigrationOperationStatus { get; set; }
        /// <summary>Operation ID for the migration task.</summary>
        string OperationId { get; set; }

    }
}