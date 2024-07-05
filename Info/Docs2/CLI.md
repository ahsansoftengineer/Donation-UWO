## Dotnet Core CLI Commands
- Note: For Bash You can Revert BackSlash \ to ForwardSlash /
- Create a Folder for your project with that folder run the following commands

### VS Code Specific
```csharp
dotnet new editorconfig
// create a .editorconfig file for vs code something something
```

### Dotnet Commands
1. Creating a Solution
- dotnet new sln -o SolutionName
2. Creating WEB API
- dotnet new webapi -o ProjectName.Api
3. Creating LIBRARY
- dotnet new classlib -o ProjectName.Contracts
- dotnet new classlib -o ProjectName.Infrastructure
- dotnet new classlib -o ProjectName.Application
- dotnet new classlib -o ProjectName.Domain
4. To See the Content within a file
- more.\SolutionName.sln
5. To add all the Projects within in the Solution Recursively
- dotnet sln add (ls -r **\*.csproj) // Powershell Command
- dotnet sln remove .\Donation.Contacts\Donation.Contacts.csproj
6. dotnet build
#### 7 Adding Projects to Solution
- dotnet add .\Donation.Api\ reference .\Donation.Contracts\ .\Donation.Application\
- dotnet add .\Donation.Infrastructure\ reference .\Donation.Application\
- dotnet add .\Donation.Application\ reference .\Donation.Domain\
- dotnet add .\Donation.Api\ reference .\Donation.Infrastructure\
#### 8 To Run a Specific Project
- dotnet run --project .\Donation.Api\
- dotnet watch run --project .\Donation.Api\
8. To Open a Folder in FileExplorer Windows
- start .
9. dotnet new gitignore
10. git init
11. Adding Packages to Specific Project

#### User Secrets
```c# 
dotnet user-secrets init --project .\Donation.Api\
dotnet user-secrets set --project .\Donation.Api\ "JwtSettings:Secret" "super-secret-key-from-user-secrets"
dotnet user-secrets list --project .\Donation.Api\
```
#### 13. External Packages for Projects
```c#
dotnet add .\Donation.Infrastructure\ package Microsoft.Extensions.Configuration
dotnet add .\Donation.Infrastructure\ package Microsoft.Extensions.Options.ConfigurationExtensions
dotnet add .\Donation.Infrastructure\ package Microsoft.AspNetCore.Authentication.JwtBearer

dotnet add .\Donation.Application\ package OneOf // Drawback of Scalability used in Application Layer
dotnet add .\Donation.Application\ package FluentResults // It has Lack Some Ability of OneOf used in Application Layer
dotnet add .\Donation.Domain\ package ErrorOr // Recommended and Final Approach
dotnet add .\Donation.Application\ package MediatR
dotnet add .\Donation.Application\ package MediatR.Extension.Microsoft.DependencyInjection
dotnet add .\Donation.Application\ package Mapster
dotnet add .\Donation.Application\ package FluentValidation
dotnet add .\Donation.Application\ package FluentValidation.AspNetCore


dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore 
dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer
dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore.Design
dotnet add Donation.Api package Microsoft.EntityFrameworkCore.Design

dotnet tool list --global
dotnet tool install --global dotnet-ef
```

14. Extra Commands
- dotnet format ./solution.sln


#### 15. Migrations
```csharp
dotnet ef migrations add InitialCreate --project Donation.Infrastructure --startup-project Donation.Api
dotnet ef migrations add InitialCreate -p Donation.Infrastructure -s Donation.Api
dotnet ef migrations remove  -p Donation.Infrastructure -s Donation.Api
// Below Command Run After Sql Container Started
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "Server=localhost;Database=Donation;User Id=sa;Password=asdf1234;Encrypt=false"
```

#### Docker 
```csharp
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker image ls
docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
docker container ls
docker ps
// Below Command Run After SQL Container Runs (Keys are Case Insensitive & their alternatives are available)
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "SERVER=localhost;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false"
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "SERVER=127.0.0.1,1433;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false"
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "server=localhost;Database=Donation;User Id=sa;password=asdf1234;TrustServerCertificate=true"
dotnet run --project Donation.Api // This Command won't work b/c of Certificate & Swagger (Run using f5)
````


### Git Commands
- git push --set-upstream origin BranchNameHere
- git remote set-url stream https://gitlab.com/starbazaar/admin-panel.git
- git remote add stream https://gitlab.com/starbazaar/webapp.git
- git remote -v
- origin  https://gitlab.com/m.ahsan.saifi/webapp.git (fetch)
- origin  https://gitlab.com/m.ahsan.saifi/webapp.git (push)
- stream  https://gitlab.com/starbazaar/webapp.git (fetch)
- stream  https://gitlab.com/starbazaar/webapp.git (push)

### How to Use Curl Command
- Undermentioned Commands only works with Bash
- Before Using that you have to Stop Https Middleware
- Running your app with http in Visual Studio
curl -X 'POST' 'http://localhost:5294/auth/register' -H 'accept: */*' -H 'Content-Type: application/json' -d '{   "firstName": "string", "lastName": "string", "email": "string", "password": "string" }'
curl -X 'POST' 'http://localhost:5294/auth/login' -H 'accept: */*' -H 'Content-Type: application/json' -d '{ "email": "string", "password": "string" }'
curl -X 'GET' 'http://localhost:5294/api/Dinners' -H 'accept: */*' -H 'Authorization: Bearer token.full.goeshere'