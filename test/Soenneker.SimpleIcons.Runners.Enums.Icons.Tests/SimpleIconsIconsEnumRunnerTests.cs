using Soenneker.SimpleIcons.Runners.Enums.Icons.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.SimpleIcons.Runners.Enums.Icons.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SimpleIconsIconsEnumRunnerTests : HostedUnitTest
{
    private readonly ISimpleIconsIconsEnumRunner _runner;

    public SimpleIconsIconsEnumRunnerTests(Host host) : base(host)
    {
        _runner = Resolve<ISimpleIconsIconsEnumRunner>(true);
    }

    [Test]
    public void Default()
    {

    }
}
