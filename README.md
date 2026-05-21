# .NET MAUI Material 3 Customization Sample

This sample shows how to enable Material 3 for a .NET MAUI Android app and customize the native Material 3 color roles from `colors.xml`.

![Customized Material 3 controls](screenshots/custom-material3.png)

## Important files

- `MauiMaterial3CustomizationSample.csproj` enables Material 3 with `<UseMaterial3>true</UseMaterial3>` and pins the MAUI package to `10.0.60`.
- `Platforms/Android/Resources/values/colors.xml` overrides both the legacy Android aliases and the Material 3 `m3_sys_color_*` roles.
- `MainPage.xaml` includes common MAUI controls so the Material 3 shapes, outlined input fields, switches, radio buttons, sliders, progress bars, and buttons are visible.
- `App.xaml` intentionally only merges `Resources/Styles/Colors.xaml` so the default MAUI control styles do not hide the native Material 3 colors.

## Run it

Install the .NET 10 SDK with the MAUI workload, then run:

```bash
dotnet restore
dotnet build -t:Run -f net10.0-android
```

The key color customization is in `Platforms/Android/Resources/values/colors.xml`. For real Material 3 color changes, update the `m3_sys_color_light_*` and `m3_sys_color_dark_*` values, not only `colorPrimary`.
