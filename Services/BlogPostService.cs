using AutoMapper;

public class BlogPostService : IBlogPostService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public BlogPostService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<BlogPostDTO>> GetAll()
    {
        var posts = await _context.BlogPosts
            .Where(post => post.IsActive)
            .Select(post => new BlogPostDTO
            {
                Id = post.Id,
                Title = post.Title,
                Summary = post.Summary,
                Slug = post.Slug,
                ImageUrl = post.ImageUrl,
                Markdown = post.Markdown,
                AuthorName = $"{post.User.FirstName} {post.User.LastName}",
                AuthorUsername = post.User.Username,
                AuthorImageUrl = post.User.ImageUrl,
                CreatedAt = post.User.CreatedAt,
                UpdatedAt = post.User.UpdatedAt,
            }).ToListAsync();

        return posts;
    }
}
