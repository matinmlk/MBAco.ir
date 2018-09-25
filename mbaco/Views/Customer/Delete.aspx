<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.CustomerModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>حذف</h2>

<h3>برای حذف مورد زیر اطمینان دارید؟</h3>
<fieldset>
    <legend>مشتری</legend>

    <div class="display-label">Name</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Name) %>
    </div>

    <div class="display-label">State</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.State) %>
    </div>

    <div class="display-label">City</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.City) %>
    </div>

    <div class="display-label">Address</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Address) %>
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
