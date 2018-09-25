<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="changePasswordSuccessContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                <%:Resources.Global.ChangePassword%></h2>
        </div>
        <p class="navigation-menu">
        </p>
    </div>

    <p>
        <%:Resources.Global.PasswordChanged %>
    </p>
</asp:Content>
