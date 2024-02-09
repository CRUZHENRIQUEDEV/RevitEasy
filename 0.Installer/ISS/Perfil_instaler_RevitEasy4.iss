; Script gerado pelo Inno Setup Script Wizard.
; VEJA A DOCUMENTAÇÃO PARA DETALHES SOBRE A CRIAÇÃO DE ARQUIVOS DE SCRIPT INNO SETUP!

#define MyAppName "Revit Easy Plugin"
#define MyAppVersion "0.03"
#define MyAppPublisher "RevitEasyPlugin"
#define MyAppURL "https://github.com/CRUZHENRIQUEDEV/RevitEasy"

[Setup]
; NOTA: O valor de AppId identifica unicamente esta aplicação. Não use o mesmo valor de AppId em instaladores para outras aplicações.
; (Para gerar um novo GUID, clique em Ferramentas | Gerar GUID dentro do IDE.)
AppId={{A5D782CD-B8DA-431E-8172-413DAAD1957E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName="{userappdata}\Autodesk\REVIT\Addins\2022"
DefaultGroupName=My Program
DisableProgramGroupPage=yes
; Descomente a linha a seguir para executar no modo de instalação não administrativa (instalação apenas para o usuário atual).
; PrivilegesRequired=lowest
OutputDir=D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\0.Installer
OutputBaseFilename=RevitEasyInstaller
SetupIconFile=D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\Resources\Ico\IconInstaller.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Files]
; Adicione cópias dos arquivos para outros diretórios
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2022"; Flags: ignoreversion
;Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll.config"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2022"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.addin"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2022"; Flags: ignoreversion

; Adicione cópias dos arquivos para outros diretórios
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2021"; Flags: ignoreversion
;Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll.config"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2021"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.addin"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2021"; Flags: ignoreversion

Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll.config"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.addin"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion

Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion
;Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.dll.config"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion
Source: "D:\OneDrive - Ali\Programas\Autodesk\REVIT\API\RevitEasy\RevitEasy\bin\Release\RevitEasy.addin"; DestDir: "{userappdata}\Autodesk\REVIT\Addins\2020"; Flags: ignoreversion



; NOTA: Não use "Flags: ignoreversion" em arquivos de sistema compartilhados
