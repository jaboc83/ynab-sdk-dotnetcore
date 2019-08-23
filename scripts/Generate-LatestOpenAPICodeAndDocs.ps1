[CmdletBinding()]
param(
  [Parameter()]
  [switch] $UseLocalSpec = $False
)

$specFile = "spec-v1-swagger.json"
if(!$UseLocalSpec)
{
  # Download latest spec for the API
  if (Test-Path "../$specFile")
  {
    Remove-Item "../$specFile" -Force
  }
  Invoke-WebRequest -Uri "https://api.youneedabudget.com/papi/$specFile" -OutFile "../$specFile"
}

# Use Docker to codegen dotnetcore based on the swagger spec
$projRoot = (Get-Item(Get-Location)).Parent.FullName
docker run --rm --volume "$($projRoot):/local" openapitools/openapi-generator-cli generate `
  -DapiTests=false `
  -DmodelTests=false `
  --input-spec "/local/$specFile" `
  --generator-name csharp-netcore `
  --config /local/openapi-config.json `
  --output /local `
  --template-dir /local/openapi-templates/
if(!$?) { throw "FAILED TO GENERATE OPENAPI CODE"}
