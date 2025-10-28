# SFK Mod Indicator

A BepInEx mod for **Super Fantasy Kingdom** that displays a "Mods Loaded" indicator on the title screen.

## What It Does

Shows a green "Mods Loaded" text on the title screen when mods are active - confirms that BepInEx and your mods are working correctly.

## Installation

**Note**: Super Fantasy Kingdom is not yet available on Thunderstore. This mod uses Thunderstore package structure for future compatibility.

### Manual Installation

1. **Prerequisites**: BepInEx 5.4.21+ installed in your game directory

2. **Download**: Get `ModIndicator-1.0.0.zip` from [Releases](../../releases)

3. **Install**:
   - Extract the zip
   - Copy `ModIndicator.dll` to `Super Fantasy Kingdom/Content/BepInEx/plugins/`
   - You can create a subfolder if you prefer: `BepInEx/plugins/ModIndicator/`

4. **Launch**: Run the game. You should see "Mods Loaded" in green text on the title screen.

5. **Verify**: Check the BepInEx console for:
   ```
   [Info: SFK Mod Indicator] SFK Mod Indicator loaded!
   [Info: SFK Mod Indicator] Mod indicator created above version text!
   ```

## Compatibility

- **Game Version**: v0.4.952.0
- **BepInEx**: 5.4.21+
- **Conflicts**: None

## Building

```bash
git clone https://github.com/Street0r/ModIndicator.git
cd ModIndicator
dotnet build
```

Output: `bin/Debug/netstandard2.1/ModIndicator.dll`

**Note**: Update the game assembly paths in `ModIndicator.csproj` to match your installation.

## Changelog

**v1.0.0** - Initial release

## License

MIT License - Free to use and modify!
