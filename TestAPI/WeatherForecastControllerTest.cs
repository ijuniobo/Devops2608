using DockerInfnetDevopsSample.Controllers;

namespace TestAPI
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Any());

        }

        [Fact]
        public void DeveFazerPostSemSucesso()
        {
            var controller = new WeatherForecastController();
            try
            {
                var result = controller.Post();

            }
            catch (Exception e)
            {

                Assert.True(e.Message.Any());
            }


        }

    }
}