using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevitEasy.CoatingCalculateForm;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class Ribbon : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //////Criando um novo painel dentro da aba complementos 
            ////application.CreateRibbonPanel("Panel 01");

            //////Creando una nueva pestania
            ////application.CreateRibbonTab("Pestaña 01");

            //////Creando paneles dentro de la pestania personalizada

            ////RibbonPanel panelDePestania = application.CreateRibbonPanel("Pestaña 01", "Panel 001");

            ////application.CreateRibbonPanel("Pestaña 01", "Panel 002");
            ////application.CreateRibbonPanel("Pestaña 01", "Panel 003");

            #region CREATE PUSHBUTTON 01
            ////Dando informação ao pushbutton
            //PushButtonData datosDelPushButton = new PushButtonData("Boton 01", "Boton 001", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");

            ////Colocando o PushButton dentro do Panel
            //PushButton pushButton = panelDePestania.AddItem(datosDelPushButton) as PushButton;

            ////Colocando las Propiedades
            //pushButton.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //pushButton.LongDescription = "Esta sera la descipcion larga del PushButton";
            //pushButton.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);

            //ContextualHelp ayudaContextual = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //pushButton.SetContextualHelp(ayudaContextual);

            //pushButton.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton);

            ////Crando una linea de separacion entre herramientas
            //panelDePestania.AddSeparator();
            //#endregion

            //#region CRIANDO UM PUSHBUTTON 02
            ////DAndole la informacion de pushButton
            //PushButtonData datosDelPushButton02 = new PushButtonData("Boton 02", "Boton 002", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");

            ////Colocando las Propiedades
            //datosDelPushButton02.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton02);
            //datosDelPushButton02.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton02.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton02.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual02 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton02.SetContextualHelp(ayudaContextual02);

            ////Colocando el PushButton dentro del Panel
            //panelDePestania.AddItem(datosDelPushButton02);

            ////Crando una linea de separacion entre herramientas
            //panelDePestania.AddSeparator();
            #endregion


            #region CRIANDO PULLDOWNBUTTON
            //PulldownButtonData pullDownButtonData = new PulldownButtonData("PullDowndButton", " PDB 01");
            //PulldownButton pullDownButton = panelDePestania.AddItem(pullDownButtonData) as PulldownButton;
            //pullDownButton.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton02);

            //PushButton 03
            ////PushButtonData datosDelPushButton03 = new PushButtonData("Boton 03", "Boton 003", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            ////datosDelPushButton03.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton);
            ////datosDelPushButton03.ToolTip = "Esta sera la descripcion corta del PushBotton";
            ////datosDelPushButton03.LongDescription = "Esta sera la descipcion larga del PushButton";
            ////datosDelPushButton03.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            ////ContextualHelp ayudaContextual03 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            ////datosDelPushButton03.SetContextualHelp(ayudaContextual03);
            ////pullDownButton.AddPushButton(datosDelPushButton03);

            //////PushButton 04
            ////PushButtonData datosDelPushButton04 = new PushButtonData("Boton 04", "Boton 004", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            ////datosDelPushButton04.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            ////datosDelPushButton04.ToolTip = "Esta sera la descripcion corta del PushBotton";
            ////datosDelPushButton04.LongDescription = "Esta sera la descipcion larga del PushButton";
            ////datosDelPushButton04.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            ////ContextualHelp ayudaContextual04 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            ////datosDelPushButton04.SetContextualHelp(ayudaContextual04);
            ////pullDownButton.AddPushButton(datosDelPushButton04);

            #endregion

            #region CREATE PUSHBUTTON RevitEasy 

            //Create new tab
            application.CreateRibbonTab("RevitEasy");

            //Create panel in tab

            RibbonPanel PanelTabAlvenaria = application.CreateRibbonPanel("RevitEasy", "Wall Projects");

            // Criando uma nova guia (tab) para a nova aba "Wall"

            PulldownButtonData pullDownButtonData = new PulldownButtonData("PullDowndButton", " Wall ");
            PulldownButton pullDownButton = PanelTabAlvenaria.AddItem(pullDownButtonData) as PulldownButton;
            pullDownButton.LargeImage = ConvertImage(Properties.Resources.IconWall);

            #endregion

            #region CREATE PULLDOWNBUTTONS - WALL
          

            // Pushbutton Rename views
            PushButtonData RenameViewsButton = new PushButtonData("RenameViews", "Rename Views", typeof(OpenRenameViewsFormCommand).Assembly.Location, "RevitEasy.OpenRenameViewsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconRename),
                ToolTip = "Rename selected Views",
                LongDescription = "Renames selected views according to an instance parameter contained in the views",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameViews = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            RenameViewsButton.SetContextualHelp(contextualHelpRenameViews);
            pullDownButton.AddPushButton(RenameViewsButton);

            // Pushbutton inserir vistas nas folhas
            PushButtonData InsertViewsOnSheetsButton = new PushButtonData("PlaceViewsOnSheet", "Place Views On Sheet", typeof(OpenInsertViewsOnSheetsFormCommand).Assembly.Location, "RevitEasy.OpenInsertViewsOnSheetsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertViewOnSheet),
                ToolTip = "Place Views On Sheet",
                LongDescription = "Place selected Views Views On Sheet",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpInsertViews = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            InsertViewsOnSheetsButton.SetContextualHelp(contextualHelpInsertViews);
            pullDownButton.AddPushButton(InsertViewsOnSheetsButton);

            // Pushbutton inserir tabelas nas folhas
            PushButtonData pushButtonData = new PushButtonData("InserirTabelasNasFolhas", "Inserir Tabelas nas Folhas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertColun),
                ToolTip = "Insere tabelas nas folhas",
                LongDescription = "Insere tabelas nas folhas de acordo com algum critério",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            PushButtonData InsertSchedulesInSheetsButton = pushButtonData;
            ContextualHelp contextualHelpInsertTables = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            InsertSchedulesInSheetsButton.SetContextualHelp(contextualHelpInsertTables);
            pullDownButton.AddPushButton(InsertSchedulesInSheetsButton);

            // Pushbutton inserir tabelas e elevações nas folhas
            PushButtonData InsertSchedulesAndViewsInSheetsButton = new PushButtonData("PlaceViewsAndSchedulesOnSheets", "Place Views And Schedules On Sheets", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertColun),
                ToolTip = "Place Views And Schedules On Sheets",
                LongDescription = "Place selected Views And Schedules On Sheets",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpInsertSchedulesAndViews = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            InsertSchedulesAndViewsInSheetsButton.SetContextualHelp(contextualHelpInsertSchedulesAndViews);
            pullDownButton.AddPushButton(InsertSchedulesAndViewsInSheetsButton);

            // Pushbutton para renomear tabelas
            PushButtonData RenameSchedulesButton = new PushButtonData("RenameSchedules", "Rename Schedules", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertColun),
                ToolTip = "Rename Schedules",
                LongDescription = "Renomeia tabelas existentes com novos nomes e critérios",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameSchedules = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            RenameSchedulesButton.SetContextualHelp(contextualHelpRenameSchedules);
            pullDownButton.AddPushButton(RenameSchedulesButton);




            #endregion

            #region CREATE PULLDOWNBUTTON -  ÁREAS MOLHADAS

            // Criando um novo painel dentro da aba "RevitEasy" para "Áreas Molhadas"
            RibbonPanel PanelTabAreasMolhadas = application.CreateRibbonPanel("RevitEasy", "Áreas Molhadas");

            // Adicionando um PulldownButton para a nova aba "Áreas Molhadas"
            PulldownButtonData areasMolhadasButtonData = new PulldownButtonData("AreasMolhadasButton", "Áreas Molhadas");
            PulldownButton areasMolhadasButton = PanelTabAreasMolhadas.AddItem(areasMolhadasButtonData) as PulldownButton;
            areasMolhadasButton.LargeImage = ConvertImage(Properties.Resources.IconAreasMolhadas);


            // Pushbutton Criar chamada de detalhe, elevações, vista 3D, folhas, inserir vistas nas folhas
            PushButtonData CreateAllAreasMolhadas = new PushButtonData("CriarChamadaDeDetalheElevacoesVista3DFolhasInserirVistas", "Criar Chamada de Detalhe, Elevações, Vista 3D, Folhas, Inserir Vistas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconCreateAllAreasMolhadas),
                ToolTip = "Cria chamadas de detalhe, elevações, vista 3D, folhas, inserir vistas nas folhas",
                LongDescription = "Cria chamadas de detalhe, elevações, vista 3D, folhas, inserir vistas nas folhas de acordo com o nome da planta",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpCreateAllAreasMolhadas = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            CreateAllAreasMolhadas.SetContextualHelp(contextualHelpCreateAllAreasMolhadas);
            areasMolhadasButton.AddPushButton(CreateAllAreasMolhadas);



            // Pushbutton Criar chamada de detalhe das plantas
            PushButtonData CreateCalloutButton = new PushButtonData("CriarChamadaDeDetalheDasPlantas", "Criar Chamada de Detalhe das Plantas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconCreateCalloutButton),
                ToolTip = "Cria chamadas de detalhe das plantas",
                LongDescription = "Cria chamadas de detalhe das plantas de acordo com o nome da planta",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpCreateCallout = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            CreateCalloutButton.SetContextualHelp(contextualHelpCreateCallout);
            areasMolhadasButton.AddPushButton(CreateCalloutButton);

            // Pushbutton Criar elevações dentro das chamada de detalhe
            PushButtonData CreateElevationsButton = new PushButtonData("CriarElevacoesDentroDasChamadasDeDetalhe", "Criar Elevações dentro das Chamadas de Detalhe", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconCreateElevationsButton),
                ToolTip = "Cria elevações dentro das chamadas de detalhe",
                LongDescription = "Cria elevações dentro das chamadas de detalhe de acordo com o nome da planta",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpCreateElevations = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            CreateElevationsButton.SetContextualHelp(contextualHelpCreateElevations);
            areasMolhadasButton.AddPushButton(CreateElevationsButton);

            // Pushbutton Renomear elevações de áreas molhadas
            PushButtonData RenameElevationsButton = new PushButtonData("RenomearElevacoesDeAreasMolhadas", "Renomear Elevações de Áreas Molhadas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconRenameElevationsButton),
                ToolTip = "Renomeia elevações de áreas molhadas",
                LongDescription = "Renomeia elevações de áreas molhadas de acordo com o nome da planta",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameElevations = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            RenameElevationsButton.SetContextualHelp(contextualHelpRenameElevations);
            areasMolhadasButton.AddPushButton(RenameElevationsButton);

            #endregion

            #region CREATE PULLBUTTON  -  TESTES




            //// Criando um novo painel dentro da aba "RevitEasy" para "Testes"
            //RibbonPanel PanelTabTestes = application.CreateRibbonPanel("RevitEasy", "Testes");

            //// Adicionando um botão para a nova aba "Testes"
            //PushButtonData DeleteWallsButtonData = new PushButtonData("DeleteWallsButton", "Excluir Paredes", typeof(Ribbon).Assembly.Location, "RevitEasy.DeleteWallsCommand")
            //{
            //    LargeImage = ConvertImage(Properties.Resources.IconTests),
            //    ToolTip = "Excluir todas as paredes do modelo",
            //    LongDescription = "Este botão exclui todas as paredes do modelo."
            //};
            //ContextualHelp contextualHelpDeleteWalls = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            //DeleteWallsButtonData.SetContextualHelp(contextualHelpDeleteWalls);
            //PanelTabTestes.AddItem(DeleteWallsButtonData);



            #endregion

            #region CREATE PULLBUTTON  - Documentation

            // Criando um novo painel dentro da aba "RevitEasy" para "Documentação"
            RibbonPanel PanelTabDocumentacao = application.CreateRibbonPanel("RevitEasy", "  Documentation  ");

            // Adicionando um PulldownButton para a nova aba "Documentação"
            PulldownButtonData DocumentacaoButtonData = new PulldownButtonData("DocumentationButton", "Documentation");
            PulldownButton DocumentacaoButton = PanelTabDocumentacao.AddItem(DocumentacaoButtonData) as PulldownButton;
            DocumentacaoButton.LargeImage = ConvertImage(Properties.Resources.IconDocument32x32);

            // Pushbutton "Create Sheet" no painel "Documentation"
            PushButtonData CreateSheetButtonData = new PushButtonData("CreateSheetsButton", "Create Sheets", typeof(OpenCreateSheetsFormCommand).Assembly.Location, "RevitEasy.OpenCreateSheetsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.NewSheets),
                ToolTip = "Create Sheets",
                LongDescription = "Create Multiple Sheets ",
                ToolTipImage = ConvertImage(Properties.Resources.NewSheets)
            };

            ContextualHelp contextualHelpCreateSheet = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            CreateSheetButtonData.SetContextualHelp(contextualHelpCreateSheet);
            DocumentacaoButton.AddPushButton(CreateSheetButtonData);


            // Pushbutton "Criar Tabela" no painel "Documentação"
            PushButtonData DuplicateSchedulesButton = new PushButtonData("DuplicastabelasButton", "Duplicate Schedules", typeof(OpenDuplicateScheduleFormCommand).Assembly.Location, "RevitEasy.OpenDuplicateScheduleFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconDuplicate32x32),
                ToolTip = "Duplicate Schedules",
                LongDescription = "Rename Schedules and apply new values for filters",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };

            ContextualHelp contextualHelpDuplicateSchedules = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            DuplicateSchedulesButton.SetContextualHelp(contextualHelpDuplicateSchedules);
            DocumentacaoButton.AddPushButton(DuplicateSchedulesButton);

            // Pushbutton "Duplicate Views" in the label "Documentação"
            PushButtonData DuplicateViewsButtonData = new PushButtonData("DuplicateViewsButton", "Duplicate Views", typeof(OpenDuplicateViewsFormCommand).Assembly.Location, "RevitEasy.OpenDuplicateViewsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconDuplicateViews32x32),
                ToolTip = "Duplicate Views",
                LongDescription = "Duplicate Multiple Views",
                ToolTipImage = ConvertImage(Properties.Resources.IconDuplicateViews32x32)
            };

            ContextualHelp contextualHelpDuplicateViews = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/duplicate-views-help");
            DuplicateViewsButtonData.SetContextualHelp(contextualHelpDuplicateViews);
            DocumentacaoButton.AddPushButton(DuplicateViewsButtonData);

            // Pushbutton "Renumber Sheets" in the label "Documentation"
            PushButtonData RenumberSheetsButtonData = new PushButtonData("RenumberSheetsButton", "Renumber Sheets", typeof(OpenRenumberSheetsFormCommand).Assembly.Location, "RevitEasy.OpenRenumberSheetsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconChangeNumber32x32),
                ToolTip = "Renumber Sheets",
                LongDescription = "Renumber Multiple Sheets",
                ToolTipImage = ConvertImage(Properties.Resources.IconChangeNumber32x32)
            };

            ContextualHelp contextualHelpRenumberSheets = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/renumber-sheets-help");
            RenumberSheetsButtonData.SetContextualHelp(contextualHelpRenumberSheets);
            DocumentacaoButton.AddPushButton(RenumberSheetsButtonData);

            // Pushbutton "Rename Sheets" in the label "Documentation"
            PushButtonData RenameSheetsButtonData = new PushButtonData("RenameSheetsButton", "Rename Sheets", typeof(OpenRenameSheetFormCommand).Assembly.Location, "RevitEasy.OpenRenameSheetFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconRenameSheets32x32),
                ToolTip = "Rename Sheets",
                LongDescription = "Rename Multiple Sheets",
                ToolTipImage = ConvertImage(Properties.Resources.IconRenameSheets32x32)
            };

            ContextualHelp contextualHelpRenameSheets = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/rename-sheets-help");
            RenameSheetsButtonData.SetContextualHelp(contextualHelpRenameSheets);
            DocumentacaoButton.AddPushButton(RenameSheetsButtonData);


            #endregion

            #region CREATE PULLBUTTON  -  Tools
            // Criando um novo painel dentro da aba "RevitEasy" para "Ferramentas"
            RibbonPanel PanelTabTools = application.CreateRibbonPanel("RevitEasy", " Tools ");

            // Adicionando um PulldownButton para a nova aba "Ferramentas"
            PulldownButtonData ToolsButtonData = new PulldownButtonData("ToolsButton", " Tools ");
            PulldownButton ToolsButton = PanelTabTools.AddItem(ToolsButtonData) as PulldownButton;
            ToolsButton.LargeImage = ConvertImage(Properties.Resources.IconTools32x32);

            // Pushbutton "Cálculo de revestimento" no painel "Ferramentas"
            PushButtonData CoatingCalculateButtonData = new PushButtonData("CalcularRevestimentoButton", "Calculate", typeof(OpenCoatingCalculateFormCommand).Assembly.Location, "RevitEasy.OpenCoatingCalculateFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconCalculateGif),
                ToolTip = "Calcular peças de revestimentos",
                LongDescription = "Calculadora de quantidade de peças de revestimento",
                ToolTipImage = ConvertImage(Properties.Resources.IconCalculateGif)
            };

            ContextualHelp contextualHelpTools = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            CoatingCalculateButtonData.SetContextualHelp(contextualHelpTools);  // Correção aqui
            ToolsButton.AddPushButton(CoatingCalculateButtonData);  // Correção aqui
            #endregion

            #region CREATE PULLBUTTON - ABOUT

            // Criando um novo painel dentro da aba "RevitEasy" para "About"
            RibbonPanel PanelTabAbout = application.CreateRibbonPanel("RevitEasy", "About");

            // Adicionando um PulldownButton para a nova aba "About"
            PulldownButtonData aboutButtonData = new PulldownButtonData("AboutButton", "About");
            PulldownButton aboutButton = PanelTabAbout.AddItem(aboutButtonData) as PulldownButton;
            aboutButton.LargeImage = ConvertImage(Properties.Resources.IconAboutButton32x32);

            // Pushbutton para exibir informações sobre o plug-in
            PushButtonData showInfoButton = new PushButtonData("ShowInfoButton", "About ", typeof(OpenAboutFormCommand).Assembly.Location, "RevitEasy.OpenAboutFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconAboutButton50x50),
                ToolTip = "Exibe informações sobre o plug-in",
                LongDescription = "Info",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpShowInfo = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            showInfoButton.SetContextualHelp(contextualHelpShowInfo);
            aboutButton.AddPushButton(showInfoButton);

            // Adicione mais PushButtonData conforme necessário para outras funcionalidades relacionadas ao "About".

            #endregion



            //-----------------------------------------------------------------------------------------------------------------------------------------------

            #region CRIANDO UM SPLITBUTTON
            //SplitButtonData splitButtonData = new SplitButtonData("SplitButton", "SB 01");
            //SplitButton splitButton = panelDePestania.AddItem(splitButtonData) as SplitButton;


            ////PushButton 05
            //PushButtonData datosDelPushButton05 = new PushButtonData("Boton 05", "Boton 005", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton05.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            //datosDelPushButton05.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton05.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton05.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual05 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton05.SetContextualHelp(ayudaContextual05);
            //splitButton.AddPushButton(datosDelPushButton05);

            ////PushButton 06
            //PushButtonData datosDelPushButton06 = new PushButtonData("Boton 06", "Boton 006", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton06.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton);
            //datosDelPushButton06.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton06.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton06.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual06 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton06.SetContextualHelp(ayudaContextual06);
            //splitButton.AddPushButton(datosDelPushButton06);

            #endregion

            #region CRIANDO O RADIOBUTTONGROUP
            //RadioButtonGroupData radioButtonGroupData = new RadioButtonGroupData("RadioButtonGroup");
            //RadioButtonGroup radioButtonGroup = panelDePestania.AddItem(radioButtonGroupData) as RadioButtonGroup;

            //ToggleButtonData toggleButtonData = new ToggleButtonData("ToggleButton", "TB - 01", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //toggleButtonData.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton);
            //toggleButtonData.ToolTip = "Esta sera la descripcion corta del ToggleButton";
            //toggleButtonData.LongDescription = "Esta sera la descipcion larga del ToggleButton";
            //toggleButtonData.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp contextualHelpTB_01 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //toggleButtonData.SetContextualHelp(contextualHelpTB_01);
            //radioButtonGroup.AddItem(toggleButtonData);

            //ToggleButtonData toggleButtonData_02 = new ToggleButtonData("ToggleButton02", "TB - 02", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //toggleButtonData_02.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            //toggleButtonData_02.ToolTip = "Esta sera la descripcion corta del ToggleButton";
            //toggleButtonData_02.LongDescription = "Esta sera la descipcion larga del ToggleButton";
            //toggleButtonData_02.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp contextualHelpTB_02 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //toggleButtonData_02.SetContextualHelp(contextualHelpTB_02);
            //radioButtonGroup.AddItem(toggleButtonData_02);

            #endregion

            #region CRIANDO UM STACKEDITEMS
            ////PushButton 07
            //PushButtonData datosDelPushButton07 = new PushButtonData("Boton 07", "Boton 007", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton07.Image = ConvertImage(Properties.Resources.IconoDePushButton);
            //datosDelPushButton07.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton07.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton07.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual07 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton07.SetContextualHelp(ayudaContextual07);

            ////PushButton 08
            //PushButtonData datosDelPushButton08 = new PushButtonData("Boton 08", "Boton 008", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton08.Image = ConvertImage(Properties.Resources.IconoDePushButton02);
            //datosDelPushButton08.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton08.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton08.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual08 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton08.SetContextualHelp(ayudaContextual08);

            ////PushButton 09
            //PushButtonData datosDelPushButton09 = new PushButtonData("Boton 09", "Boton 009", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton09.Image = ConvertImage(Properties.Resources.IconoDePushButton03);
            //datosDelPushButton09.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton09.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton09.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual09 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //datosDelPushButton09.SetContextualHelp(ayudaContextual09);

            //panelDePestania.AddStackedItems(datosDelPushButton07, datosDelPushButton08, datosDelPushButton09);
            #endregion

            #region CRIANDO UM COMBOBOX
            //ComboBoxData comboBoxData = new ComboBoxData("ComboBox");
            //ComboBox comboBox = panelDePestania.AddItem(comboBoxData) as ComboBox;
            //comboBox.Image = ConvertImage(Properties.Resources.IconoDePushButton02);
            //comboBox.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBox.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBox.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCB = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //comboBox.SetContextualHelp(ayudaContextualCB);

            ////Item 01
            //ComboBoxMemberData comboBoxMemberData = new ComboBoxMemberData("CBM-01", "Item 01");
            //comboBoxMemberData.GroupName = "Grupo 01";
            //comboBoxMemberData.Image = ConvertImage(Properties.Resources.IconoDePushButton);
            //comboBoxMemberData.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_01 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //comboBoxMemberData.SetContextualHelp(ayudaContextualCBM_01);
            //comboBox.AddItem(comboBoxMemberData);

            ////Item 02
            //ComboBoxMemberData comboBoxMemberData_02 = new ComboBoxMemberData("CBM-02", "Item 02");
            //comboBoxMemberData_02.GroupName = "Grupo 01";
            //comboBoxMemberData_02.Image = ConvertImage(Properties.Resources.IconoDePushButton03);
            //comboBoxMemberData_02.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData_02.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData_02.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_02 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //comboBoxMemberData_02.SetContextualHelp(ayudaContextualCBM_02);
            //comboBox.AddItem(comboBoxMemberData_02);


            ////Item 03
            //ComboBoxMemberData comboBoxMemberData_03 = new ComboBoxMemberData("CBM-03", "Item 03");
            //comboBoxMemberData_03.GroupName = "Grupo 02";
            //comboBoxMemberData_03.Image = ConvertImage(Properties.Resources.IconoDePushButton02);
            //comboBoxMemberData_03.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData_03.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData_03.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_03 = new ContextualHelp(ContextualHelpType.Url, "https://github.com/CRUZHENRIQUEDEV/RevitEasy");
            //comboBoxMemberData_03.SetContextualHelp(ayudaContextualCBM_03);
            //comboBox.AddItem(comboBoxMemberData_03);


            ////Creando Evento
            //comboBox.CurrentChanged += new EventHandler<ComboBoxCurrentChangedEventArgs>(Evento_ComboBox);




            #endregion


            return Result.Succeeded;
        }

        //private void Evento_ComboBox(object sender, ComboBoxCurrentChangedEventArgs e)
        //{
        //    ComboBox comboBoxEventData = sender as ComboBox;

        //    if (comboBoxEventData.Current.ItemText == "Item 01")
        //    {
        //        TaskDialog.Show("Titulo", "Voce está utilizando o primeiro item do comoBox");
        //    }
        //    else if (comboBoxEventData.Current.ItemText == "Item 02")
        //    {
        //        TaskDialog.Show("Titulo", "Voce está utilizando o segundo item do comoBox");
        //    }
        //    else
        //    {
        //        TaskDialog.Show("Titulo", "Voce está utilizando o terceiro item do comoBoxx");
        //    }

        //}


        #region CRIANDO UM MÉTODO PARA CONVERTER UM SYSTEM.DRAWING.BIPMAP EM SYSTEM.WINDOWNS.MEDIA.IMAGESOURCE ---------- É NECESSÁRIO PARA CHAMAR A REFERENCIA EXTERNA - WindowsBase E - PresentationCore
        private System.Windows.Media.ImageSource ConvertImage(System.Drawing.Image image)
        {
            var bitmap = new System.Windows.Media.Imaging.BitmapImage();
            bitmap.BeginInit();
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            bitmap.StreamSource = memoryStream;
            bitmap.EndInit();
            return bitmap;
        }
        #endregion



    }
}
