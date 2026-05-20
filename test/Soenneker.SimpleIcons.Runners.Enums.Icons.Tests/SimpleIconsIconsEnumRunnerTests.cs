using System;
using System.Threading.Tasks;
using Soenneker.SimpleIcons.Runners.Enums.Icons.Utils.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.SimpleIcons.Runners.Enums.Icons.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SimpleIconsIconsEnumRunnerTests : HostedUnitTest
{
    private readonly IFileOperationsUtil _fileOperationsUtil;

    public SimpleIconsIconsEnumRunnerTests(Host host) : base(host)
    {
        _fileOperationsUtil = Resolve<IFileOperationsUtil>(true);
    }

    [Test]
    public void Default()
    {
        if (_fileOperationsUtil is null)
            throw new InvalidOperationException("Could not resolve file operations util");
    }

    [Test]
    public async Task Enum_type_name_is_simple_icon()
    {
        await Assert.That(Constants.EnumTypeName).IsEqualTo("SimpleIcon");
        await Assert.That(Constants.EnumTypeName).IsNotEqualTo("SimpleIconEnum");
    }
}
