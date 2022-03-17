// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.DoNotFormat]
    public partial class ScanRulesetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanRulesetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanRulesetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="ExcludedSystemClassification" /> property.</summary>
        private string[] _excludedSystemClassification;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string[] ExcludedSystemClassification { get => this._excludedSystemClassification; set => this._excludedSystemClassification = value; }

        /// <summary>Backing field for <see cref="IncludedCustomClassificationRuleName" /> property.</summary>
        private string[] _includedCustomClassificationRuleName;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string[] IncludedCustomClassificationRuleName { get => this._includedCustomClassificationRuleName; set => this._includedCustomClassificationRuleName = value; }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanRulesetPropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanRulesetPropertiesInternal.LastModifiedAt { get => this._lastModifiedAt; set { {_lastModifiedAt = value;} } }

        /// <summary>Creates an new <see cref="ScanRulesetProperties" /> instance.</summary>
        public ScanRulesetProperties()
        {

        }
    }
    public partial interface IScanRulesetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"excludedSystemClassifications",
        PossibleTypes = new [] { typeof(string) })]
        string[] ExcludedSystemClassification { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"includedCustomClassificationRuleNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] IncludedCustomClassificationRuleName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }

    }
    internal partial interface IScanRulesetPropertiesInternal

    {
        global::System.DateTime? CreatedAt { get; set; }

        string Description { get; set; }

        string[] ExcludedSystemClassification { get; set; }

        string[] IncludedCustomClassificationRuleName { get; set; }

        global::System.DateTime? LastModifiedAt { get; set; }

    }
}