<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.CustomerModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>جزییات</h2>

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
<p>

    <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.CustomerID }) %> |
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</p>

</asp:Content>
