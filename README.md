# AL2 Template Mod

**Description:**
This is a simple template mod for Assembly Line 2.

**Contributors:**
* Neuxs

**Installation:**

1. **Install Visual Studio:**
   - Download Visual Studio from [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/).
   - During installation, select the following workloads:
     - **.NET desktop development**
     - **Game development with Unity**

2. **Open the Project:**
   - Open the `AL2 Template Mod.csproj` file in Visual Studio.

**Usage:**

To have the mod directly build into the mod folder:

1. **Project Properties:** Right-click on the project in the Solution Explorer and select "Properties".
2. **Build Events:** Go to the "Build Events" tab.
3. **Post-build event command line:** Add the following command and replace `<ReplaceWithGameFolderPath>` with the actual path to your Assembly Line 2 game folder:

   ```
   xcopy /y "$(TargetPath)" "<ReplaceWithGameFolderPath>\BepInEx\plugins"
   ```

**License:**
MIT License