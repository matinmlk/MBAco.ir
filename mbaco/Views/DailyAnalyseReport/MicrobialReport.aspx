<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش وضعیت بیولوژیکی و میکروبی
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div style="width: 600px; text-align: center; margin: 0 auto;">
        <% string currentYear = "";
           bool putTable = false;
           foreach (var item in (List<string>)ViewData["Report"])
           {
               var fields = item.Split(',');
        %>
        <% if (currentYear != fields[0])
           {
               currentYear = fields[0];
        %>
        <% if (!string.IsNullOrEmpty(currentYear))
           {  %>
        </table>
        <br />
        <%} %>
        <h2 style="text-align: center; font-family: B Koodak; line-height: 25px;">
            گزارش وضعیت بیولوژیکی و میکروبی سال
            <%: fields[0] %></h2>
        <br />
        <table class="ColorTable dataTable" style="width: 100%; background: #fff">
            <thead>
                <th class="Header">
                    ماه
                </th>
                <th class="Header">
                    TBC نیمه نخست ماه
                </th>
                <th class="Header">
                    TBC نیمه دوم ماه
                </th>
                <th class="Header">
                    SRB نیمه نخست ماه
                </th>
                <th class="Header">
                    SRB نیمه دوم ماه
                </th>
            </thead>
            <% } %>
            <tr>
                <td>
                    <%: fields[1]%>
                </td>
                <td>
                    <%: fields[2]%>
                </td>
                <td>
                    <%: fields[3]%>
                </td>
                <td>
                    <%: fields[4]%>
                </td>
                <td>
                    <%: fields[5]%>
                </td>
            </tr>
            <%  } %>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
