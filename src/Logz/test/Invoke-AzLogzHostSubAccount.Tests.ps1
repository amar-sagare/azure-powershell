if(($null -eq $TestName) -or ($TestName -contains 'Invoke-AzLogzHostSubAccount'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzLogzHostSubAccount.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-AzLogzHostSubAccount' {
    It 'Host' {
        { Invoke-AzLogzHostSubAccount -ResourceGroupName $env.resourceGroup -MonitorName $env.monitorName01 -SubAccountName $env.subAccountName01 } | Should -Not -Throw
    }

    It 'HostViaIdentity' {
        { 
            $subAccount = Get-AzLogzSubAccount -ResourceGroupName $env.resourceGroup -MonitorName $env.monitorName01 -Name $env.subAccountName01
            Invoke-AzLogzHostSubAccount -InputObject $subAccount
        } | Should -Not -Throw
    }
}
