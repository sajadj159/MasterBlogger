using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategoryValidator;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidator articleCategoryValidator)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidator = articleCategoryValidator;
        }


        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.GetAll();

            return articleCategories
                .Select(articleCategory => new ArticleCategoryViewModel
                {
                    Id = articleCategory.Id,
                    Title = articleCategory.Title,
                    IsDeleted = articleCategory.IsDeleted,
                    DateTime = articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture)
                }).OrderByDescending(x=>x.Id).ToList();
        }

        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title, _articleCategoryValidator);
            _articleCategoryRepository.Create(articleCategory);

        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = _articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);
        }

        public void Deactivate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Deactivate();
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
        }

        public RenameArticleCategory GetBy(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }
    }
}