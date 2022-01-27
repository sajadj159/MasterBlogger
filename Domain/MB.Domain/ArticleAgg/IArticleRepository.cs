using System.Collections.Generic;
using MB.Application.Contracts.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetAll();
        void CreateAndSave(Article entity);
        Article GetBy(long id);
        void Save();
    }
}