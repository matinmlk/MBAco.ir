<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.CustomerContactModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>حذف</h2>

<h3>برای حذف مورد زیر اطمینان دارید؟</h3>
<fieldset>
    <legend>رابط مشتری</legend>

        <div class="display-label">
            CustomerID</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Customer.Name) %>
        </div>
        <div class="display-label">
            ContactID</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Contact.Name)%>
            <%: Html.Display(" ") %>
            <%: Html.DisplayFor(model => model.Contact.Family)%>
        </div>

    <div class="display-label">Post</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Post) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="حذف" /> |
        <%: Html.ActionLink("بازگشت به لیست", "Index") %>
    </p>
<% } %>

</asp:Content>
