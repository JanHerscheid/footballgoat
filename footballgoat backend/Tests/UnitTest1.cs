using DAL;
using DAL.Handlers;
using Logic;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //create in memory database
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDataContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var context = new ApplicationDataContext(optionsBuilder.Options);

            var controller = new PlayerHandler(context);
        }
    }
}