# DOT NET CLI
### Dot New
> It will Create the Project within the Folder as of name of the Folder 
```bash
dotnet new webapi
dotnet new react
dotnet new angular
```
- 
### Dot Net Use Full Command
```bash
dotnet-
dotnet build
dotnet build-server
dotnet clean
dotnet dev-certs
dotnet format
dotnet help
dotnet migrate
dotnet msbuild
dotnet new <TEMPLATE>
dotnet new list
dotnet new search
dotnet new install
dotnet new uninstall
dotnet new update
# .NET default templates
# Custom templates
dotnet pack
dotnet publish
dotnet restore
dotnet run
dotnet sdk check
dotnet sln
dotnet store
dotnet test
dotnet vstest
dotnet watch
# Elevated access
# Enable Tab completion
# Develop libraries with the CLI
```
### Implicit restore
1. You don't have to run dotnet restore because it's run implicitly by all commands that require a restore to occur, such as dotnet new, dotnet build, dotnet run, dotnet test, dotnet publish, and dotnet pack. To disable implicit restore, use the --no-restore option.


### dotnet new 
```bash
dotnet new <TEMPLATE> 
  [--dry-run] 
  [--force] 
  [-lang|--language {"C#"|"F#"|VB}]
  [-n|--name <OUTPUT_NAME>] 
  [-f|--framework <FRAMEWORK>] 
  [--no-update-check]
  [-o|--output <OUTPUT_DIRECTORY>] 
  [--project <PROJECT_PATH>]
  [-d|--diagnostics] 
  [--verbosity <LEVEL>] [Template options]
```

### What does dotnet run under the hood?
- dotnet run 4 things
1. restore based on project.cs -> Download Dependencies
2. build -> compiled the application
3. run the project
4. Open the Default Browser and Load the page

### dotnet run
```bash
dotnet run 
    [-a|--arch <ARCHITECTURE>] 
    [-c|--configuration <CONFIGURATION>]
    [-f|--framework <FRAMEWORK>] // net6.0 
    [--force] 
    [--interactive]
    [--launch-profile <NAME>] 
    [--no-build]
    [--no-dependencies] 
    [--no-launch-profile] 
    [--no-restore]
    [--os <OS>] 
    [--project <PATH>] // path/where/project_created
    [-r|--runtime <RUNTIME_IDENTIFIER>]
    [-v|--verbosity <LEVEL>] 
    [[--] [application arguments]]

dotnet run -h|--help
```
### Adding Swagger to a Project?
```bash
dotnet add TodoApi.csproj package Swashbuckle.AspNetCore -v 6.2.3
```