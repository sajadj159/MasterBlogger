using MB.Application.Contracts.Comment;

namespace MB.Infrastructure.EFCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }
    }
}