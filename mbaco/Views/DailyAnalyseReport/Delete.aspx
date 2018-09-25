<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.DailyAnalyseReportModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>حذف</h2>

<h3>برای حذف مورد زیر اطمینان دارید؟</h3>
<fieldset>
    <legend>گزارش روزانه</legend>

    <div class="display-label">CustomerID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Customer.Name ) %>
    </div>
    <div class="display-label">ProcedureParameterID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ProcedureParameter.AnalayseParameter.Symbol) %>
    </div>

 <%--   <div class="display-label">Date</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Date) %>
    </div>--%>

    <div class="display-label">DatePersian</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DatePersian) %>
    </div>

    <div class="display-label">Value</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Value) %>
    </div>

    <div class="display-label">IsApproved</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IsApproved) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
     <%: Html.HiddenFor(Model => Model.ProcedureParameterID) %>

    <p>
        <input type="submit" value="حذف" /> |
        <%: Html.ActionLink("بازگشت به لیست", "Index") %>
    </p>
<% } %>

</asp:Content>
