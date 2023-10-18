public interface IBlogPostService
{
    public Task<List<BlogPostDTO>> GetAll();
    public Task<BlogPostDTO> GetBySlug(string slug);
}
