# Development

## Setup

- Install the [.NET Core SDK][dotnet], which includes the dotnet CLI.
- Note: [Docker][docker] is required to generate the Open API code
- Build the project with method of your choice
  - [ vscode ] run task `Build Debug Mode`
  - [ shell ] `dotnet build ./YNAB.SDK/YNAB.SDK.csproj`
- Generate latest client based on swagger spec
  - Open shell to `scripts` directory
  - [ shell ] `./Generate-LatestOpenAPICodeAndDocs.ps1`
- Run tests with method of your choice
  - [ vscode ] run task `Run Tests`
  - [ shell ] `dotnet test ./YNAB.SDK.Tests/YNAB.SDK.Tests.csproj`

## Releasing

- Commit all changes
- Tag master with version number
- Open shell to `scripts` directory
- [ shell ] `./Publish-NugetPackage.ps1 -NugetAPIKey my_api_key`
- Bump the version number in `YNAB.SDK.csproj`

[dotnet]: https://dotnet.microsoft.com/download
[docker]: https://docs.docker.com/install/
