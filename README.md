**FILES:**

EyeOfDestinyNet8.csproj – Core project file defining target framework (net8.0-windows), references, NuGet metadata, and build options.

EyeOfDestinyNet8.csproj.user – Developer specific Visual Studio preferences (debug settings, window layout) kept outside version control typically.

EyeOfDestinyNet8.sln – Solution container that maps the single WinForms project into Visual Studio/VS Code.

Program.cs – App entry point; Program.cs configures WinForms visual styles and opens the main form.

Form1.cs – Code behind the UI; Form1.cs seeds the medieval themed answer list, handles button clicks, and updates labels.

Form1.Designer.cs – Auto generated layout code that instantiates controls (buttons, labels, text boxes) and wires their event handlers for TheEyeofDestiny.

Form1.resx – Resource manifest storing localized strings, images, and serialized control data for the WinForms designer.


**OTHER INFO:**

-We used winforms to create this program. (kasi mas madali)
-The program uses .NET 8.0 framework.


**WHATS INSIDE:**

EyeOfDestinyNet8.csproj
- Project uses Microsoft.NET.Sdk: default settings for .NET desktop app.
- OutputType WinExe: builds a Windows GUI executable.
- TargetFramework net8.0-windows: targets .NET 8 on Windows.
- Nullable enable: treat reference types as nullable-aware.
- UseWindowsForms true: include WinForms libraries.
- ImplicitUsings enable: auto-import common namespaces.

EyeOfDestinyNet8.csproj.user
- XML wrapper marking this as a Visual Studio user-settings file.
- Inside, Form1.cs is tagged with SubType = Form, telling the IDE to open it using the WinForms designer.

Program.cs
- Main is the app entry point.
- ApplicationConfiguration.Initialize() sets WinForms defaults (high DPI, fonts).
- Application.Run(new TheEyeofDestiny()) creates and shows the main form, then keeps the message loop running until it closes.

Form1.cs
- 'TheEyeofDestiny : Form' is the main WinForms window.
- answers list holds medieval-style responses; seeded in the constructor.
- Random random picks a response when submitButton_Click fires.
- Placeholder text logic: SetQuestionPlaceholder, questionBox_Enter, and questionBox_Leave swap between hint text and user input color.
- resetButton_Click restores the placeholder and clears the answer

Form1.Designer.cs
- 'InitializeComponent()' builds the form UI.
- Buttons (submitButton, resetButton), text box (questionBox), and labels (answerLabel, title) are created, styled, positioned, and anchored.
- Background image, icon, font, and window size are assigned.
- Event handlers hook up to the code-behind (submitButton_Click, resetButton_Click, etc.).

Form1.resx
- Manifest storing localized strings, images, and serialized control data for the WinForms designer.
