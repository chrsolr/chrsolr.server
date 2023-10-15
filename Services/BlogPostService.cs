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
        return await _context.BlogPosts.Select(post => _mapper.Map<BlogPostDTO>(post)).ToListAsync();
    }
}
