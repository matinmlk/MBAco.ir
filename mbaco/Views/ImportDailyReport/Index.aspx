<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.DailyAnalyseReportModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>
   <script type="text/javascript">
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
                        text: 'pH'
                    },
                    min: 7.3,
                    max: 8.3

                },
                title: {
                    text: 'تاریخ'
                },

                series: [{
                    name: 'pH',
                    data: <%: ViewData["Message"] %>,
                    type: 'line'

                }]

            });


      
    });
		</script>


    <div id="container" style="min-width: 400px; margin: 0 auto;">
    </div>
</asp:Content>
