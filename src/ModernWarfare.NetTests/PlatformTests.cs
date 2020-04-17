using ModernWarfare.Net.Models.Enums;
using Xunit;

namespace ModernWarfare.NetTests
{
    [Trait("Platform", "Enum Extensions")]
    public class PlatformTests
    {
        [Theory]
        [InlineData(Platform.BattleNet, "battlenet")]
        [InlineData(Platform.Activision, "atvi")]
        [InlineData(Platform.PSN, "psn")]
        [InlineData(Platform.XBL, "xbl")]
        public void ToApiString_EnumsProvided_GivesBackPropperlyFormattedPlatformForAPI(Platform platform, string expectedString)
        {
            //Arrange
            string requestPlatform;

            //Act
            requestPlatform = platform.ToApiString();

            //Assert
            Assert.Equal(expectedString, requestPlatform);
        }

        [Theory]
        [InlineData(Platform.BattleNet, "Timmmy#21485", "Timmmy%2321485")]
        [InlineData(Platform.Activision, "khayamimtiaz", "khayamimtiaz")]
        [InlineData(Platform.PSN, "igman19", "igman19")]
        [InlineData(Platform.XBL, "AuTxPHIL", "AuTxPHIL")]
        public void ToValidUsername_GivesBackPropperlyFormattedUsernameForAPI(Platform platform, string username, string expected)
        {
            //Act
            string newUsername = platform.ToValidUsername(username);

            //Assert
            Assert.Equal(expected, newUsername);
        }
    }
}