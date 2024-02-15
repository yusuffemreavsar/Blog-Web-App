using Entity.Entities;

namespace Service.Services.Abstract
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();

    }
}
