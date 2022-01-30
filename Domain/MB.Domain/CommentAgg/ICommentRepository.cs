using System.Collections.Generic;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void CreateAndSave(Comment entity);
        List<Comment> GetAll();
    }
}