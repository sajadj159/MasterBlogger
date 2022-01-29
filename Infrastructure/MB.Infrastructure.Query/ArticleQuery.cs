using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            return _context.Articles.Include(x => x.ArticleCategory)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    Image = x.ImageUrl,
                    IsRemoved = x.IsDeleted,
                    ShortDescription = x.ShortDescription,
                    ArticleCategory = x.ArticleCategory.Title,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                }).Where(x=>x.IsRemoved==false).OrderByDescending(x => x.Id).ToList();
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
                }).FirstOrDefault(x => x.Id == id);
        }
    }
}