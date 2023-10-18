public interface IBlogPostService
{
    public Task<List<BlogPostDTO>> GetAll();
    public Task<BlogPostDTO> GetById(string id);
}
