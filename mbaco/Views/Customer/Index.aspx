<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.CustomerModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    اضافه و یا ویرایش کردن مشتریان
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
                اضافه و یا ویرایش کردن مشتریان</h2>
        </div>
        <p class="navigation-menu">
            <%: Html.ActionLink("افزودن", "Create") %>
        </p>
    </div>
    <table class="list-main">

            <tr>
                <th>
                    نام
                </th>
                <th>
                    استان
                </th>
                <th>
                    شهر
                </th>
                <th>
                    آدرس
                </th>
                <th>
                    توضیحات
                </th>
                <th>
                </th>
            </tr>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Name) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.State) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.City) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Address) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Comment) %>
                </td>
                <td><div class="actions">
                    <%: Html.ActionLink("گزارش خوردگی", "CorrosionReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                    |
                    <%: Html.ActionLink("گزارش وضعیت بیولوژیک", "MicrobialReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                    |
                    <%: Html.ActionLink("گزارش مقدار مصرف مواد", "MaterialsReport", "DailyAnalyseReport", new { id = item.CustomerID }, null)%>
                     
                    <%: Html.ActionLink("نمودار گزارش ها", "Monitor", new { id=item.CustomerID }) %>
                    |
                    <%: Html.ActionLink("ویرایش", "Edit", new { id=item.CustomerID }) %>
                    |
                    <%: Html.ActionLink("جزییات", "Details", new { id=item.CustomerID }) %>
                    |
                    <%: Html.ActionLink("حذف", "Delete", new { id=item.CustomerID }) %>
                </div></td>
            </tr>
            <% } %>
        </table>
</asp:Content>
