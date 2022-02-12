using System;
using FluentAssertions;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using NSubstitute;
using Xunit;

namespace MB.Domain.Tests.Unit
{
    public class ArticleCategoryTests
    {
        private readonly IArticleCategoryValidator _validator;

        public ArticleCategoryTests()
        {
            var articleCategoryRepository = Substitute.For<IArticleCategoryRepository>();
            _validator = new ArticleCategoryValidator(articleCategoryRepository);
        }
        [Fact]
        public void Constructor_ShouldConstructANewArticleCategory()
        {
            //Arrange
            const string title = "Asp.Net";

            //Act
            var articleCategory = new ArticleCategory(title, _validator);


            //Assert
            articleCategory.Title.Should().Be(title);
        }

        [Fact]
        public void Rename_ShouldRenameTitle()
        {
            //Arrange
            const string title = "Iphone";
            var articleCategory = new ArticleCategory(title, _validator);
            //Act

            articleCategory.Rename(title);

            //Assert
            articleCategory.Title.Should().Be(title);
        }

        [Fact]
        public void Deactivate_ShouldDeactivateTheExistArticleCategory()
        {
            //Arrange

            var articleCategory = new ArticleCategory("Iphone", _validator);

            //Act
            articleCategory.Deactivate();


            //Assert
            articleCategory.IsDeleted.Should().BeTrue();
        }

        [Fact]
        public void Activate_ShouldActive_WhenThisMethodCall()
        {
            //Arrange
            var articleCategory = new ArticleCategory("Somthing", _validator);

            //Act
            articleCategory.Activate();

            //Assert
            articleCategory.IsDeleted.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GuardAgainstEmptyTitle_ShouldThrowException_WhenTitleIs(string nullOrWhiteSpace)
        {
            //Act
            Action action = () => new ArticleCategory(nullOrWhiteSpace, _validator);
            
            //Assert
            action.Should().ThrowExactly<ArgumentNullException>();
            
        }
    }
}
