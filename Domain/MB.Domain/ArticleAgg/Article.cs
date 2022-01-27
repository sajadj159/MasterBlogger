using System;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Domain.ArticleAgg
{
    public class Article
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string ImageUrl { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public long ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }

        protected Article()
        {
        }

        public Article(string title, string shortDescription, string imageUrl, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            ImageUrl = imageUrl;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            IsDeleted = false;
            CreationDate=DateTime.Now;
        }

        public void Edit(string title, string shortDescription, string imageUrl, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            ImageUrl = imageUrl;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }

        public void Remove(long id)
        {
            Id = id;
            IsDeleted = true;
        }

        public void Active(long id)
        {
            Id = id;
            IsDeleted = false;
        }
    }
}