<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.ProcedureParameterModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش ها و دستورالعمل مشتریان
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center style="margin: auto 0; text-align: center;">
        <div>
            <table style="margin: 0 20px; direction: rtl; width: 95%;">
                <tr>
                    <td style="text-align: right;" colspan="2">
                        <h1 style="font-family: B Yekan,Tahoma">
                            گزارش های
                            <%: ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).Name  %></h1>
                    </td>
                </tr>
                <tr>
                    <td valign="top" style="width: 250px">
                        <h2>
                            نتایج آنالیز آب
                            <%: ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).Name  %></h2>
                        <% foreach (var item in Model)
                           {
                               var data = ""; %>
                        <% 
                               foreach (var loop in item.DailyAnalyseReports)
                               {
                                   data += loop.Value + ",";%>
                        <%--<iframe src="http://cs.mbaco.co/DailyAnalyseReport/ProcedureMiniChart/<%: item.ProcedureParameterID %>"
        width="600" height="500" frameborder=0 style="margin:0 auto;display:block"></iframe>--%>
                        <%} %>
                        <script>

               $(function () {
                   $("#div<%: item.ProcedureParameterID %>").sparkline([<% = data.TrimEnd(',')%>], {
                       type: 'line',
                        normalRangeMin: <%: item.DangerMinLimit %>,
                        normalRangeMax: <%: item.DangerMaxLimit %>,
                        normalRangeColor: '#e2ffe2',
                        drawNormalOnTop: true
                   });

               });

                        </script>
                        <%: item.AnalayseParameter.Symbol%>
                        نمودار تغییرات
                        <%: item.AnalayseParameter.Name %>
                        <br />
                        ( گزارش
                        <%: Html.ActionLink("ماه", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID, type = 1 }, new { target = "_top" })%>
                        |
                        <%: Html.ActionLink("3 ماه", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID, type = 3 }, new { target = "_top" })%>
                        |
                        <%: Html.ActionLink("6 ماه", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID, type = 4 }, new { target = "_top" })%>
                        |
                        <%: Html.ActionLink("سال", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID, type = 5 }, new { target = "_top" })%>
                        |
                        <%: Html.ActionLink("همه", "ProcedureChart", "DailyAnalyseReport", new { id = item.ProcedureParameterID, type = 6 }, new { target = "_top" })%>
                        )
                        <div style="margin: width:200px;" id="div<%: item.ProcedureParameterID %>">
                        </div>
                        <%
                           } %>
                    </td>
                    <td valign="top" style="width: 400px; text-align: right">
                        <div id="microbial" class="report">
                            <span class="icon"></span>
                            <h2>
                                گزارش وضعیت بیولوژیک و میکروبی
                                <% var customerId = ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).CustomerID; %>
                                <%: ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).Name  %></h2>
                            <%: Html.ActionLink("گزارش وضعیت بیولوژیک و میکروبی", "MicrobialReport", "DailyAnalyseReport", new { id = customerId, type = 1 }, new { target = "_top" })%>
                            <br />
                            <br />
                        </div>
                        <div id="corrosion" class="report">
                            <span class="icon"></span>
                            <h2>
                                گزارش خوردگی و نتایج کوپن
                                <%: ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).Name  %></h2>
                            <%: Html.ActionLink("گزارش خوردگی و نتایج کوپن ها", "CorrosionReport", "DailyAnalyseReport", new { id = customerId, type = 1 }, new { target = "_top" })%>
                            <br />
                            <br />
                        </div>
                        <div id="material" class="report">
                            <span class="icon"></span>
                            <h2>
                                گزارش مصرف مواد
                                <%: ((MBAco.BusinessModel.CustomerModel)ViewData["Customer"]).Name  %></h2>
                            <%: Html.ActionLink("گزارش مصرف مواد", "MaterialsReport", "DailyAnalyseReport", new { id = customerId, type = 1 }, new { target = "_top" })%>
                            <br />
                            <br />
                        </div>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </center>
</asp:Content>
