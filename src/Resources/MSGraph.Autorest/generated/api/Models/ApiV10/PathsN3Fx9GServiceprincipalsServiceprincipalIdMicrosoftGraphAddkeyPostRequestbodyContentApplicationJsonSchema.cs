// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    public partial class PathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IPathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="KeyCredential" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphKeyCredential _keyCredential;

        /// <summary>keyCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphKeyCredential KeyCredential { get => (this._keyCredential = this._keyCredential ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphKeyCredential()); set => this._keyCredential = value; }

        /// <summary>Backing field for <see cref="PasswordCredential" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential _passwordCredential;

        /// <summary>passwordCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get => (this._passwordCredential = this._passwordCredential ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphPasswordCredential()); set => this._passwordCredential = value; }

        /// <summary>Backing field for <see cref="Proof" /> property.</summary>
        private string _proof;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Proof { get => this._proof; set => this._proof = value; }

        /// <summary>
        /// Creates an new <see cref="PathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema"
        /// /> instance.
        /// </summary>
        public PathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>keyCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"keyCredential",
        SerializedName = @"keyCredential",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphKeyCredential) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphKeyCredential KeyCredential { get; set; }
        /// <summary>passwordCredential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"passwordCredential",
        SerializedName = @"passwordCredential",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"proof",
        PossibleTypes = new [] { typeof(string) })]
        string Proof { get; set; }

    }
    internal partial interface IPathsN3Fx9GServiceprincipalsServiceprincipalIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchemaInternal

    {
        /// <summary>keyCredential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphKeyCredential KeyCredential { get; set; }
        /// <summary>passwordCredential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential PasswordCredential { get; set; }

        string Proof { get; set; }

    }
}