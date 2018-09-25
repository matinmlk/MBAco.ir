<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش روزانه
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                گزارش های تأیید شده</h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create") %>
            <%: Html.ActionLink("تأیید همه", "ApproveAll")%>
        </p>
    </div>
    <table class="list-main">
        <tr>
            <th>
                مشتری
            </th>
            <th>
                پارامتر
            </th>
            <%--        <th>
            Date
        </th>--%>
            <th>
                تاریخ
            </th>
            <th>
                مقدار
            </th>
            <th>
                تایید
            </th>
            <th>
                توضبحات
            </th>
            <th>
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.Customer.Name) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ProcedureParameter.AnalayseParameter.Symbol) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.DatePersian) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Value) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.IsApproved) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>
            <td>
                <div class="actions">
                    <%: Html.ActionLink("تایید", "Approve", new { id=item.DailyAnalyseReportID }) %>
                    |
                    <%: Html.ActionLink("ویرایش", "Edit", new { id=item.DailyAnalyseReportID }) %>
                    |
                    <%: Html.ActionLink("جزییات", "Details", new { id=item.DailyAnalyseReportID }) %>
                    |
                    <%: Html.ActionLink("حذف", "Delete", new { id=item.DailyAnalyseReportID }) %>
                </div>
            </td>
        </tr>
        <% } %>
    </table></asp:Content>
