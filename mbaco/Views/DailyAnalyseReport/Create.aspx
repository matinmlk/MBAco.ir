<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.DailyAnalyseReportModel>" %>

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
        <legend>گزارش روزانه</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CustomerID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.CustomerID, (SelectList)ViewData["Customers"])%>
            <%: Html.ValidationMessageFor(model => model.CustomerID) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ProcedureParameterID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.ProcedureParameterID, (SelectList)ViewData["ProcParams"])%>
            <%: Html.ValidationMessageFor(model => model.ProcedureParameterID) %>
        </div>
<%--
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Date) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Date) %>
            <%: Html.ValidationMessageFor(model => model.Date) %>
        </div>
--%>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DatePersian) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DatePersian) %>
            <%: Html.ValidationMessageFor(model => model.DatePersian) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Value) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Value) %>
            <%: Html.ValidationMessageFor(model => model.Value) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IsApproved) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IsApproved) %>
            <%: Html.ValidationMessageFor(model => model.IsApproved) %>
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
