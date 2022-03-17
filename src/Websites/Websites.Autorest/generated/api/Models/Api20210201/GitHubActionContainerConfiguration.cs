// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>The GitHub action container configuration.</summary>
    public partial class GitHubActionContainerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IGitHubActionContainerConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IGitHubActionContainerConfigurationInternal
    {

        /// <summary>Backing field for <see cref="ImageName" /> property.</summary>
        private string _imageName;

        /// <summary>The image name for the build.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ImageName { get => this._imageName; set => this._imageName = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>The password used to upload the image to the container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="ServerUrl" /> property.</summary>
        private string _serverUrl;

        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ServerUrl { get => this._serverUrl; set => this._serverUrl = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>The username used to upload the image to the container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="GitHubActionContainerConfiguration" /> instance.</summary>
        public GitHubActionContainerConfiguration()
        {

        }
    }
    /// The GitHub action container configuration.
    public partial interface IGitHubActionContainerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>The image name for the build.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The image name for the build.",
        SerializedName = @"imageName",
        PossibleTypes = new [] { typeof(string) })]
        string ImageName { get; set; }
        /// <summary>The password used to upload the image to the container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password used to upload the image to the container registry.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The server URL for the container registry where the build will be hosted.",
        SerializedName = @"serverUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ServerUrl { get; set; }
        /// <summary>The username used to upload the image to the container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The username used to upload the image to the container registry.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// The GitHub action container configuration.
    internal partial interface IGitHubActionContainerConfigurationInternal

    {
        /// <summary>The image name for the build.</summary>
        string ImageName { get; set; }
        /// <summary>The password used to upload the image to the container registry.</summary>
        string Password { get; set; }
        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        string ServerUrl { get; set; }
        /// <summary>The username used to upload the image to the container registry.</summary>
        string Username { get; set; }

    }
}