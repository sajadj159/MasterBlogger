namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidator
    {
        void CheckThatThisRecordAlreadyExist(string title);
    }
}