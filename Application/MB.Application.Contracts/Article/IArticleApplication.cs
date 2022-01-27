using System.Collections.Generic;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> List();
        void Create(CreateArticle command);
        EditArticle GetBy(long id);
        void Edit(EditArticle command);
        void Remove(long id);
        void Active(long id);

    }
}