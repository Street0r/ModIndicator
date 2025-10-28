# SFK Mod Indicator

A core BepInEx mod for **Super Fantasy Kingdom** that displays a "Mods Loaded" indicator on the title screen when mods are active.

## Features

- **Visual Confirmation**: Shows a green "Mods Loaded" text on the title screen
- **Non-Intrusive**: Positioned above the version text
- **Automatic**: No configuration needed, works out of the box
- **Essential**: Recommended for all modded installations to verify mods are working

## Installation

### Automatic (Recommended)

Most mod managers will install this automatically as a dependency.

### Manual Installation

1. **Prerequisites**: 
   - BepInEx 5.4.21 or later must be installed in your game directory
   - Game version: 0.4.952.0 (may work with other versions)

2. **Download**: Get the latest `ModIndicator-1.0.0.zip` or `ModIndicator.dll` from [Releases](../../releases)

3. **Install**:
   - Navigate to: `Super Fantasy Kingdom/Content/BepInEx/plugins/`
   - Create a folder named `ModIndicator` (or any name you prefer)
   - Copy `ModIndicator.dll` into this folder
   - The `ModIndicator.dll` can also work without a subfolder in plugins

4. **File Structure** should look like:
   ```
   Super Fantasy Kingdom/
   └── Content/
       └── BepInEx/
           ├── core/
           ├── plugins/
           │   └── ModIndicator/
           │       └── ModIndicator.dll
           └── config/
   ```

5. **Launch**: Run the game normally. You should see "Mods Loaded" in green text on the title screen.

6. **Verify**: Check the BepInEx console window for:
   ```
   [Info   :   BepInEx] Loading [SFK Mod Indicator 1.0.0]
   [Info   : SFK Mod Indicator] SFK Mod Indicator loaded!
   [Info   : SFK Mod Indicator] Mod indicator created above version text!
   ```

## What It Does

When you launch the game with mods installed, this indicator:
1. Waits for the title screen to load
2. Finds the "Super Fantasy Games" version text
3. Creates a green "Mods Loaded" text above it
4. Helps you confirm that BepInEx and your mods are working correctly

## Configuration

No configuration needed! This mod works automatically.

## Compatibility

- **Game Version**: Super Fantasy Kingdom v0.4.952.0
- **BepInEx**: 5.4.21 or later
- **Conflicts**: None. This is a core mod that should be compatible with everything.

## For Mod Developers

This mod is often included as a core/dependency mod in mod managers because:
- It provides visual confirmation that the modding framework is working
- It's lightweight and non-invasive
- It helps users troubleshoot mod loading issues

Feel free to list it as a recommended mod or dependency in your own mods.

## Development

### Building from Source

1. **Prerequisites**:
   - .NET SDK 6.0 or later
   - Super Fantasy Kingdom installed (for reference assemblies)

2. **Update paths** in `ModIndicator.csproj` to match your game installation:
   ```xml
   <HintPath>C:\YourPath\Super Fantasy Kingdom\Content\BepInEx\core\BepInEx.dll</HintPath>
   ```

3. **Clone the repository**:
   ```bash
   git clone https://github.com/Street0r/ModIndicator.git
   cd ModIndicator
   ```

4. **Build**:
   ```bash
   dotnet build
   ```

5. **Output**: `bin/Debug/netstandard2.1/ModIndicator.dll`

### Project Structure

```
ModIndicator/
├── ModIndicator.cs       # Main mod code
├── ModIndicator.csproj   # Project file
├── manifest.json         # Thunderstore manifest
└── README.md            # This file
```

## Changelog

### v1.0.0 (Current)
- Initial release
- Displays "Mods Loaded" on title screen
- Scene-aware loading
- TextMeshPro integration

## Credits

- **Developer**: Street0r
- **Game**: Super Fantasy Kingdom by Berserk Games
- **Framework**: BepInEx by BepInEx Team

## License

MIT License - feel free to modify and redistribute!

## Support

- **Issues**: [GitHub Issues](../../issues)
- **Discussions**: [GitHub Discussions](../../discussions)
