
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

.Description

.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IProfile
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICdnIdentity>: 
  [CustomDomainName <String>]: Name of the domain under the profile which is unique globally.
  [EndpointName <String>]: Name of the endpoint under the profile which is unique globally.
  [Id <String>]: Resource identity path
  [OriginGroupName <String>]: Name of the origin group which is unique within the endpoint.
  [OriginName <String>]: Name of the origin which is unique within the profile.
  [PolicyName <String>]: The name of the CdnWebApplicationFirewallPolicy.
  [ProfileName <String>]: Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group.
  [ResourceGroupName <String>]: Name of the Resource group within the Azure subscription.
  [RouteName <String>]: Name of the routing rule.
  [RuleName <String>]: Name of the delivery rule which is unique within the endpoint.
  [RuleSetName <String>]: Name of the rule set under the profile which is unique globally.
  [SecretName <String>]: Name of the Secret under the profile.
  [SecurityPolicyName <String>]: Name of the security policy under the profile.
  [SubscriptionId <String>]: Azure Subscription ID.
.Link
https://docs.microsoft.com/powershell/module/az.cdn/get-azcdnprofile
#>
function Get-AzCdnProfile {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IProfile])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ProfileName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity]
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
    [System.Management.Automation.PSObject]
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Uri]
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
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
            List = 'Az.Cdn.custom\Get-AzCdnProfile';
            Get = 'Az.Cdn.custom\Get-AzCdnProfile';
            List1 = 'Az.Cdn.custom\Get-AzCdnProfile';
            GetViaIdentity = 'Az.Cdn.custom\Get-AzCdnProfile';
        }
        if (('List', 'Get', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
