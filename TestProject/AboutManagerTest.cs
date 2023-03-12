using Xunit;
using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MyProject.Tests
{
    public class AboutManagerTests
    {
        [Fact]
        public void Insert_Should_Insert_New_About()
        {
            // Arrange
            IAboutService aboutService = new AboutManager(new EfAboutDal());
            About about = new About
            {
                // set about properties here
            };

            // Act
            aboutService.TAdd(about);

            // Assert
            var insertedAbout = aboutService.TGetByID(about.About_Id);
            Assert.NotNull(insertedAbout);
            Assert.Equal(about.About_Id, insertedAbout.About_Id);
            // check other properties here
        }
        [Fact]
        public void Remove_Should_Remove_About()
        {
            // Arrange
            IAboutService aboutService = new AboutManager(new EfAboutDal());
            About about = new About
            {
                // set about properties here
            };
            aboutService.TAdd(about);

            // Act
            aboutService.TDelete(about);

            // Assert
            var deletedAbout = aboutService.TGetByID(about.About_Id);
            Assert.Null(deletedAbout);
        }
        [Fact]
        public void Update_Should_Update_About()
        {
            IAboutService aboutService = new AboutManager(new EfAboutDal());
            About about = new About { };
            aboutService.TAdd(about);
            // Update about properties
            about.Title = "New Title";
            about.Content = "New Content";

            // Act
            aboutService.TUpdate(about);

            // Assert
            var updatedAbout = aboutService.TGetByID(about.About_Id);
            Assert.Equal("New Title", updatedAbout.Title);
            Assert.Equal("New Content", updatedAbout.Content);
        }
    

}
}
