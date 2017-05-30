using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsNumberDivisibleBy15_ForPingPong_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.IsNumberDivisibleBy15(15));
    }
    public void IsNumberDivisibleBy15_ForPingPong_false()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(false, testPingPong.IsNumberDivisibleBy15(14));
    }
    [Fact]
    public void IsNumberDivisibleBy5_ForPong_true()
    {
      PingPong testPong = new PingPong();
      Assert.Equal(true, testPong.IsNumberDivisibleBy5(5));
    }
    [Fact]
    public void IsNumberDivisibleBy5_ForPong_false()
    {
      PingPong testPong = new PingPong();
      Assert.Equal(false, testPong.IsNumberDivisibleBy5(4));
  }
    [Fact]
    public void IsNumberDivisibleBy3_ForPing_true()
    {
      PingPong testPing = new PingPong();
      Assert.Equal(true, testPing.IsNumberDivisibleBy3(3));
    }
    [Fact]
    public void IsNumberDivisibleBy3_ForPing_false()
    {
      PingPong testPing = new PingPong();
      Assert.Equal(false, testPing.IsNumberDivisibleBy3(4));
    }
  }
}
