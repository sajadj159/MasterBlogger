using System.Collections.Generic;
using FluentAssertions;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using NSubstitute;
using Xunit;

namespace MB.Infrastructure.Tests.Integration
{
    public class ArticleCategoryRepositoryTests: IClassFixture<RealDataBaseFixture>
    {
        private readonly IArticleCategoryValidator _validator;
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryRepositoryTests(RealDataBaseFixture dataBaseFixture)
        {
            _articleCategoryRepository = new EFCore.Repository.ArticleCategoryRepository(dataBaseFixture.Context);
            _validator = new ArticleCategoryValidator(_articleCategoryRepository);

        }
        [Fact]
        public void Create_ShouldCreateANewArticleCategory()
        {
            //Arrange
          const string title = "Tdd";
          var articleCategory = new ArticleCategory(title, _validator);

          //Act
          _articleCategoryRepository.Create(articleCategory);

          //Assert
          var articleCategories = _articleCategoryRepository.GetAll();
          articleCategories.Should().Contain(articleCategories);
        }

        [Fact]
        public void Get_ShouldReturnAArticleCategory_WhenIdExist()
        {
            //Arrange
            const int id = 1;

            //Act
           var articleCategory = _articleCategoryRepository.Get(id);

           //Assert
           articleCategory.Should().NotBeNull();
        }

        [Fact]
        public void GetAll_ShouldReturnAListOfArticleCategories()
        {
            //Act
            var articleCategories = _articleCategoryRepository.GetAll();

            //Assert
            articleCategories.Should().NotBeEmpty();
            articleCategories.Should().BeOfType<List<ArticleCategory>>();
        }
    }
}
