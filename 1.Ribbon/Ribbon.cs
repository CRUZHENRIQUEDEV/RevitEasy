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

            //ContextualHelp ayudaContextual = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            //ContextualHelp ayudaContextual02 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            ////ContextualHelp ayudaContextual03 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            ////datosDelPushButton03.SetContextualHelp(ayudaContextual03);
            ////pullDownButton.AddPushButton(datosDelPushButton03);

            //////PushButton 04
            ////PushButtonData datosDelPushButton04 = new PushButtonData("Boton 04", "Boton 004", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            ////datosDelPushButton04.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            ////datosDelPushButton04.ToolTip = "Esta sera la descripcion corta del PushBotton";
            ////datosDelPushButton04.LongDescription = "Esta sera la descipcion larga del PushButton";
            ////datosDelPushButton04.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            ////ContextualHelp ayudaContextual04 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            ////datosDelPushButton04.SetContextualHelp(ayudaContextual04);
            ////pullDownButton.AddPushButton(datosDelPushButton04);

            #endregion

            #region CREATE PUSHBUTTON RevitEasy 

            //Create new tab
            application.CreateRibbonTab("RevitEasy");

            //Create panel in tab

            RibbonPanel PanelTabAlvenaria = application.CreateRibbonPanel("RevitEasy", "Projetos de alvenaria");


            // Criando uma nova guia (tab) para a nova aba "Alvenaria"

            PulldownButtonData pullDownButtonData = new PulldownButtonData("PullDowndButton", "Alvenaria");
            PulldownButton pullDownButton = PanelTabAlvenaria.AddItem(pullDownButtonData) as PulldownButton;
            pullDownButton.LargeImage = ConvertImage(Properties.Resources.IconWall);
            #endregion

            #region CREATE PULLDOWNBUTTONS - ALVENARIA
            //Pullbutton create sheets
            PushButtonData CreateSheetButton = new PushButtonData("Criar folhas", "Criar novas folhas", typeof(OpenCreateSheetFormCommand).Assembly.Location, "RevitEasy.OpenCreateSheetFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconDuplicate),
                ToolTip = "Cria várias folhas",
                LongDescription = "Cria várias folhas novas no projeto onde o usuário poderá definir número, nome e família das novas folhas",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp ayudaContextual03 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            CreateSheetButton.SetContextualHelp(ayudaContextual03);
            pullDownButton.AddPushButton(CreateSheetButton);


            // Pushbutton renomear vistas
            PushButtonData RenameViewsButton = new PushButtonData("RenomearVistas", "Renomear Vistas", typeof(OpenRenameViewsFormCommand).Assembly.Location, "RevitEasy.OpenRenameViewsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconRename),
                ToolTip = "Renomeia as vistas existentes",
                LongDescription = "Renomeia as vistas existentes de acordo um parametro de instancia contido nas vistas ",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameViews = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            RenameViewsButton.SetContextualHelp(contextualHelpRenameViews);
            pullDownButton.AddPushButton(RenameViewsButton);

            // Pushbutton inserir vistas nas folhas
            PushButtonData InsertViewsOnSheetsButton = new PushButtonData("InserirVistasNasFolhas", "Inserir Vistas nas Folhas", typeof(OpenInsertViewsOnSheetsFormCommand).Assembly.Location, "RevitEasy.OpenInsertViewsOnSheetsFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertViewOnSheet),
                ToolTip = "Insere as vistas nas folhas",
                LongDescription = "Insere as vistas nas folhas de acordo com algum critério",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpInsertViews = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            ContextualHelp contextualHelpInsertTables = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            InsertSchedulesInSheetsButton.SetContextualHelp(contextualHelpInsertTables);
            pullDownButton.AddPushButton(InsertSchedulesInSheetsButton);

            // Pushbutton inserir tabelas e elevações nas folhas
            PushButtonData InsertSchedulesAndViewsInSheetsButton = new PushButtonData("InserirTabelasElevacoesNasFolhas", "Inserir Tabelas e Elevações nas Folhas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertColun),
                ToolTip = "Insere tabelas e elevações nas folhas",
                LongDescription = "Insere tabelas e elevações nas folhas de acordo com algum critério",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpInsertSchedulesAndViews = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            InsertSchedulesAndViewsInSheetsButton.SetContextualHelp(contextualHelpInsertSchedulesAndViews);
            pullDownButton.AddPushButton(InsertSchedulesAndViewsInSheetsButton);

            // Pushbutton para renomear tabelas
            PushButtonData RenameSchedulesButton = new PushButtonData("RenomearTabelas", "Renomear Tabelas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconInsertColun),
                ToolTip = "Renomeia tabelas existentes",
                LongDescription = "Renomeia tabelas existentes com novos nomes e critérios",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameSchedules = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            RenameSchedulesButton.SetContextualHelp(contextualHelpRenameSchedules);
            pullDownButton.AddPushButton(RenameSchedulesButton);

            // Pushbutton para renomear folhas
            PushButtonData RenameSheetsButton = new PushButtonData("RenomearFolhas", "Renomear Folhas", typeof(Ribbon).Assembly.Location, "RevitEasy.ToolsInDevelopment")
            {
                LargeImage = ConvertImage(Properties.Resources.IconRename),
                ToolTip = "Renomeia folhas existentes",
                LongDescription = "Renomeia folhas existentes com novos nomes e  números",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };
            ContextualHelp contextualHelpRenameSheets = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            RenameSheetsButton.SetContextualHelp(contextualHelpRenameSheets);
            pullDownButton.AddPushButton(RenameSheetsButton);


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
            ContextualHelp contextualHelpCreateAllAreasMolhadas = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            ContextualHelp contextualHelpCreateCallout = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            ContextualHelp contextualHelpCreateElevations = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            ContextualHelp contextualHelpRenameElevations = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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

            #region CREATE PULLBUTTON  - DOCUMENTAÇÃO

            // Criando um novo painel dentro da aba "RevitEasy" para "Documentação"
            RibbonPanel PanelTabDocumentacao = application.CreateRibbonPanel("RevitEasy", "Documentação");

            // Adicionando um PulldownButton para a nova aba "Documentação"
            PulldownButtonData DocumentacaoButtonData = new PulldownButtonData("DocumentacaoButton", "Documentação");
            PulldownButton DocumentacaoButton = PanelTabDocumentacao.AddItem(DocumentacaoButtonData) as PulldownButton;
            DocumentacaoButton.LargeImage = ConvertImage(Properties.Resources.IconDocument_32x32);

            // Pushbutton "Criar Folha" no painel "Documentação"
            PushButtonData CreateSheetButtonData = new PushButtonData("CriarFolhaButton", "Criar Folha", typeof(OpenCreateSheetFormCommand).Assembly.Location, "RevitEasy.OpenCreateSheetFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.NewSheets),
                ToolTip = "Criar Folhas",
                LongDescription = "Abre o formulário para criar diversas folhas no projeto ",
                ToolTipImage = ConvertImage(Properties.Resources.NewSheets)
            };

            ContextualHelp contextualHelpCreateSheet = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            CreateSheetButtonData.SetContextualHelp(contextualHelpCreateSheet);
            DocumentacaoButton.AddPushButton(CreateSheetButtonData);


            // Pushbutton "Criar Tabela" no painel "Documentação"
            PushButtonData DuplicateSchedulesButton = new PushButtonData("DuplicastabelasButton", "Duplicar uma tabela", typeof(OpenDuplicateScheduleFormCommand).Assembly.Location, "RevitEasy.OpenDuplicateScheduleFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconDuplicate),
                ToolTip = "Duplica uma tabela existente",
                LongDescription = "Duplica uma tabela existente criando novos nomes e filtros inseridos",
                ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs)
            };

            ContextualHelp contextualHelpDuplicateSchedules = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            DuplicateSchedulesButton.SetContextualHelp(contextualHelpDuplicateSchedules);
            DocumentacaoButton.AddPushButton(DuplicateSchedulesButton);








            #endregion

            #region CREATE PULLBUTTON  -  FERRAMENTAS
            // Criando um novo painel dentro da aba "RevitEasy" para "Ferramentas"
            RibbonPanel PanelTabTools = application.CreateRibbonPanel("RevitEasy", "Ferramentas");

            // Adicionando um PulldownButton para a nova aba "Ferramentas"
            PulldownButtonData ToolsButtonData = new PulldownButtonData("ToolsButton", "Ferramentas");
            PulldownButton ToolsButton = PanelTabTools.AddItem(ToolsButtonData) as PulldownButton;
            ToolsButton.LargeImage = ConvertImage(Properties.Resources.IconCalculateButton);

            // Pushbutton "Cálculo de revestimento" no painel "Ferramentas"
            PushButtonData CoatingCalculateButtonData = new PushButtonData("CalcularRevestimentoButton", "Calcular peças de revestimentos", typeof(OpenCoatingCalculateFormCommand).Assembly.Location, "RevitEasy.OpenCoatingCalculateFormCommand")
            {
                LargeImage = ConvertImage(Properties.Resources.IconCalculateButton),
                ToolTip = "Calcular peças de revestimentos",
                LongDescription = "Calculadora de quantidade de peças de revestimento",
                ToolTipImage = ConvertImage(Properties.Resources.IconCalculateButton)
            };

            ContextualHelp contextualHelpTools = new ContextualHelp(ContextualHelpType.Url, "https://www.example.com/help");
            CoatingCalculateButtonData.SetContextualHelp(contextualHelpTools);  // Correção aqui
            ToolsButton.AddPushButton(CoatingCalculateButtonData);  // Correção aqui
            #endregion


            #region CRIANDO UM SPLITBUTTON
            //SplitButtonData splitButtonData = new SplitButtonData("SplitButton", "SB 01");
            //SplitButton splitButton = panelDePestania.AddItem(splitButtonData) as SplitButton;


            ////PushButton 05
            //PushButtonData datosDelPushButton05 = new PushButtonData("Boton 05", "Boton 005", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton05.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            //datosDelPushButton05.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton05.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton05.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual05 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //datosDelPushButton05.SetContextualHelp(ayudaContextual05);
            //splitButton.AddPushButton(datosDelPushButton05);

            ////PushButton 06
            //PushButtonData datosDelPushButton06 = new PushButtonData("Boton 06", "Boton 006", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton06.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton);
            //datosDelPushButton06.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton06.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton06.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual06 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            //ContextualHelp contextualHelpTB_01 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //toggleButtonData.SetContextualHelp(contextualHelpTB_01);
            //radioButtonGroup.AddItem(toggleButtonData);

            //ToggleButtonData toggleButtonData_02 = new ToggleButtonData("ToggleButton02", "TB - 02", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //toggleButtonData_02.LargeImage = ConvertImage(Properties.Resources.IconoDePushButton03);
            //toggleButtonData_02.ToolTip = "Esta sera la descripcion corta del ToggleButton";
            //toggleButtonData_02.LongDescription = "Esta sera la descipcion larga del ToggleButton";
            //toggleButtonData_02.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp contextualHelpTB_02 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            //ContextualHelp ayudaContextual07 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //datosDelPushButton07.SetContextualHelp(ayudaContextual07);

            ////PushButton 08
            //PushButtonData datosDelPushButton08 = new PushButtonData("Boton 08", "Boton 008", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton08.Image = ConvertImage(Properties.Resources.IconoDePushButton02);
            //datosDelPushButton08.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton08.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton08.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual08 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //datosDelPushButton08.SetContextualHelp(ayudaContextual08);

            ////PushButton 09
            //PushButtonData datosDelPushButton09 = new PushButtonData("Boton 09", "Boton 009", typeof(Class1).Assembly.Location, "RevitEasy.ToolsInDevelopment");
            //datosDelPushButton09.Image = ConvertImage(Properties.Resources.IconoDePushButton03);
            //datosDelPushButton09.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //datosDelPushButton09.LongDescription = "Esta sera la descipcion larga del PushButton";
            //datosDelPushButton09.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextual09 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
            //ContextualHelp ayudaContextualCB = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //comboBox.SetContextualHelp(ayudaContextualCB);

            ////Item 01
            //ComboBoxMemberData comboBoxMemberData = new ComboBoxMemberData("CBM-01", "Item 01");
            //comboBoxMemberData.GroupName = "Grupo 01";
            //comboBoxMemberData.Image = ConvertImage(Properties.Resources.IconoDePushButton);
            //comboBoxMemberData.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_01 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //comboBoxMemberData.SetContextualHelp(ayudaContextualCBM_01);
            //comboBox.AddItem(comboBoxMemberData);

            ////Item 02
            //ComboBoxMemberData comboBoxMemberData_02 = new ComboBoxMemberData("CBM-02", "Item 02");
            //comboBoxMemberData_02.GroupName = "Grupo 01";
            //comboBoxMemberData_02.Image = ConvertImage(Properties.Resources.IconoDePushButton03);
            //comboBoxMemberData_02.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData_02.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData_02.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_02 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
            //comboBoxMemberData_02.SetContextualHelp(ayudaContextualCBM_02);
            //comboBox.AddItem(comboBoxMemberData_02);


            ////Item 03
            //ComboBoxMemberData comboBoxMemberData_03 = new ComboBoxMemberData("CBM-03", "Item 03");
            //comboBoxMemberData_03.GroupName = "Grupo 02";
            //comboBoxMemberData_03.Image = ConvertImage(Properties.Resources.IconoDePushButton02);
            //comboBoxMemberData_03.ToolTip = "Esta sera la descripcion corta del PushBotton";
            //comboBoxMemberData_03.LongDescription = "Esta sera la descipcion larga del PushButton";
            //comboBoxMemberData_03.ToolTipImage = ConvertImage(Properties.Resources.RevitApiDocs);
            //ContextualHelp ayudaContextualCBM_03 = new ContextualHelp(ContextualHelpType.Url, "https://www.revitapidocs.com/");
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
