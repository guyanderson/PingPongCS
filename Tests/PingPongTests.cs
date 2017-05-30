using Nancy;
using Xunit;
using System.Collections.Generic;
using System.Diagnostics;

namespace PingPong.Objects
{
  public class PingPongTest
  {
    [Fact]
    public void IsNumberDivisibleBy15_ForPingPong_true()
    {
      PingPong testPingPong = new PingPong(15);
      Assert.Equal(true, testPingPong.IsNumberDivisibleBy15(testPingPong.GetNumber()));
    }
    [Fact]
    public void IsNumberDivisibleBy15_ForPingPong_false()
    {
      PingPong testPingPong = new PingPong(14);
      Assert.Equal(false, testPingPong.IsNumberDivisibleBy15(testPingPong.GetNumber()));
    }
    [Fact]
    public void IsNumberDivisibleBy5_ForPong_true()
    {
      PingPong testPingPong = new PingPong(5);
      Assert.Equal(true, testPingPong.IsNumberDivisibleBy5(testPingPong.GetNumber()));
    }
    [Fact]
    public void IsNumberDivisibleBy5_ForPong_false()
    {
      PingPong testPingPong = new PingPong(4);
      Assert.Equal(false, testPingPong.IsNumberDivisibleBy5(testPingPong.GetNumber()));
  }
    [Fact]
    public void IsNumberDivisibleBy3_ForPing_true()
    {
      PingPong testPingPong = new PingPong(3);
      Assert.Equal(true, testPingPong.IsNumberDivisibleBy3(testPingPong.GetNumber()));
    }
    [Fact]
    public void IsNumberDivisibleBy3_ForPing_false()
    {
      PingPong testPingPong = new PingPong(2);
      Assert.Equal(false, testPingPong.IsNumberDivisibleBy3(testPingPong.GetNumber()));
    }
  }
}
