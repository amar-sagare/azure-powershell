
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
List the resources currently being monitored by the Logz monitor resource.
.Description
List the resources currently being monitored by the Logz monitor resource.
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitoredResource
.Link
https://docs.microsoft.com/powershell/module/az.logz/get-azlogzmonitoredresource
#>
function Get-AzLogzMonitoredResource {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IMonitoredResource])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='List',Mandatory)]
    [Parameter(ParameterSetName='ListBySubAccount',Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Path')]
    [System.String]
    # Monitor resource name
    ${MonitorName},

    [Parameter(ParameterSetName='ListBySubAccount',Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Path')]
    [System.String]
    # Monitor resource name
    ${SubAccountName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Logz.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)


process {
    try {
        if ($PSCmdlet.ParameterSetName -eq 'ListBySubAccount') {

            $PSBoundParameters.Add('Name', $SubAccountName)
            $PSBoundParameters.Remove('SubAccountName') | Out-Null
            
            return Az.Logz.internal\Get-AzLogzSubAccountMonitoredResource @PSBoundParameters
        }

        return Az.Logz.internal\Get-AzLogzMonitorMonitoredResource @PSBoundParameters
    } catch {
        throw
    }
}
}
