
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Stop a continuous web job for a deployment slot.
.Description
Stop a continuous web job for a deployment slot.
.Example
PS C:\> Stop-AzWebAppSlotContinuousWebJob -ResourceGroupName webjob-rg-test -AppName appService-test01 -SlotName slot01 -Name slotcontinuousjob-01

.Example
PS C:\> Get-AzWebAppSlotContinuousWebJob -ResourceGroupName webjob-rg-test -AppName appService-test01 -SlotName slot01 -Name slotcontinuousjob-01 | Stop-AzWebAppSlotContinuousWebJob


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IWebsitesIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IWebsitesIdentity>: Identity Parameter
  [Authprovider <String>]: The auth provider for the users.
  [DomainName <String>]: The custom domain name.
  [EnvironmentName <String>]: The stage site identifier.
  [FunctionAppName <String>]: Name of the function app registered with the static site build.
  [Id <String>]: Resource identity path
  [JobHistoryId <String>]: History ID.
  [Location <String>]: Location where you plan to create the static site.
  [Name <String>]: Name of the static site.
  [PrivateEndpointConnectionName <String>]: Name of the private endpoint connection.
  [ResourceGroupName <String>]: Name of the resource group to which the resource belongs.
  [Slot <String>]: Name of the deployment slot. If a slot is not specified, the API deletes a deployment for the production slot.
  [SubscriptionId <String>]: Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000).
  [Userid <String>]: The user id of the user.
  [WebJobName <String>]: Name of Web Job.
.Link
https://docs.microsoft.com/powershell/module/az.websites/stop-azwebappslotcontinuouswebjob
#>
function Stop-AzWebAppSlotContinuousWebJob {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Stop', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Stop', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [System.String]
    # Site name.
    ${AppName},

    [Parameter(ParameterSetName='Stop', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [System.String]
    # Name of Web Job.
    ${Name},

    [Parameter(ParameterSetName='Stop', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [System.String]
    # Name of the resource group to which the resource belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Stop', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [System.String]
    # Name of the deployment slot.
    # If a slot is not specified, the API deletes a deployment for the production slot.
    ${SlotName},

    [Parameter(ParameterSetName='Stop')]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Your Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000).
    ${SubscriptionId},

    [Parameter(ParameterSetName='StopViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IWebsitesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Websites.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Stop = 'Az.Websites.private\Stop-AzWebAppSlotContinuousWebJob_Stop';
            StopViaIdentity = 'Az.Websites.private\Stop-AzWebAppSlotContinuousWebJob_StopViaIdentity';
        }
        if (('Stop') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
