[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"


[Setup]
DisableWelcomePage=False
AppName=Essentials Team Builder
AppVersion=4.0.0-beta1
AppCopyright=Copyright © TheCrafters001 2024
AppId={{0455C7C5-9C64-465C-B1E5-2C906BB2FB14}
LicenseFile=.\MIT.rtf
SetupIconFile=..\logo\ETB_LOGO_ICON.ico
DefaultDirName={autopf}\TheCrafters001\Essentials Team Builder
AllowUNCPath=False
AppPublisher=TheCrafters001
AppPublisherURL=https://thecrafters001.github.io/
AppSupportURL=https://github.com/TheCrafters001/essentials-team-builder
AppUpdatesURL=https://github.com/TheCrafters001/essentials-team-builder/releases
UninstallDisplayName=Essentials Team Builder
UninstallDisplayIcon={uninstallexe}
VersionInfoVersion=4.0.0
VersionInfoDescription=The EASY Way to Build a Team.
VersionInfoTextVersion=4.0.0-beta1
VersionInfoCopyright=Copyright © TheCrafters001 2024
VersionInfoProductName=Essentials Team Builder
VersionInfoProductTextVersion=4.0.0-beta1
OutputDir=.\
OutputBaseFilename=Essentials.Team.Builder.Setup
ArchitecturesInstallIn64BitMode=x64
ArchitecturesAllowed=x64 x86
Compression=lzma2/ultra64
InternalCompressLevel=ultra64
MinVersion=0,6.1sp1
DefaultGroupName=TheCrafters001\Essentials Team Builder
ShowTasksTreeLines=True
AlwaysShowGroupOnReadyPage=True
AlwaysShowDirOnReadyPage=True
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
WindowVisible=True
WindowResizable=False
WizardResizable=True
BackColor=clGreen

[Dirs]
Name: "{app}\en"
Name: "{app}\en-001"

[Files]
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.EssentialsTeamBuilder.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.EssentialsTeamBuilder.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.TeamGen.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.EssentialsTeamBuilder.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.EssentialsTeamBuilder.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\TheCrafters001.EssentialsTeamBuilder.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\en\TheCrafters001.EssentialsTeamBuilder.resources.dll"; DestDir: "{app}\en"; Flags: ignoreversion
Source: "..\src\Essentials Team Builder\bin\Debug\net8.0-windows7.0\en-001\TheCrafters001.EssentialsTeamBuilder.resources.dll"; DestDir: "{app}\en-001"; Flags: ignoreversion

[Tasks]
Name: "desktop_icon"; Description: "Create Desktop Icon"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "startmenu_icon"; Description: "Create Start Menu Icon"; GroupDescription: "{cm:AdditionalIcons}"

[Icons]
Name: "{group}\Essentials Team Builder"; Filename: "{app}\TheCrafters001.EssentialsTeamBuilder.exe"; IconFilename: "{app}\TheCrafters001.EssentialsTeamBuilder.exe"; IconIndex: 0; Tasks: startmenu_icon
Name: "{commondesktop}\Essentials Team Builder"; Filename: "{app}\TheCrafters001.EssentialsTeamBuilder.exe"; IconFilename: "{app}\TheCrafters001.EssentialsTeamBuilder.exe"; IconIndex: 0; Tasks: desktop_icon

[Messages]
WizardPreparing=Please wait... Preparing...
WelcomeLabel1=[name] Setup
WelcomeLabel2=Thank you for downloading this beta version of [name]! This setup will help guide you through the setup process.%n%nIt is recommended that you close all other applications before continuing.
ReadyLabel1=Congrats! You are ready to install [name]!
BeveledLabel=Essentials Team Builder
