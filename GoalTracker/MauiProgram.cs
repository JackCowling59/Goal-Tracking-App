using Auth0.OidcClient;
using Microsoft.Extensions.Logging;

namespace GoalTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        var client = new Auth0Client(new Auth0ClientOptions()
        {
            Domain = "YOUR_AUTH0_DOMAIN",
            ClientId = "YOUR_AUTH0_CLIENT_ID",
            RedirectUri = "myapp://callback",
            PostLogoutRedirectUri = "myapp://callback"
        });
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
