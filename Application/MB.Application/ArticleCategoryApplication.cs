using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Framework.Infrastructure;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategoryValidator;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidator articleCategoryValidator, IUnitOfWork unitOfWork)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidator = articleCategoryValidator;
            _unitOfWork = unitOfWork;
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
                }).OrderByDescending(x => x.Id).ToList();
        }

        public void Create(CreateArticleCategory command)
        {
            _unitOfWork.BeginTran();
            var articleCategory = new ArticleCategory(command.Title, _articleCategoryValidator);
            _articleCategoryRepository.Create(articleCategory);
            _unitOfWork.CommitTran();

        }

        public void Rename(RenameArticleCategory command)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);
            _unitOfWork.CommitTran();
        }

        public void Deactivate(long id)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Deactivate();
            _unitOfWork.CommitTran();
        }

        public void Activate(long id)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _unitOfWork.CommitTran();
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