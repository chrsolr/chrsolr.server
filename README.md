### Commands

`dotnet watch`
`dotnet ef migrations add InitialMigration`
`dotnet ef database update`

### ToDo's

- DB uuidv4
- User Table
- Blog Table
- Seeding
- Auth
- Docker for deployment (GCR?)



USE [chrsolr]
GO

INSERT INTO [dbo].[BlogPosts]
           ([Id]
           ,[Title]
           ,[Summary]
           ,[Slug]
           ,[ImageUrl]
           ,[Markdown]
           ,[IsActive])
     VALUES
           (uuid(),"Title","Summary","Slug","ImageUrl","Markdown",0);
GO


