<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش خوردگی و وضعیت کوپن ها
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


            <script type="text/javascript">
                $(function () {
               
                    $('#container').highcharts({
                        chart: {
                            type: 'column'
                        },
                        title: {
                            text: 'میزان خوردگی'
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
                                text: 'خوردگی'
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
                            name: 'ماهیانه خوردگی',
                            data: [<%: ViewData["r1"] %>]

                        }, {
                            name: 'دو ماهه خوردگی',
                            data: [<%: ViewData["r2"] %>]

                        }, {
                            name: 'سه ماهه خوردگی',
                            data: [<%: ViewData["r3"] %>]

                        }]
                    });
                });
    </script>
        <div id="container" style="min-width: 390px; width:95%; margin: 0 auto;">
    </div>
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
        <h2 style="text-align: center; font-family: B Koodak; line-height: 25px;direction:ltr;">
            گزارش خوردگی و نتایج کوپن ها
            <%: fields[0] %></h2>
        <br />
        <table class="ColorTable dataTable" style="width: 100%; background: #fff">
            <thead>
                <th class="Header">
                    ماه
                </th>
                <th class="Header">
                    ماهیانه شرکت
                </th>
                <th class="Header">
                    دوماهانه شرکت
                </th>
                <th class="Header">
                    سه ماهانه شرکت
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
            </tr>
            <%  } %>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
