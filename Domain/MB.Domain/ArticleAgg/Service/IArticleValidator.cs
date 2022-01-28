namespace MB.Domain.ArticleAgg.Service
{
    public interface IArticleValidator
    {
        void CheckThatThisRecordsAlreadyExist(string title);
    }
}