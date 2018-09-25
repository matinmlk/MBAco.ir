<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.ContactModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    رابط های کاری
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                رابط های کاری</h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create") %>
        </p>
    </div>
    <table class="list-main">
        <tr>
            <th>
                نام
            </th>
            <th>
                نام خانوادگی
            </th>
            <th>
                ایمیل
            </th>
            <th>
                تلفن همراه
            </th>
            <%--        <th>
            CustomerID
        </th>--%>
            <th>
                نام کاربری
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
                <%: Html.DisplayFor(modelItem => item.Name) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Family) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Email) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PhoneNumber) %>
            </td>
            <%--        <td>
            <%: Html.DisplayFor(modelItem => item.CustomerContacts.FirstOrDefault().Customer.Name) %>
        </td>--%>
            <td>
                <%: Html.DisplayFor(modelItem => item.Post) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>
            <td><div class="actions">
                <%: Html.ActionLink("ویرایش", "Edit", new { id=item.ContactID }) %>
                |
                <%: Html.ActionLink("جزییات", "Details", new { id=item.ContactID }) %>
                |
                <%: Html.ActionLink("حذف", "Delete", new { id=item.ContactID }) %>
           </div> </td>
        </tr>
        <% } %>
    </table>
</asp:Content>
