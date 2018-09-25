<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<mbaco.Models.RegisterModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
<% using (Html.BeginForm()) { %>
  <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                <%:Resources.Global.NewUser %></h2>
        </div>
        <p class="navigation-menu">
            <input type="submit" value="ثبت" />            
        </p>
    </div>

        <%:Html.Hidden("guid", TempData["guid"])%>    
        <%:Html.Hidden("accId",TempData["accId"]) %>    
        <%: Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again.") %>
            <table class="create-main">
               <tr>
               <td class="editor-label">
                    <%: Html.LabelFor(m => m.Email)%>
                </td>-
                <td class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.Email)%>
                </td>
                </tr><tr>
<%--                <td class="editor-label">
                    <%: Html.LabelFor(m => m.Email) %>
                </td>
                <td class="editor-field">
                    <%: Html.TextBoxFor(m => m.Email) %>
                    <%: Html.ValidationMessageFor(m => m.Email) %>
                </td>
--%>                
                <td class="editor-label">
                    <%: Html.LabelFor(m => m.Password) %>
                </td>
                <td class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </td>
                </tr><tr>
                <td class="editor-label">
                    <%: Html.LabelFor(m => m.ConfirmPassword) %>
                </td>
                <td class="editor-field">
                    <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                    <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </td>
                </tr>
              
            </table>
    <% } %>
</asp:Content>
