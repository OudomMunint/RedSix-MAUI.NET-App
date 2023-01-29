﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace redsix;

using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        // Initialise the toolkit
        builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();

        // Continue initializing your .NET MAUI App here

        return builder.Build();
    }
}
