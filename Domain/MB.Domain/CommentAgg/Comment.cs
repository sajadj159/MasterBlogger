﻿using Framework.Domain;
using MB.Domain.ArticleAgg;

namespace MB.Domain.CommentAgg
{
    public class Comment  : DomainBase<long>
    {
        public string Name { get; private set; }
        public string Message { get; private set; }
        public string Email { get; private set; }
        public int Status { get; private set; } //New = 0, Confirmed = 1, Canceled = 2

        public long ArticleId { get; private set; }
        public Article Article { get; private set; }

        protected Comment()
        {
        }

        public Comment(string name, string message, string email, long articleId)
        {
            Name = name;
            Message = message;
            Email = email;
            ArticleId = articleId;
            Status = Statuses.New;
        }
        public void Confirm()
        {
            Status = Statuses.Confirmed;
        }

        public void Canceled()
        {
            Status = Statuses.Canceled;
        }
    }
}