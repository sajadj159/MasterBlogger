using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Framework.Infrastructure;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repository
{
    public class CommentRepository :BaseRepository<long,Comment>, ICommentRepository
    {
        private readonly MasterBloggerContext _context;
        public CommentRepository(MasterBloggerContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> GetList()
        {
           return _context.Comments.Include(x => x.Article)
                .Select(x => new CommentViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    Status = x.Status,
                    Message = x.Message,
                    Article = x.Article.Title,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)

                }).OrderByDescending(x => x.Id).ToList();
        }
    }
}