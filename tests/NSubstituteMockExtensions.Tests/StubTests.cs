using Machine.Specifications;

namespace NSubstituteMockExtensions.Tests;

public class StubTests
{
    It should_equal_true = () => true.ShouldBeTrue();
}