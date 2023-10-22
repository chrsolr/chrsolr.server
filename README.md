### Needs

- Web Api
- JWT Based
- JWT Refresh
- Docker and Docker-Compose
- Unit Test
- AutoMapper?
- .env file Support


### Commands

`dotnet watch`

`dotnet tool install csharpier -g`
`dotnet tool install --global dotnet-ef`

`dotnet add package Microsoft.EntityFrameworkCore --version 7.0.12`
`dotnet add package Microsoft.EntityFrameworkCore.SQLServer --version 7.0.12`
`dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.12`

`dotnet ef migrations add InitialMigration`
`dotnet ef database update`
`dotnet ef database remove`

`docker compose down && docker compose build && docker compose up -d`

`docker build -t chrsolr-api .`

### ToDo's

- Auth ( Partial: missing db verification and pull)
- Refresh Token
