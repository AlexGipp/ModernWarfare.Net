using System.Threading.Tasks;
using ModernWarfare.Net.Models.Enums;
using Xunit;

namespace ModernWarfare.NetTests
{
    public class PlatformTests
    {
        [Theory]
        [InlineData(Platform.BattleNet, "battlenet")]
        [InlineData(Platform.Activision, "atvi")]
        [InlineData(Platform.PSN, "psn")]
        [InlineData(Platform.XBL, "xbl")]
        public void ToApiString_EnumsProvided_GiveBackCorrectString(Platform platform, string platformString)
        {
            //Arrange
            string requestPlatform;

            //Act
            requestPlatform = platform.ToApiString();

            //Assert
            Assert.Equal(platformString, requestPlatform);
        }

        [Theory]
        [InlineData(Platform.BattleNet, "Timmmy#21485")]
        [InlineData(Platform.Activision, "khayamimtiaz")]
        [InlineData(Platform.PSN, "igman19")]
        [InlineData(Platform.XBL, "AuTxPHIL")]
        public void ToValidUsername_PlatformAndValidUsernameProvided_GiveBackConvertedUsername(Platform platform, string username)
        {
            //Act
            string newUsername = platform.ToValidUsername(username);

            //Assert
            if (platform == Platform.BattleNet)
            {
                Assert.Equal("Timmmy%2321485", newUsername);
            }
            else
            {
                Assert.NotEmpty(newUsername);
            }
        }
    }
}