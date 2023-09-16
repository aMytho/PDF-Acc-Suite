using Microsoft.Extensions.Logging;
using PDF_Acc_Toolset.Data;
using PDF_Acc_Toolset.Services;

namespace PDF_Acc_Toolset;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


#if WINDOWS
        builder.Services.AddTransient<IFolderPicker, Platforms.Windows.FolderPicker>();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<PdfManager>();
		builder.Services.AddSingleton<TaskManager>();
		builder.Services.AddSingleton<ConfigService>();

		return builder.Build();
	}
}
