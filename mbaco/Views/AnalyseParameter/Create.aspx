<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.AnalayseParameterModel>" %>

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
        <legend>AnalayseParameterModel</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Symbol) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Symbol) %>
            <%: Html.ValidationMessageFor(model => model.Symbol) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.AnalyseParameterTypeId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.AnalyseParameterTypeId, (SelectList)ViewData["AnalyseParameterType"])%>
            <%: Html.ValidationMessageFor(model => model.AnalyseParameterTypeId) %>
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
