; Script gerado pelo Assistente de Script Inno Setup.
; VEJA A DOCUMENTAÇÃO PARA DETALHES SOBRE A CRIAÇÃO DE ARQUIVOS DE SCRIPT DO INNO SETUP!

#define MyAppName "RevitEasy"
#define MyAppVersion "0.0.1"
#define MyAppPublisher "RevitEasy"
#define MyAppURL "https://github.com/CRUZHENRIQUEDEV/RevitEasy"

[Setup]
; Configurações para o instalador
AppId={{D0A7493A-BFAC-4753-B278-A5E52D372611}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={userappdata}\Roaming\Autodesk\REVIT\Addins\2022\{#MyAppName}
DefaultGroupName={userappdata}\Autodesk\REVIT\Addins\2022\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\0.Installer
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Dirs]
Name: "{userappdata}\Roaming\Autodesk\REVIT\Addins\2022"; Permissions: users-full
Name: "{userappdata}\Autodesk\REVIT\Addins\2022"; Permissions: users-full

[Files]
; Configurações de arquivos para o instalador
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Debug\RevitEasy.dll"; DestDir: "{userappdata}\Roaming\Autodesk\REVIT\Addins\2022\{#MyAppName}"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Debug\RevitEasy.dll.config"; DestDir: "{userappdata}\Roaming\Autodesk\REVIT\Addins\2022\{#MyAppName}"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Debug\RevitEasy.pdb"; DestDir: "{userappdata}\Roaming\Autodesk\REVIT\Addins\2022\{#MyAppName}"; Flags: ignoreversion
