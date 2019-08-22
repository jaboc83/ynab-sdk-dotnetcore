# Download latest spec for the API
$specFile = "spec-v1-swagger.json"
if (Test-Path "../$specFile")
{
  Remove-Item "../$specFile" -Force
}
Invoke-WebRequest -Uri "https://api.youneedabudget.com/papi/$specFile" -OutFile "../$specFile"

# Use Docker to codegen dotnetcore based on the swagger spec
docker run --rm -v "$(Get-Location):/local" swaggerapi/swagger-codegen-cli:latest generate `
  -i /local/spec-v1-swagger.json `
  -l csharp `
  -c /local/swagger-config.json -o /local `
  -t /local/swagger-templates
if(!$?) { throw "FAILED TO GENERATE SWAGGER CODE"}
