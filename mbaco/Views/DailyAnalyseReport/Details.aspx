<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.DailyAnalyseReportModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>جزییات</h2>

<fieldset>
    <legend>گزارش روزانه</legend>

    <div class="display-label">مشتری</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Customer.Name) %>
    </div>

    <div class="display-label">پارامتر آنالیز</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ProcedureParameter.AnalayseParameter.Symbol) %>
    </div>

<%--    <div class="display-label">Date</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Date) %>
    </div>--%>

    <div class="display-label">تاریخ</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DatePersian) %>
    </div>

    <div class="display-label">مقدار</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Value) %>
    </div>

    <div class="display-label">تایید</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IsApproved) %>
    </div>

    <div class="display-label">توضیحات</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

</fieldset>
<p>

    <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.DailyAnalyseReportID }) %> |
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</p>

</asp:Content>
