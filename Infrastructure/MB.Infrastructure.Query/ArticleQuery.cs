using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext _context;

        public ArticleQuery(MasterBloggerContext context)
        {
            _context = context;
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _context.Articles
                .Include(x => x.ArticleCategory)
                .Include(x => x.Comment)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    Image = x.ImageUrl,
                    IsRemoved = x.IsDeleted,
                    ShortDescription = x.ShortDescription,
                    ArticleCategory = x.ArticleCategory.Title,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    CommentsCount = x.Comment.Count(z => z.Status == Statuses.Confirmed)
                }).Where(x => x.IsRemoved == false).OrderByDescending(x => x.Id).ToList();
        }

        public ArticleQueryView GetArticle(long id)
        {
            return _context.Articles.Include(x => x.ArticleCategory)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    Image = x.ImageUrl,
                    IsRemoved = x.IsDeleted,
                    Content = x.Content,
                    ShortDescription = x.ShortDescription,
                    ArticleCategory = x.ArticleCategory.Title,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    CommentsCount = x.Comment.Count(z => z.Status == Statuses.Confirmed),
                    Comments = MapComment(x.Comment.Where(z => z.Status == Statuses.Confirmed))
                }).FirstOrDefault(x => x.Id == id);
        }

        private static List<CommentQueryView> MapComment(IEnumerable<Comment> comments)
        {
            return comments.Select(comment => new CommentQueryView()
            {
                Name = comment.Name,
                CreationDate = comment.CreationDate.ToString(CultureInfo.InvariantCulture),
                Message = comment.Message
            }).ToList();
        }
    }
}