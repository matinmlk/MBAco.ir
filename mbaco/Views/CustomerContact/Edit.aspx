<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.CustomerContactModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>رابط مشتری</legend>

        <%: Html.HiddenFor(model => model.CustomerContactID) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CustomerID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.CustomerID, (SelectList)ViewData["Customers"])%>
            <%: Html.ValidationMessageFor(model => model.CustomerID) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ContactID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.ContactID, (SelectList)ViewData["Contacts"])%>
            <%: Html.ValidationMessageFor(model => model.ContactID) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Post) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Post) %>
            <%: Html.ValidationMessageFor(model => model.Post) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>


        <p>
            <input type="submit" value="ذخیره" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</div>

</asp:Content>
