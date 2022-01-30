using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<CommentViewModel> GetAll()
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