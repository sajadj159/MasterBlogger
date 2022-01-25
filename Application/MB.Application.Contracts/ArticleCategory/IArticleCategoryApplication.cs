using System.Collections.Generic;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        void Deactivate(long id);
        void Activate(long id);
        RenameArticleCategory GetBy(long id);
    }
}