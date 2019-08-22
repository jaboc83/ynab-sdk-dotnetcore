# Development

## Setup

- Install the [.NET Core SDK][dotnet], which includes the dotnet CLI.
- Build the project with method of your choice
  - [ vscode ] run task `Build Debug Mode`
  - [ shell ] `dotnet build ./YNAB.SDK/YNAB.SDK.csproj`
- Generate latest client based on swagger spec
  - `TODO figure out how to generate latest swagger spec`
- Run tests with method of your choice
  - [ vscode ] run task `Run Tests`
  - [ shell ] `dotnet test ./YNAB.SDK.Tests/YNAB.SDK.Tests.csproj`

## Releasing

- Note: [Docker][docker] is required to generate the swagger code
- Commit all changes
- Open shell to `scripts` directory
- [ shell ] `./Publish-NugetPackage.ps1 -NugetAPIKey my_api_key`
- Bump the version number in `YNAB.SDK.csproj`

[dotnet]: https://dotnet.microsoft.com/download
[docker]: https://docs.docker.com/install/
