## Dotnet Core CLI Commands
- Note: For Bash You can Revert BackSlash \ to ForwardSlash /
- Create a Folder for your project with that folder run the following commands

### SOLUTION COMMANDS
```bash
dotnet new sln -o SolutionName
```
### CLASS LIBRARY
```bash
dotnet new webapi -o ProjectName.Api
dotnet new classlib -o ProjectName.Contracts
dotnet new classlib -o ProjectName.Infra
dotnet new classlib -o ProjectName.Application
dotnet new classlib -o ProjectName.Domain
```
### ADD / REMOVE PROJECTS
```bash
dotnet sln add (ls -r **\*.csproj) # Powershell Command
dotnet sln remove .\ProjectName.Contacts\ProjectName.Contacts.csproj # cmd
dotnet format ./solution.sln # ??
more.\SolutionName.sln # ??
```
### ADDING LOCAL PROJECTS
```bash
dotnet build
dotnet add .\ProjectName.Api\ reference .\ProjectName.Contracts\ .\ProjectName.Application\
dotnet add .\ProjectName.Infra\ reference .\ProjectName.Application\
dotnet add .\ProjectName.Application\ reference .\ProjectName.Domain\
dotnet add .\ProjectName.Api\ reference .\ProjectName.Infra\
```
### RUNNING PROJECTS
```bash
dotnet run --project .\ProjectName.Api\
dotnet watch run --project .\ProjectName.Api\
```

#### USER SECRETS
```bash 
dotnet user-secrets init --project .\ProjectName.Api\
dotnet user-secrets set --project .\ProjectName.Api\ "JwtSettings:Secret" "super-secret-key-from-user-secrets"
dotnet user-secrets list --project .\ProjectName.Api\
```
### EXTERNAL PACKAGES
- Adding Packages to Specific Project
```bash
dotnet add .\ProjectName.Infra\ package Microsoft.Extensions.Configuration
dotnet add .\ProjectName.Infra\ package Microsoft.Extensions.Options.ConfigurationExtensions
dotnet add .\ProjectName.Infra\ package Microsoft.AspNetCore.Authentication.JwtBearer

dotnet add .\ProjectName.Application\ package OneOf // Drawback of Scalability used in Application Layer
dotnet add .\ProjectName.Application\ package FluentResults // It has Lack Some Ability of OneOf used in Application Layer
dotnet add .\ProjectName.Domain\ package ErrorOr // Recommended and Final Approach
dotnet add .\ProjectName.Application\ package MediatR
dotnet add .\ProjectName.Application\ package MediatR.Extension.Microsoft.DependencyInjection
dotnet add .\ProjectName.Application\ package Mapster
dotnet add .\ProjectName.Application\ package FluentValidation
dotnet add .\ProjectName.Application\ package FluentValidation.AspNetCore

dotnet add ProjectName.Infra package Microsoft.EntityFrameworkCore 
dotnet add ProjectName.Infra package Microsoft.EntityFrameworkCore.SqlServer
dotnet add ProjectName.Infra package Microsoft.EntityFrameworkCore.Design
dotnet add ProjectName.Api package Microsoft.EntityFrameworkCore.Design
```
### GIT
```bash
start . # OPENING FOLDER EXPLORER USING CLI

dotnet new gitignore
git init
git push --set-upstream origin BranchNameHere
git remote set-url stream https://gitlab.com/starbazaar/admin-panel.git
git remote add stream https://gitlab.com/starbazaar/webapp.git
git remote -v
origin  https://gitlab.com/m.ahsan.saifi/webapp.git (fetch)
origin  https://gitlab.com/m.ahsan.saifi/webapp.git (push)
stream  https://gitlab.com/starbazaar/webapp.git (fetch)
stream  https://gitlab.com/starbazaar/webapp.git (push)
dotnet new editorconfig
```

### DOCKER
```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker image ls
docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
docker container ls
docker ps
// Below Command Run After SQL Container Runs (Keys are Case Insensitive & their alternatives are available)


dotnet ef database update -p ProjectName.Infra -s ProjectName.Api --connection "server=localhost;Database=ProjectName;User Id=sa;password=asdf1234;TrustServerCertificate=true"
 // This Command won't work b/c of Certificate & Swagger (Run using f5)
```
### MIGRATION
```bash
dotnet tool install --global dotnet-ef
dotnet tool list --global


dotnet ef database add MigrationName --project ProjectName.Infra --startup-project ProjectName.Api --connection "SERVER=127.0.0.1,1433;DATABASE=ProjectName;USER=sa;PASSWORD=asdf1234;Encrypt=false"

# ADD
dotnet ef migrations add InitialCreate -p ProjectName.Infra -s ProjectName.Api
# REMOVE
dotnet ef migrations remove  -p ProjectName.Infra -s ProjectName.Api
# UPDATE
dotnet ef database update -p ProjectName.Infra -s ProjectName.Api --connection "Server=localhost;Database=ProjectName;User Id=sa;Password=asdf1234;Encrypt=false"
# RUN
dotnet run --project ProjectName.Api
```
### CURL COMMAND
- Undermentioned Commands only works with Bash
- Before Using that you have to Stop Https Middleware
- Running your app with http in Visual Studio
```bash
curl -X 'POST' 'http://localhost:5294/auth/register' -H 'accept: */*' -H 'Content-Type: application/json' -d '{   "firstName": "string", "lastName": "string", "email": "string", "password": "string" }'
curl -X 'POST' 'http://localhost:5294/auth/login' -H 'accept: */*' -H 'Content-Type: application/json' -d '{ "email": "string", "password": "string" }'
curl -X 'GET' 'http://localhost:5294/api/Dinners' -H 'accept: */*' -H 'Authorization: Bearer token.full.goeshere'
```
