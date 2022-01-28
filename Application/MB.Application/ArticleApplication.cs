using System.Collections.Generic;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleAgg.Service;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleValidator _articleValidator;

        public ArticleApplication(IArticleRepository articleRepository, IArticleValidator articleValidator)
        {
            _articleRepository = articleRepository;
            _articleValidator = articleValidator;
        }

        public List<ArticleViewModel> List()
        {
            return _articleRepository.GetAll();
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.ImageUrl, command.Content, command.ArticleCategoryId);
            _articleRepository.CreateAndSave(article);
        }

        public EditArticle GetBy(long id)
        {
            var article = _articleRepository.GetBy(id);
            var result = new EditArticle
            {
                ArticleCategoryId = article.ArticleCategoryId,
                Content = article.Content,
                Id = article.Id,
                ImageUrl = article.ImageUrl,
                ShortDescription = article.ShortDescription,
                Title = article.Title
            };
            return result;
        }

        public void Edit(EditArticle command)
        {
            var article = _articleRepository.GetBy(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.ImageUrl, command.Content,
                command.ArticleCategoryId,_articleValidator);
            _articleRepository.Save();
        }

        public void Remove(long id)
        {
            var article = _articleRepository.GetBy(id);
            article.Remove(id);
            _articleRepository.Save();
        }

        public void Active(long id)
        {
            var article = _articleRepository.GetBy(id);
            article.Active(id);
            _articleRepository.Save();
        }
    }
}