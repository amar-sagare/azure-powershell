﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Compute.Models;

namespace Microsoft.Azure.Commands.Compute
{
    [Cmdlet("Add", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmGalleryApplication"), OutputType(typeof(PSVirtualMachine))]
    public class AddAzureVmGalleryApplicationCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The PSVirtualMachine object to add a Gallery Application Reference ID.")]
        public PSVirtualMachine VM { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "VM Gallery Application Object.")]
        public VMGalleryApplication GalleryApplication { get; set; }

        public override void ExecuteCmdlet()
        {
            if (VM.ApplicationProfile == null)
            {
                VM.ApplicationProfile = new ApplicationProfile();
            }

            VM.ApplicationProfile.GalleryApplications.Add(GalleryApplication);

            WriteObject(VM);
        }
    }
}
