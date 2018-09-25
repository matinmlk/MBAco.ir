<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    سامانه جامع پروفایل مشتریان محافظان بهبود آب
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script type="text/javascript">
    $(function () {
            // Create the chart
            window.chart = new Highcharts.StockChart({
                chart: {
                    renderTo: 'container',
                     type: 'spline'
                },

                xAxis: {
                    type: 'datetime',
                    dateTimeLabelFormats: { // don't display the dummy year
                        month: '%e. %b',
                        year: '%b'
                    }
                },
                yAxis: {
                    title: {
                        text: '10,000 RLS'
                    },
                    min: 0.5,
                    max:4

                },
                title: {
                    text: 'Iran RLS to USD'
                },

                series: [{
                    name: 'USD',
                    data: <%: ViewBag.Data2 %>,
                    type: 'line'

                },
                {
                    name: 'AED',
                    data: <%: ViewBag.Data3 %>,
                    type: 'line'

                }]
            });
    });
		</script>--%>
    <table class="admin-main-layout" style="margin: auto">
        <tr>
            <td class="admin-main-module">
                <div>
                    <div id="items" class="icon">
                    </div>
                    <div class="content">
                        <strong>واحد مدیریت پارامترهای آب</strong>
                        <% foreach (var item in (IEnumerable<MBAco.BusinessModel.AnalyseParameterTypeModel>)ViewData["AnalyseType"])
                           { %>
                        <p>
                            <%: Html.ActionLink(" ثبت " + item.Name, "AddParameter", "DailyAnalyseReport", new { id = 1, type = item.AnalyseParameterTypeID}, null) %>
                            <%-- <a href="/DailyAnalyseReport/AddParameter/<%: item.AnalyseParameterTypeID %>">ثبت <%: item.Name %></a>--%>
                        </p>
                        <%  } %>
                    </div>
                </div>
            </td>
            <td class="admin-main-module">
                <div>
                    <div id="settings" class="icon">
                    </div>
                    <div class="content">
                        <strong>تنظیمات سیستمی</strong>
                        <% if (User.IsInRole("techhead"))
                           { %>
                        <p>
                            <a href="/NotificationMessage/">پیام ها، هشدار ها و اخطارهای سیستمی</a></p>
                        <p>
                            <a href="/NotificationMessageType/">تعریف نوع پیام حدید</a></p>
                        <p>
                            <a href="/AnalyseParameterType/">نوع پارامتر های آنالیز</a></p>
                        <% if (User.IsInRole("techhead"))
                           { %>
                        <p>
                            <a href="/AnalyseParameter/">پارامتر های آنالیز</a>
                        </p>
                        <% } %>
                        <% }
                           else
                           { %>
                        <p>
                            عدم دسترسی به این بخش</p>
                        <% } %>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td class="admin-main-module">
                <div>
                    <div id="workflow" class="icon">
                    </div>
                    <div class="content">
                        <strong>واحد مدیریت پارامترها برای مشتریان</strong>
                        <% foreach (var item in (IEnumerable<MBAco.BusinessModel.AnalyseParameterTypeModel>)ViewData["AnalyseType"])
                           { %>
                        <p>
                            <%: Html.ActionLink(item.Name, "Index", "ProcedureParameter", new { id = 1, type = item.AnalyseParameterTypeID },
                            new { onclick = "javascript:$('#dialog-" +  item.AnalyseParameterTypeID +"').dialog({modal: true});return false;" })%>
                            <%-- <a href="/DailyAnalyseReport/AddParameter/<%: item.AnalyseParameterTypeID %>">ثبت <%: item.Name %></a>--%>

                            <div id="dialog-<%: item.AnalyseParameterTypeID %>" title="<%: item.Name %>" style="display: none">
                                <p>
                                    مشتری مورد نظر خود را انتخاب کنید
                                </p>
                            <% foreach (var i in (IEnumerable<MBAco.BusinessModel.CustomerModel>)ViewData["Customers"])
                               { %>
                               <%: Html.ActionLink(i.Name, "Index", "ProcedureParameter", new { id = item.AnalyseParameterTypeID, type = item.AnalyseParameterTypeID, customer = i.CustomerID },null)%>
                               <br />
                            <% } %>

                            </div>
                        </p>
                        <%  } %>
                        <p>
                            <a href="/DailyAnalyseReport/UnApprovedIndex">گزارش های تایید نشده</a>
                        </p>
                        <p>
                            <a href="/DailyAnalyseReport/ApprovedIndex">گزارش های تأیید شده امروز</a>
                        </p>
                    </div>
                </div>
            </td>
            <td class="admin-main-module">
                <div>
                    <div id="users" class="icon">
                    </div>
                    <div class="content">
                        <strong>مدیریت مشتریان</strong>
                        <% if (User.IsInRole("techhead"))
                           { %>
                        <p>
                            <a href="/Customer/">مشتریان</a></p>
                        <p>
                            <a href="/CustomerContact/">رابط کاری مشتری بخصوص</a></p>
                        <p>
                            <a href="/Contact/">رابط های کاری</a></p>
                        <% }
                           else
                           { %>
                        <p>
                            عدم دسترسی به این بخش</p>
                        <% } %>
                    </div>
                </div>
            </td>
        </tr>
    </table>

</asp:Content>
