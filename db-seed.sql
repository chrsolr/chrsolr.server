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
           (
		   NEWID(), 'Title', 'Summary', 'Slug', 'ImageUrl', 'Markdown', 0);
GO
