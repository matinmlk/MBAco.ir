<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ContactModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>جزییات</h2>

<fieldset>
    <legend>رابط کاری</legend>

    <div class="display-label">Name</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Name) %>
    </div>

    <div class="display-label">Family</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Family) %>
    </div>

    <div class="display-label">Email</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label">PhoneNumber</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PhoneNumber) %>
    </div>
<%--
    <div class="display-label">CustomerID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CustomerID) %>
    </div>--%>

    <div class="display-label">Post</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Post) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

</fieldset>
<p>

    <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.ContactID }) %> |
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</p>

</asp:Content>
