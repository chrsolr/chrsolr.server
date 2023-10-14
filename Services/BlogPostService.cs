public class BlogPostService : IBlogPostService
{
    private readonly DataContext _context;

    public BlogPostService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<BlogPostDTO>> GetAll()
    {
        var post = await _context.BlogPosts
            .Select(
                v =>
                    new BlogPostDTO
                    {
                        Title = v.Title,
                        Summary = v.Summary,
                        Markdown = v.Markdown,
                        ImageUrl = v.ImageUrl,
                        IsActive = v.IsActive,
                        Slug = v.Slug
                    }
            )
            .ToListAsync();
        return post;
    }
}
