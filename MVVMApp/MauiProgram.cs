using MVVMApp.Services;
using MVVMApp.ViewModels;

namespace MVVMApp;

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

		builder.Services.AddSingleton<ParticipanteService>();

		builder.Services.AddSingleton<ParticipanteViewModel>();

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
