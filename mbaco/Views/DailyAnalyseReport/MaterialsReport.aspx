﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش مقدار مصرف مواد
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
            <script type="text/javascript">
                $(function () {
                    $('#container').highcharts({
                        chart: {
                            type: 'column'
                        },
                        title: {
                            text: 'مصرف ماهیانه مواد شیمیایی'
                        },
                        subtitle: {
                            text: ''
                        },
                        xAxis: {
                            categories: [
                    'ف 91',
                    'ار 91',
                    'خ 91',
                    'ت 91',
                    'م 91',
                    'ش 91',
                    'م 91',
                    'آب 91',
                    'آذ 91',
                    'د 91',
                    'ب 91',
                    'اس 91',
                    'ف 92',
                    'ار 92',
                    'خ 92',
                    'ت 92',
                    'م 92',
                    'ش 92',
                    'م 92',
                    'آب 92',
                    'آذ 92',
                    'د 92',
                    'ب 92',
                    'اس 92',

                ]
                        },
                        yAxis: {
                            min: 0,
                            title: {
                                text: 'x1000'
                            }
                        },
                        tooltip: {
                            headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
                            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                    '<td style="padding:0"><b>{point.y:.1f} kg</b></td></tr>',
                            footerFormat: '</table>',
                            shared: true,
                            useHTML: true
                        },
                        plotOptions: {
                            column: {
                                pointPadding: 0.2,
                                borderWidth: 0
                            }
                        },
                        series: [{
                            name: '5112 HA ',
                            data: [<%: ViewData["r1"] %>]

                        }, {
                            name: '5112 HC',
                            data: [<%: ViewData["r2"] %>]

                        }, {
                            name: '8110',
                            data: [<%: ViewData["r3"] %>]

                        }, {
                            name: '8115',
                            data: [<%: ViewData["r4"] %>]

                        }, {
                            name: '9511',
                            data: [<%: ViewData["r5"] %>]

                        }]
                    });
                });
    </script>
    <div id="container" style="min-width: 390px; margin: 0 auto;direction:ltr; ">
    </div>
    <div style="width: 700px; text-align: center; margin: 0 auto;">
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
        <br />
        <h2 style="text-align: center; font-family: B Koodak; line-height: 25px;">
            گزارش مقدار مصرف مواد
            <%: fields[0] %></h2>
        <br />

    <br />
        <table class="ColorTable dataTable" style="width: 100%; background: #fff">
            <thead>
                <th class="Header">
                    ماه
                </th>
                <th class="Header">
                    kg 5112 HA 
                </th>
                <th class="Header">
                   kg 5112 HC
                </th>
                <th class="Header">
                    kg 8110 
                </th>
                <th class="Header">
                    kg 8115 
                </th>
                <th class="Header">
                    kg 9511 
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
                <td>
                    <%: fields[6]%>
                </td>

             </tr>
            <%  } %>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
