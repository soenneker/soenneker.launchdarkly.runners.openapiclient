using Soenneker.Tests.HostedUnit;

namespace Soenneker.LaunchDarkly.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LaunchDarklyOpenApiClientRunnerTests : HostedUnitTest
{
    public LaunchDarklyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
