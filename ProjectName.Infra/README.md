### Infrastructure

#### Migrations
```c#
// Installing Tools When you dont have
dotnet tool list --global
dotnet tool install --global dotnet-ef -v 6.0.16

// Docker Command When you don't  have a Container already running
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker image ls
docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
docker ps


Install-Package Microsoft.EntityFrameworkCore.Tools // Power Shell

Add-Migration NameOfMigration -Context DatabaseContextName // PM Package Manager Console

dotnet ef migrations add NameOfMigration // When you have One DBContext and One Project

dotnet ef migrations add NameOfMigration -p ProjectName.Infra -s ProjectName.Api // When you have two or more Projects

dotnet ef migrations add NameOfMigration --context DBCntx // When you have Two or More DB Context


UPDATE-DATABASE -Context DatabaseContext // PM Package Manager Console

// Before Running the Below Command Ensure the Project is not Running Because DB In Use
dotnet ef database update -p ProjectName.Infra -s ProjectName.Api --connection "SERVER=.;DATABASE=Test;USER=sa;PASSWORD=asdf1234;Encrypt=false"

dotnet run --project ProjectName.Api
```