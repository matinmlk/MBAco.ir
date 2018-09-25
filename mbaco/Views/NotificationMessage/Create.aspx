<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.NotificationMessageModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>افزودن</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>پیام اطلاع رسانی</legend>

<%--        <div class="editor-label">
            <%: Html.LabelFor(model => model.CultureID) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CultureID) %>
            <%: Html.ValidationMessageFor(model => model.CultureID) %>
        </div>
--%>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.TypeId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.TypeId, (SelectList)ViewData["Types"])%>
            <%: Html.ValidationMessageFor(model => model.TypeId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Text) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Text) %>
            <%: Html.ValidationMessageFor(model => model.Text) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ShortText) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ShortText) %>
            <%: Html.ValidationMessageFor(model => model.ShortText) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FullText) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FullText) %>
            <%: Html.ValidationMessageFor(model => model.FullText) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>


        <p>
            <input type="submit" value="افزودن" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</div>

</asp:Content>
