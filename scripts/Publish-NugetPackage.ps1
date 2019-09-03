
<#
.SYNOPSIS
  Publish the latest version of the SDK to nuget.org

.PARAMETER $NugetAPIKey
  Nuget API Key for publishing the package. see `https://docs.microsoft.com/en-us/nuget/nuget-org/publish-a-package`

.PARAMETER $NuspecFile
  Path to the nupkg (nuget spec) file

.INPUTS
  .nupkg file - nuget specification

.OUTPUTS
  publish.log - log file

.NOTES
  Version:        1.0
  Author:         Jake Moening
  Creation Date:  2019-08-22
  Purpose/Change: Initial Script Development

.EXAMPLE
  ./Publish-NugetPackage.ps1 my_api_key

.EXAMPLE
  ./Publish-NugetPackage.ps1 -NugetAPIKey my_api_key

.EXAMPLE
  ./Publish-NugetPackage.ps1 -NugetAPIKey my_api_key -NuspecFile myOtherSpec.nupkg

#>
[CmdletBinding()]
Param (
  [Parameter(Mandatory = $True, ValueFromPipeline = $True, Position = 0)]
  [string] $NugetAPIKey,
  [Parameter()]
  [string] $NuspecFile
)

Begin {
  $ErrorActionPreference = "Stop"
  $logPath = "./publish.log"
  "PUBLISH STARTED $(Get-Date)" | Tee-Object -FilePath $logPath
  $projectPath = "../YNAB.SDK/YNAB.SDK.csproj"
}
Process
{
  "`nCLEAN STARTED $(Get-Date)" | Tee-Object -FilePath $logPath -Append
  dotnet clean $projectPath --configuration Release --verbosity normal | Tee-Object -FilePath $logPath -Append
  if(!$?) { throw "FAILED TO CLEAN" }
  "`nBUILD STARTED $(Get-Date)" | Tee-Object -FilePath $logPath -Append
  dotnet build $projectPath --configuration Release --force --verbosity normal | Tee-Object -FilePath $logPath -Append
  if(!$?) { throw "FAILED TO BUILD" }
  "`nPACK STARTED $(Get-Date)" | Tee-Object -FilePath $logPath -Append
  dotnet pack $projectPath --configuration Release --force --verbosity normal | Tee-Object -FilePath $logPath -Append
  if(!$?) { throw "FAILED TO PACK" }
  if ($NuspecFile -eq "")
  {
    $NuspecFile = (Get-ChildItem ../YNAB.SDK/bin/Release/*.nupkg | Sort-Object -Descending)[0].FullName
  }
  "`nNUGET PUSH STARTED $(Get-Date)" | Tee-Object -FilePath $logPath -Append
  dotnet nuget push $NuspecFile --api-key $NugetAPIKey --source https://api.nuget.org/v3/index.json | Tee-Object -FilePath $logPath -Append
  if(!$?) { throw "FAILED TO PUSH" }
}
End {
  "`nPUBLISH FINISHED $(Get-Date)" | Tee-Object -FilePath $logPath -Append
}
