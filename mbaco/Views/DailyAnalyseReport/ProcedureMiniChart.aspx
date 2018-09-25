<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش روزانه
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
    $(function () {
       
            // Create the chart
            window.chart = new Highcharts.StockChart({
                rangeSelector : {
				    enabled : false,
				    selected : 2
			    },

                scrollbar : {
				    enabled : false
			    },

                navigator : {
				    enabled : false
			    },

                exporting:
                 { enabled: false },

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
                        text: '<%: ViewData["Parameter"] %>',
                        
                    },
                    plotLines : [{
					            value : <%: ViewData["DangerMax"] %>,
					            color : 'red',
					            dashStyle : 'shortdash',
					            width : 2,
					            label : {
						            text : '<%: ViewData["DangerMsg"] %>'
					            }
				            }, {
					            value : <%: ViewData["DangerMin"] %>,
					            color : 'red',
					            dashStyle : 'shortdash',
					            width : 2,
					            label : {
						            text : '<%: ViewData["DangerMsg"] %>',
                                    color : 'red'
					            }
				            }],
                    min: <%: ViewData["PossibleMin"] %>,
                    max: <%: ViewData["PossibleMax"] %>
  


                },
                title: {
                     enabled : false
                },

                series: [{
                    name: '<%: ViewData["Parameter"] %>',
                    data: <%: ViewData["Chart"] %>,
                    type: 'spline'

                }]

            });


      
    });
		</script>
    <a href="/DailyAnalyseReport/ProcedureChart/<%: ViewData["id"] %>" style="text-decoration:none;" target="_top">
        <h2 style="text-align: center">
            <%: ViewData["ChartTitle"] %></h2>
        <div id="container" style="min-width: 400px; margin: 0 auto;">
        </div>
    </a>
</asp:Content>
