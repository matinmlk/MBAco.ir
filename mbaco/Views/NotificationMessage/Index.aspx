<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.NotificationMessageModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    پیام ها، هشدار ها و اخطارهای سیستمی
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                پیام ها، هشدار ها و اخطارهای سیستمی
            </h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create") %>
        </p>
    </div>
    <table class="list-main">

            <tr>
                <%--        <th>
            CultureID
        </th>--%>
                <th>
                    نوع
                </th>
                <th>
                    متن
                </th>
                <th>
                    متن کوتاه
                </th>
                <th>
                    متن کامل
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
                <%--        <td>
            <%: Html.DisplayFor(modelItem => item.CultureID) %>
        </td>--%>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Type.Name) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Text) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.ShortText) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.FullText) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Comment) %>
                </td>
                <td><div class="actions">
                    <%: Html.ActionLink("ویرایش", "Edit", new { id=item.NotificationMessageID }) %>
                    |
                    <%: Html.ActionLink("جزییات", "Details", new { id=item.NotificationMessageID }) %>
                    |
                    <%: Html.ActionLink("حذف", "Delete", new { id=item.NotificationMessageID }) %>
                </div></td>
            </tr>
            <% } %>
        </table>
</asp:Content>
