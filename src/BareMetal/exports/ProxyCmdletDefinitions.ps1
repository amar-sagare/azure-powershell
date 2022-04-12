
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
Gets an Azure BareMetal instance for the specified subscription, resource group, and instance name.
.Description
Gets an Azure BareMetal instance for the specified subscription, resource group, and instance name.
.Example
PS C:\> Get-AzBareMetal

Location       Name         ResourceGroupName
--------       ----         -----------------
westus2        rhel79ora01  MWH03A-T210
westus2        rhel79ora02  MWH03A-T210
southcentralus oelnvmetest  SAT09A-T230
centraluseuap  orcllabdsm01 DSM05A-T030
.Example
PS C:\> Get-AzBareMetal -Name oelnvmetest -ResourceGroupName SAT09A-T230

Location       Name         ResourceGroupName
--------       ----         -----------------
southcentralus oelnvmetest  SAT09A-T230
.Example
PS C:\> Get-AzBareMetal -ResourceGroupName MWH03A-T210

Location Name        ResourceGroupName
-------- ----        -----------------
westus2  rhel79ora01 MWH03A-T210
westus2  rhel79ora02 MWH03A-T210

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstance
.Link
https://docs.microsoft.com/powershell/module/az.baremetal/get-azbaremetal
#>
function Get-AzBareMetal {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstance])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('AzureBareMetalInstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [System.String]
    # Name of the Azure BareMetal on Azure instance.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
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
            Get = 'Az.BareMetal.private\Get-AzBareMetal_Get';
            List = 'Az.BareMetal.private\Get-AzBareMetal_List';
            List1 = 'Az.BareMetal.private\Get-AzBareMetal_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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

<#
.Synopsis
Patches the Tags field of a Azure BareMetal instance for the specified subscription, resource group, and instance name.
.Description
Patches the Tags field of a Azure BareMetal instance for the specified subscription, resource group, and instance name.
.Example
PS C:\> Update-AzBareMetal -Name oraclerac53 -ResourceGroupName SAT09A-T530 -Tag @{"env"="test"}

Location       Name        ResourceGroupName
--------       ----        -----------------
southcentralus oraclerac53 SAT09A-T530
.Example
PS C:\> Get-AzBareMetal -Name oraclerac53 -ResourceGroupName SAT09A-T530 | Update-AzBareMetal -Tag @{"env"="test"}

Location       Name        ResourceGroupName
--------       ----        -----------------
southcentralus oraclerac53 SAT09A-T530

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.IBareMetalIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstance
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBareMetalIdentity>: Identity Parameter
  [AzureBareMetalInstanceName <String>]: Name of the Azure BareMetal on Azure instance.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://docs.microsoft.com/powershell/module/az.baremetal/update-azbaremetal
#>
function Update-AzBareMetal {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IAzureBareMetalInstance])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('AzureBareMetalInstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [System.String]
    # Name of the Azure BareMetal on Azure instance.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.IBareMetalIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.ITags]))]
    [System.Collections.Hashtable]
    # Tags field of the AzureBareMetal instance.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Category('Runtime')]
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
            UpdateExpanded = 'Az.BareMetal.private\Update-AzBareMetal_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.BareMetal.private\Update-AzBareMetal_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
