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
    }
}
