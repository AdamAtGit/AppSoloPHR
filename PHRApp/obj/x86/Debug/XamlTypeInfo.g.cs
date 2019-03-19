﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PHRApp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::PHRApp.PHRApp_XamlTypeInfo.XamlMetaDataProvider __appProvider;
        private global::PHRApp.PHRApp_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMetaDataProvider();
                }
                return __appProvider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return _AppProvider.GetXamlType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return _AppProvider.GetXamlType(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return _AppProvider.GetXmlnsDefinitions();
        }
    }
}

namespace PHRApp.PHRApp_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType) 
            { 
                if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByType(type);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType)
            {
                if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByName(typeName);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            lock (_xamlMembers)
            {
                if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
                {
                    return xamlMember;
                }
                xamlMember = CreateXamlMember(longMemberName);
                if (xamlMember != null)
                {
                    _xamlMembers.Add(longMemberName, xamlMember);
                }
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[21];
            _typeNameTable[0] = "PHRApp.MainPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "PRSapp.UWP.PagesPhone.appAboutPage";
            _typeNameTable[4] = "PRSapp.UWP.PagesPhone.AppCopyWritePage";
            _typeNameTable[5] = "PRSapp.UWP.PagesPhone.AppCreateUserNamePage";
            _typeNameTable[6] = "PRSapp.UWP.PagesPhone.AppDemoPage";
            _typeNameTable[7] = "PRSapp.UWP.PagesPhone.AppHelpPage";
            _typeNameTable[8] = "PRSapp.UWP.PagesPhone.AppProfilePage";
            _typeNameTable[9] = "PRSapp.UWP.PagesPhone.AppResetPwdPage";
            _typeNameTable[10] = "PRSapp.UWP.PagesPhone.AppResetUserNamePage";
            _typeNameTable[11] = "PRSapp.UWP.PagesPhone.AppSettingsOverViewPage";
            _typeNameTable[12] = "PRSapp.UWP.PagesPhone.App3SignInPage";
            _typeNameTable[13] = "PRSapp.UWP.PagesPhone.AppSplashPage";
            _typeNameTable[14] = "PHRApp.Pages.PHR_Page";
            _typeNameTable[15] = "String";
            _typeNameTable[16] = "Int32";
            _typeNameTable[17] = "PHRApp.Pages.TitlesPage";
            _typeNameTable[18] = "PHRApp.UserControls.TitlesUserControl";
            _typeNameTable[19] = "PHRApp.Classes.Title";
            _typeNameTable[20] = "Object";

            _typeTable = new global::System.Type[21];
            _typeTable[0] = typeof(global::PHRApp.MainPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::PRSapp.UWP.PagesPhone.appAboutPage);
            _typeTable[4] = typeof(global::PRSapp.UWP.PagesPhone.AppCopyWritePage);
            _typeTable[5] = typeof(global::PRSapp.UWP.PagesPhone.AppCreateUserNamePage);
            _typeTable[6] = typeof(global::PRSapp.UWP.PagesPhone.AppDemoPage);
            _typeTable[7] = typeof(global::PRSapp.UWP.PagesPhone.AppHelpPage);
            _typeTable[8] = typeof(global::PRSapp.UWP.PagesPhone.AppProfilePage);
            _typeTable[9] = typeof(global::PRSapp.UWP.PagesPhone.AppResetPwdPage);
            _typeTable[10] = typeof(global::PRSapp.UWP.PagesPhone.AppResetUserNamePage);
            _typeTable[11] = typeof(global::PRSapp.UWP.PagesPhone.AppSettingsOverViewPage);
            _typeTable[12] = typeof(global::PRSapp.UWP.PagesPhone.App3SignInPage);
            _typeTable[13] = typeof(global::PRSapp.UWP.PagesPhone.AppSplashPage);
            _typeTable[14] = typeof(global::PHRApp.Pages.PHR_Page);
            _typeTable[15] = typeof(global::System.String);
            _typeTable[16] = typeof(global::System.Int32);
            _typeTable[17] = typeof(global::PHRApp.Pages.TitlesPage);
            _typeTable[18] = typeof(global::PHRApp.UserControls.TitlesUserControl);
            _typeTable[19] = typeof(global::PHRApp.Classes.Title);
            _typeTable[20] = typeof(global::System.Object);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPage() { return new global::PHRApp.MainPage(); }
        private object Activate_3_appAboutPage() { return new global::PRSapp.UWP.PagesPhone.appAboutPage(); }
        private object Activate_4_AppCopyWritePage() { return new global::PRSapp.UWP.PagesPhone.AppCopyWritePage(); }
        private object Activate_5_AppCreateUserNamePage() { return new global::PRSapp.UWP.PagesPhone.AppCreateUserNamePage(); }
        private object Activate_6_AppDemoPage() { return new global::PRSapp.UWP.PagesPhone.AppDemoPage(); }
        private object Activate_7_AppHelpPage() { return new global::PRSapp.UWP.PagesPhone.AppHelpPage(); }
        private object Activate_8_AppProfilePage() { return new global::PRSapp.UWP.PagesPhone.AppProfilePage(); }
        private object Activate_9_AppResetPwdPage() { return new global::PRSapp.UWP.PagesPhone.AppResetPwdPage(); }
        private object Activate_10_AppResetUserNamePage() { return new global::PRSapp.UWP.PagesPhone.AppResetUserNamePage(); }
        private object Activate_11_AppSettingsOverViewPage() { return new global::PRSapp.UWP.PagesPhone.AppSettingsOverViewPage(); }
        private object Activate_12_App3SignInPage() { return new global::PRSapp.UWP.PagesPhone.App3SignInPage(); }
        private object Activate_13_AppSplashPage() { return new global::PRSapp.UWP.PagesPhone.AppSplashPage(); }
        private object Activate_14_PHR_Page() { return new global::PHRApp.Pages.PHR_Page(); }
        private object Activate_17_TitlesPage() { return new global::PHRApp.Pages.TitlesPage(); }
        private object Activate_18_TitlesUserControl() { return new global::PHRApp.UserControls.TitlesUserControl(); }
        private object Activate_19_Title() { return new global::PHRApp.Classes.Title(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  PHRApp.MainPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  PRSapp.UWP.PagesPhone.appAboutPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_appAboutPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  PRSapp.UWP.PagesPhone.AppCopyWritePage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_AppCopyWritePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  PRSapp.UWP.PagesPhone.AppCreateUserNamePage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_AppCreateUserNamePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  PRSapp.UWP.PagesPhone.AppDemoPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_AppDemoPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  PRSapp.UWP.PagesPhone.AppHelpPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_AppHelpPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  PRSapp.UWP.PagesPhone.AppProfilePage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_AppProfilePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  PRSapp.UWP.PagesPhone.AppResetPwdPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_AppResetPwdPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  PRSapp.UWP.PagesPhone.AppResetUserNamePage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_AppResetUserNamePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  PRSapp.UWP.PagesPhone.AppSettingsOverViewPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_AppSettingsOverViewPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  PRSapp.UWP.PagesPhone.App3SignInPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_App3SignInPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  PRSapp.UWP.PagesPhone.AppSplashPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_AppSplashPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  PHRApp.Pages.PHR_Page
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_PHR_Page;
                userType.AddMemberName("CurrentUserName");
                userType.AddMemberName("CurrentUserId");
                userType.AddMemberName("SelectedTitleId");
                userType.AddMemberName("EditTitleId");
                userType.AddMemberName("DeleteTitleId");
                userType.AddMemberName("SpeechInputResult");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  String
                xamlType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 16:   //  Int32
                xamlType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 17:   //  PHRApp.Pages.TitlesPage
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_TitlesPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  PHRApp.UserControls.TitlesUserControl
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_18_TitlesUserControl;
                userType.AddMemberName("Title");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  PHRApp.Classes.Title
                userType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  Object
                xamlType = new global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_PHR_Page_CurrentUserName(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.CurrentUserName;
        }
        private void set_0_PHR_Page_CurrentUserName(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.CurrentUserName = (global::System.String)Value;
        }
        private object get_1_PHR_Page_CurrentUserId(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.CurrentUserId;
        }
        private void set_1_PHR_Page_CurrentUserId(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.CurrentUserId = (global::System.Int32)Value;
        }
        private object get_2_PHR_Page_SelectedTitleId(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.SelectedTitleId;
        }
        private void set_2_PHR_Page_SelectedTitleId(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.SelectedTitleId = (global::System.Int32)Value;
        }
        private object get_3_PHR_Page_EditTitleId(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.EditTitleId;
        }
        private void set_3_PHR_Page_EditTitleId(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.EditTitleId = (global::System.Int32)Value;
        }
        private object get_4_PHR_Page_DeleteTitleId(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.DeleteTitleId;
        }
        private void set_4_PHR_Page_DeleteTitleId(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.DeleteTitleId = (global::System.Int32)Value;
        }
        private object get_5_PHR_Page_SpeechInputResult(object instance)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            return that.SpeechInputResult;
        }
        private void set_5_PHR_Page_SpeechInputResult(object instance, object Value)
        {
            var that = (global::PHRApp.Pages.PHR_Page)instance;
            that.SpeechInputResult = (global::System.String)Value;
        }
        private object get_6_TitlesUserControl_Title(object instance)
        {
            var that = (global::PHRApp.UserControls.TitlesUserControl)instance;
            return that.Title;
        }
        private void set_6_TitlesUserControl_Title(object instance, object Value)
        {
            var that = (global::PHRApp.UserControls.TitlesUserControl)instance;
            that.Title = (global::PHRApp.Classes.Title)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::PHRApp.PHRApp_XamlTypeInfo.XamlMember xamlMember = null;
            global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "PHRApp.Pages.PHR_Page.CurrentUserName":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "CurrentUserName", "String");
                xamlMember.Getter = get_0_PHR_Page_CurrentUserName;
                xamlMember.Setter = set_0_PHR_Page_CurrentUserName;
                break;
            case "PHRApp.Pages.PHR_Page.CurrentUserId":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "CurrentUserId", "Int32");
                xamlMember.Getter = get_1_PHR_Page_CurrentUserId;
                xamlMember.Setter = set_1_PHR_Page_CurrentUserId;
                break;
            case "PHRApp.Pages.PHR_Page.SelectedTitleId":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "SelectedTitleId", "Int32");
                xamlMember.Getter = get_2_PHR_Page_SelectedTitleId;
                xamlMember.Setter = set_2_PHR_Page_SelectedTitleId;
                break;
            case "PHRApp.Pages.PHR_Page.EditTitleId":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "EditTitleId", "Int32");
                xamlMember.Getter = get_3_PHR_Page_EditTitleId;
                xamlMember.Setter = set_3_PHR_Page_EditTitleId;
                break;
            case "PHRApp.Pages.PHR_Page.DeleteTitleId":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "DeleteTitleId", "Int32");
                xamlMember.Getter = get_4_PHR_Page_DeleteTitleId;
                xamlMember.Setter = set_4_PHR_Page_DeleteTitleId;
                break;
            case "PHRApp.Pages.PHR_Page.SpeechInputResult":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.Pages.PHR_Page");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "SpeechInputResult", "String");
                xamlMember.Getter = get_5_PHR_Page_SpeechInputResult;
                xamlMember.Setter = set_5_PHR_Page_SpeechInputResult;
                break;
            case "PHRApp.UserControls.TitlesUserControl.Title":
                userType = (global::PHRApp.PHRApp_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PHRApp.UserControls.TitlesUserControl");
                xamlMember = new global::PHRApp.PHRApp_XamlTypeInfo.XamlMember(this, "Title", "PHRApp.Classes.Title");
                xamlMember.Getter = get_6_TitlesUserControl_Title;
                xamlMember.Setter = set_6_TitlesUserControl_Title;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);
    internal delegate object CreateFromStringMethod(string args);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::PHRApp.PHRApp_XamlTypeInfo.XamlSystemBaseType
    {
        global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            global::System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (CreateFromStringMethod != null)
            {
                return this.CreateFromStringMethod(input);
            }
            else if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }
        public CreateFromStringMethod CreateFromStringMethod {get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::PHRApp.PHRApp_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

