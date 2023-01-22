using Xunit;
using BodyPartIndexLib;

namespace BodyPartIndex.Tests;

public class BodyPartIndex_Test
{
    [Fact]
    public void TestVersion()
    {
        Assert.Equal("1.0.0", BodyPartIndexLib.BodyPartIndex.version());
    }
}