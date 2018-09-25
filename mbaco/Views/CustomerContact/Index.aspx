<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.CustomerContactModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    رابط کاری مشتری بخصوص
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                رابط کاری مشتری بخصوص</h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create") %>
        </p>
    </div>
    <table class="list-main">
        <tr>
            <th>
                رابط کاری
            </th>
            <th>
                مشتری
            </th>
            <th>
                سمت
            </th>
            <th>
                توضیحات
            </th>
            <th>
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem =>  item.Contact.Name )%>
                <%: Html.Display(" ") %>
                <%: Html.DisplayFor(modelItem =>  item.Contact.Family)%>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Customer.Name) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Post) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>
            <td><div class="actions">
                <%: Html.ActionLink("ویرایش", "Edit", new { id=item.CustomerContactID }) %>
                |
                <%: Html.ActionLink("جزییات", "Details", new { id=item.CustomerContactID }) %>
                |
                <%: Html.ActionLink("حذف", "Delete", new { id=item.CustomerContactID }) %>
            </div></td>
        </tr>
        <% } %>
    </table>
</asp:Content>
