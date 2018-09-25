<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ProcedureParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Details</h2>
    <fieldset>
        <legend>دستورالعمل پارامتر</legend>
        <div class="display-label">
            CustomerID</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Customer.Name) %>
        </div>
        <div class="display-label">
            AnalayseParameterID</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.AnalayseParameter.Symbol) %>
        </div>
        <div class="display-label">
            DangerMaxLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DangerMaxLimit) %>
        </div>
        <div class="display-label">
            DangerMinLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DangerMinLimit) %>
        </div>
        <div class="display-label">
            WarningMaxLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.WarningMaxLimit) %>
        </div>
        <div class="display-label">
            WarningMinLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.WarningMinLimit) %>
        </div>
        <div class="display-label">
            PossibleMaxLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PossibleMaxLimit) %>
        </div>
        <div class="display-label">
            PossibleMinLimit</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PossibleMinLimit) %>
        </div>
        <div class="display-label">
            DangerMaxMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DangerMaxMessage.Text)%>
        </div>
        <div class="display-label">
            DangerMinMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DangerMinMessage.Text)%>
        </div>
        <div class="display-label">
            WarningMaxMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.WarningMaxMessage.Text)%>
        </div>
        <div class="display-label">
            WarningMinMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.WarningMinMessage.Text)%>
        </div>
        <div class="display-label">
            PossibleMaxMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PossibleMaxMessage.Text)%>
        </div>
        <div class="display-label">
            PossibleMinMessageId</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PossibleMinMessage.Text ) %>
        </div>
        <div class="display-label">
            Comment</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Comment) %>
        </div>
    </fieldset>
    <p>
        <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.ProcedureParameterID }) %>
        |
        <%: Html.ActionLink("بازگشت به لیست", "Index") %>
    </p>
</asp:Content>
