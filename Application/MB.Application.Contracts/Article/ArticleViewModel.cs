namespace MB.Application.Contracts.Article
{
    public class ArticleViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageUrl { get; set; }
        public long ArticleCategoryId { get; set; }


    }
}