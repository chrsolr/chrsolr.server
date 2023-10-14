public interface IBlogPostService
{
    public Task<List<BlogPostDTO>> GetAll();
}