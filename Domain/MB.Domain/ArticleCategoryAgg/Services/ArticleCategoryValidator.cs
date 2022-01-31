using MB.Domain.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidator : IArticleCategoryValidator
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidator(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatThisRecordAlreadyExist(string title)
        {
            if (_articleCategoryRepository.Exist(x=>x.Title==title))
                throw new DuplicatedRecordException("This record is already exists in database");
        }
    }
}