using System;
using Xunit;
using YNAB.SDK;

namespace YNAB.SDK.Tests
{
  public class UnitTest1
  {
    private readonly Main _main;

    public UnitTest1() {
      _main = new Main();
    }

    [Fact]
    public void Test1()
    {
      var result = _main.Test();
      Assert.False(result, "Test should not be true!");
    }
  }
}
