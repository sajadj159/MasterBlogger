using MB.Domain.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.ArticleAgg.Service
{
    public class ArticleValidator : IArticleValidator
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidator(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CheckThatThisRecordsAlreadyExist(string title)
        {
            if (_articleRepository.Exist(x=>x.Title==title))
            {
                throw new DuplicatedRecordException("This Record Is Already Exist");
            }
        }
    }
}