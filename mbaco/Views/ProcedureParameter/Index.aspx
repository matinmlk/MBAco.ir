<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.ProcedureParameterModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    تعریف دستورالعمل مشتریان
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                گزارش ها و دستورالعمل مشتریان</h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create")%>
<%--            <% if ((int)ViewData["AnalyseType"] == 2)
               {%>
            <%: Html.ActionLink("گزارش خوردگی و نتایج کوپن ها", "CorrosionReport", "DailyAnalyseReport", new { id = 1 },null)%>
            <% }  else if ((int)ViewData["AnalyseType"] == 3)
               {%>
            <%: Html.ActionLink("گزارش وضعیت بیولوژیکی و میکروبی", "Create")%>
            <% }
               else if ((int)ViewData["AnalyseType"] == 8)
               {%>
            <%: Html.ActionLink("گزارش مقادیر مصرف مواد", "Create")%>
            <% } %>    --%>    </p>
    </div>
    <table class="list-main">
        <tr>
            <th>
                مشتری
            </th>
            <th>
                پارامتر آنالیز
            </th>
            <% if ((int)ViewData["AnalyseType"] == 1)
               {%>
            <th>
                حد بالا اخطار
            </th>
            <th>
                حد پایین اخطار
            </th>
            <th>
                حد بالا
            </th>
            <th>
                حد پایین
            </th>
            <% } %>
            <th>
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.Customer.Name)%>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.AnalayseParameter.AnalyseParameterType.Name) %>
                -
                <%: Html.DisplayFor(modelItem => item.AnalayseParameter.Symbol)%>
            </td>
            <% if ((int)ViewData["AnalyseType"] == 1)
               {%>
            <td>
                <%: Html.DisplayFor(modelItem => item.DangerMaxLimit)%>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.DangerMinLimit)%>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PossibleMaxLimit)%>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PossibleMinLimit)%>
            </td>
            <% } %>
            <td>
                <div class="actions">
                    <% if ((int)ViewData["AnalyseType"] == 1)
                       {%>
                    <%: Html.ActionLink("گزارش آنالیز", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID }, null)%>
                    |
                    <% } %>
                    <% if ((int)ViewData["AnalyseType"] == 2)
                       {%>
                    <%: Html.ActionLink("گزارش خوردگی", "CorrosionReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                    |
                    <% } %>
                    <% if ((int)ViewData["AnalyseType"] == 3)
                       {%>
                    <%: Html.ActionLink("گزارش بیولوژیک", "MicrobialReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                    |
                    <% } %>
                    <% if ((int)ViewData["AnalyseType"] == 8)
                       {%>
                    <%: Html.ActionLink("گزارش مصرف مواد", "MaterialsReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                        |
                    <% } %>

                    <%: Html.ActionLink("داده ها", "", "DailyAnalyseReport", new { id = item.ProcedureParameterID }, null)%>
                    |
                    <%: Html.ActionLink("افزودن گروهی", "Import", "ImportDailyReport", new { id = item.ProcedureParameterID }, null)%>
                    |
                    <%: Html.ActionLink("ویرایش", "Edit", new { id = item.ProcedureParameterID })%>
                    |
                    <%: Html.ActionLink("جزییات", "Details", new { id = item.ProcedureParameterID })%>
                    |
                    <%: Html.ActionLink("حذف", "Delete", new { id = item.ProcedureParameterID })%>
                </div>
            </td>
        </tr>
        <% } %>
    </table>
</asp:Content>
