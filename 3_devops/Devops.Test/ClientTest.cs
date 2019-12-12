namespace Devops.Test
{
  public class ClientTest
  {
    private readonly Ilogger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController>();
    [Fact]

    public void Test_IndexPage()
    {
      //arrange
      var home = new HomeController(logger);

      //act
      var index = home.Index();

      //assert
      Assert.NotNull(index);
    }
  }
}
