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

    public async Task<BlogPostDTO> GetBySlug(string slug)
    {
        var post = await _context.BlogPosts
            .Where(post => post.Slug == slug)
            .Select(post => new BlogPostDTO
            {
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
            }).FirstOrDefaultAsync();

        return post;
    }
}
