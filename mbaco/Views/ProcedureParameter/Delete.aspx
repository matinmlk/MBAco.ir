<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ProcedureParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>حذف</h2>

<h3>برای حذف مورد زیر اطمینان دارید؟</h3>
<fieldset>
    <legend>دستورالعمل پارامتر</legend>

    <div class="display-label">CustomerID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Customer.Name) %>
    </div>

    <div class="display-label">AnalayseParameterID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnalayseParameter.Symbol) %>
    </div>

    <div class="display-label">DangerMaxLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DangerMaxLimit) %>
    </div>

    <div class="display-label">DangerMinLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DangerMinLimit) %>
    </div>

    <div class="display-label">WarningMaxLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.WarningMaxLimit) %>
    </div>

    <div class="display-label">WarningMinLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.WarningMinLimit) %>
    </div>

    <div class="display-label">PossibleMaxLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PossibleMaxLimit) %>
    </div>

    <div class="display-label">PossibleMinLimit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PossibleMinLimit) %>
    </div>

    <div class="display-label">DangerMaxMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DangerMaxMessageId) %>
    </div>

    <div class="display-label">DangerMinMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DangerMinMessageId) %>
    </div>

    <div class="display-label">WarningMaxMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.WarningMaxMessageId) %>
    </div>

    <div class="display-label">WarningMinMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.WarningMinMessageId) %>
    </div>

    <div class="display-label">PossibleMaxMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PossibleMaxMessageId) %>
    </div>

    <div class="display-label">PossibleMinMessageId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PossibleMinMessageId) %>
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
