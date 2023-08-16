namespace web.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        TestService testService = new TestService();

        //Act
        bool result = testService.TestServiceMethod(true);

        //Assert
        Assert.True(result);
    }
}
