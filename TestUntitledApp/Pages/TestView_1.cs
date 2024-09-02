using Bunit;
using Microsoft.Extensions.DependencyInjection;
using UntitledApp.Pages;

namespace TestUntitledApp
{
	[Collection("UntitledApp")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
