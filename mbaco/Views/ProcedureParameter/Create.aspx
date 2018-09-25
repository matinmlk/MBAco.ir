<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ProcedureParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create</h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>دستورالعمل پارامتر</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.CustomerID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.CustomerID, (SelectList)ViewData["Customers"])%>
            <%: Html.ValidationMessageFor(model => model.CustomerID) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.AnalayseParameterID) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.AnalayseParameterID, (SelectList)ViewData["Params"])%>
            <%: Html.ValidationMessageFor(model => model.AnalayseParameterID) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DangerMaxLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DangerMaxLimit) %>
            <%: Html.ValidationMessageFor(model => model.DangerMaxLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DangerMinLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DangerMinLimit) %>
            <%: Html.ValidationMessageFor(model => model.DangerMinLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.WarningMaxLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.WarningMaxLimit) %>
            <%: Html.ValidationMessageFor(model => model.WarningMaxLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.WarningMinLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.WarningMinLimit) %>
            <%: Html.ValidationMessageFor(model => model.WarningMinLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.PossibleMaxLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PossibleMaxLimit) %>
            <%: Html.ValidationMessageFor(model => model.PossibleMaxLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.PossibleMinLimit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PossibleMinLimit) %>
            <%: Html.ValidationMessageFor(model => model.PossibleMinLimit) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DangerMaxMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.DangerMaxMessageId, (SelectList)ViewData["Msgs"])%>
            <%: Html.ValidationMessageFor(model => model.DangerMaxMessageId) %>
        </div>
        <div class="editor-label"> 
            <%: Html.LabelFor(model => model.DangerMinMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.DangerMinMessageId, (SelectList)ViewData["Msgs"])%>
            <%: Html.ValidationMessageFor(model => model.DangerMinMessageId) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.WarningMaxMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.WarningMaxMessageId, (SelectList)ViewData["Msgs"])%>

            <%: Html.ValidationMessageFor(model => model.WarningMaxMessageId) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.WarningMinMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.WarningMinMessageId, (SelectList)ViewData["Msgs"])%>
            <%: Html.ValidationMessageFor(model => model.WarningMinMessageId) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.PossibleMaxMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.PossibleMaxMessageId, (SelectList)ViewData["Msgs"])%>
            <%: Html.ValidationMessageFor(model => model.PossibleMaxMessageId) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.PossibleMinMessageId) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.PossibleMinMessageId, (SelectList)ViewData["Msgs"])%>
            <%: Html.ValidationMessageFor(model => model.PossibleMinMessageId) %>
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
