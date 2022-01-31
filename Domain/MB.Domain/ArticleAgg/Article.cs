using System;
using System.Collections.Generic;
using Framework.Domain;
using MB.Domain.ArticleAgg.Service;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;

namespace MB.Domain.ArticleAgg
{
    public class Article : DomainBase<long>
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string ImageUrl { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public long ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
        public ICollection<Comment> Comment { get; private set; }

        protected Article()
        {
        }

        public Article(string title, string shortDescription, string imageUrl, string content, long articleCategoryId, IArticleValidator validator)
        {
            GuardForAgainstNUllArgument(title, shortDescription, imageUrl, articleCategoryId);
            validator.CheckThatThisRecordsAlreadyExist(title);

            Title = title;
            ShortDescription = shortDescription;
            ImageUrl = imageUrl;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            IsDeleted = false;
            Comment = new List<Comment>();
        }

        public void Edit(string title, string shortDescription, string imageUrl, string content, long articleCategoryId)
        {
            GuardForAgainstNUllArgument(title, shortDescription, imageUrl, articleCategoryId);
            Title = title;
            ShortDescription = shortDescription;
            ImageUrl = imageUrl;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Active()
        {
            IsDeleted = false;
        }

        public static void GuardForAgainstNUllArgument(string title, string shortDescription, string imageUrl, long articleCategoryId)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(shortDescription) || string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentNullException();

            if (articleCategoryId == 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}