<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/EmptySite.Master"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    گزارش روزانه
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div style="padding:10px;">
    <script type="text/javascript">
    $(function () {
       
            // Create the chart
            window.chart = new Highcharts.StockChart({
                chart: {
                    renderTo: 'container',
                     type: 'spline',
                     
                      events: {  
                        load: function () {
                           
                           this.renderer.image('http://server.shahmat.ir/mbaco/logo.png', 70, 40, 70, 70)
                                
                                .add();
                                }
                            } 
                },

                xAxis: {
                    type: 'datetime',
                    dateTimeLabelFormats: { // don't display the dummy year
                        month: '%e. %b',
                        year: '%b'
                    }
                },

                rangeSelector : {
				  enabled : false
			    },


                yAxis: {
                    title: {
                        text: '<%: ViewData["Parameter"] %>'
                        
                    },
                    plotLines : [{
					            value : <%: ViewData["DangerMax"] %>,
					            color : 'red',
					            dashStyle : 'shortdash',
					            width : 2,
					            label : {
						            text : '<%: ViewData["DangerMaxMsg"] %>'
					            }
				            }, {
					            value : <%: ViewData["DangerMin"] %>,
					            color : 'red',
					            dashStyle : 'shortdash',
					            width : 2,
					            label : {
						            text : '<%: ViewData["DangerMinMsg"] %>',
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
                    data: <%= ViewData["Chart"] %>,
                    type: 'spline'

                }]

            });


      
    });
		</script>
    <h2 style=" font-family: B Koodak; line-height: 25px;">
        <%: ViewData["ChartTitle"] %></h2>
    <h3 style=" font-family: B Koodak; color: #999; line-height: 25px;">
        <%: ViewData["Customer"] %></h3>


       
            <%  
                if (ViewData["StartDate"] != null)
                { %>
                 <%: ViewData["ChartTitle"] %> در بازه زمانی <%: ViewData["StartDate"]%>
                تا <%: ViewData["EndDate"]%>  است که درطول این مدت زمان:<br /> 
                <% } if (ViewData["DataMax"] != null)
        { %>
    میزان <strong>بالاترین حد</strong>
    <%: ViewData["DataMax"]%>
   میزان <strong>پایین ترین حد</strong> و 
    <%: ViewData["DataMin"]%>
  و <strong>میانگین مقادیر</strong>
    <%: String.Format("{0:0.####}", ViewData["DataAvg"]) %>
    بوده است.
    <% } %>
    <br />
    <br />
    تغییر بازه زمانی (
    <%: Html.ActionLink("یک ماهه", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 1 },null)%>/
    <%: Html.ActionLink("دوماهه", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 2 },null)%>/
    <%: Html.ActionLink("سه ماهه", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 3 },null)%>/
    <%: Html.ActionLink("شش ماهه", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 4 },null)%>/
    <%: Html.ActionLink("یک ساله", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 5 }, null)%>/
    <%: Html.ActionLink("همه مقادیر", "ProcedureChart", "DailyAnalyseReport", new { id = ViewData["id"], type = 6 }, null)%>)

     <br />
    <br />

    <h2 style="text-align: center; font-family: B Koodak; line-height: 25px;">
        نمودار مقادیر</h2>
    <div id="container" style="min-width: 390px; width:96%; margin: 0 auto;direction:ltr;">
    </div>

    <h2 style="text-align: center; font-family: B Koodak; line-height: 25px;">
        درصد مقادیر در محدوده مجاز</h2>
        <br />

    <div id="div1" style="min-width: 300px; height:300px; margin: 0 auto; direction:ltr;">
    </div>

    <br />
    <br />
        <h2 style=" font-family: B Koodak; line-height: 25px; clear:both;">
        جدول داده های ثبت شده بیشتر از حد مجاز</h2>
        <table class="ColorTable" style="width:100%; margin:0 auto;clear:both;">
        <thead>
        <tr>
            <th class="Header">
                مشتری
            </th>
            <th class="Header">
                پارامتر
            </th>
            <%--<th>
            Date
        </th>--%>
            <th class="Header">
                تاریخ
            </th>
            <th class="Header">
                مقدار
            </th>
            <th class="Header">
                توضبحات
            </th>
        </tr>
        </thead>
        <tbody>
        <%  if (ViewData["UpperItems"] != null)
            foreach (var item in ((IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>)ViewData["UpperItems"]))
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
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>

        </tr>
        <% } %>
        </tbody>

    </table>
    <br />
    <br />
    <br />
    <h2 style=" font-family: B Koodak; line-height: 25px;">
        جدول داده های ثبت شده کمتر از حد مجاز</h2>
        <br />

    <table class="ColorTable" style="width:100%; margin:0 auto; clear:both;">
        <thead>
        <tr>
            <th class="Header">
                مشتری
            </th>
            <th class="Header">
                پارامتر
            </th>
            <%--<th>
            Date
        </th>--%>
            <th class="Header">
                تاریخ
            </th>
            <th class="Header">
                مقدار
            </th>
            <th class="Header">
                توضبحات
            </th>
        </tr>
        </thead>
        <tbody>
        <%  if (ViewData["LowerItems"] != null)
            foreach (var item in ((IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>)ViewData["LowerItems"]))
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
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>

        </tr>
        <% } %>
        </tbody>
    </table>
    <br />
    <br />
    <br />
     <h2 style=" font-family: B Koodak; line-height: 25px;">
        جدول داده های ثبت شده در محدوده مجاز</h2>
        <br />
        <div style="margin:0 auto; direction:rtl">
        <table class="ColorTable" style="width:100%; margin:0 auto; clear:both;">
        <thead>
        <tr>
            <th class="Header">
                مشتری
            </th>
            <th class="Header">
                پارامتر
            </th>
            <%--<th>
            Date
        </th>--%>
            <th class="Header">
                تاریخ
            </th>
            <th class="Header">
                مقدار
            </th>
            <th class="Header">
                توضبحات
            </th>
        </tr>
        </thead>
        <tbody>
        <% if(ViewData["NormalItems"] != null)
            foreach (var item in ((IEnumerable<MBAco.BusinessModel.DailyAnalyseReportModel>)ViewData["NormalItems"]))
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
                <%: Html.DisplayFor(modelItem => item.Comment) %>
            </td>

        </tr>
        <% } %>
        </tbody>
    </table>


    </div>
    <script>
        $(document).ready(function () {
            $('.ColorTable').dataTable({
                "oLanguage": {
                    "sProcessing": "درحال پردازش...",
                    "sLengthMenu": "نمایش محتویات _MENU_",
                    "sZeroRecords": "موردی یافت نشد",
                    "sInfo": "نمایش _START_ تا _END_ از مجموع _TOTAL_ مورد",
                    "sInfoEmpty": "0 مورد",
                    "sInfoFiltered": "(فیلتر شده از مجموع _MAX_ مورد)",
                    "sInfoPostFix": "",
                    "sSearch": "جستجو:",
                    "sUrl": "",
                    "oPaginate": {
                        "sFirst": "ابتدا",
                        "sPrevious": "قبلی",
                        "sNext": "بعدی",
                        "sLast": "انتها"
                    }
                }

            });
        });

      
    </script>
    <script type="text/javascript">

            (function ($) { // encapsulate jQuery

                $(function () {

                    // Radialize the colors
                    Highcharts.getOptions().colors = Highcharts.map(Highcharts.getOptions().colors, function (color) {
                        return {
                            radialGradient: { cx: 0.5, cy: 0.3, r: 0.7 },
                            stops: [
		            [0, color],
		            [1, Highcharts.Color(color).brighten(-0.3).get('rgb')] // darken
		        ]
                        };
                    });

                    // Build the chart
                    $('#div1').highcharts({
                        chart: {
                            plotBackgroundColor: null,
                            plotBorderWidth: null,
                            plotShadow: false
                        },
                        title: {
                            text: ''
                        },
                        tooltip: {
                            pointFormat: '',
                            percentageDecimals: 2
                        },
                        plotOptions: {
                            pie: {
                                allowPointSelect: true,
                                cursor: 'pointer',
                                dataLabels: {
                                    enabled: true,
                                    color: '#000000',
                                    connectorColor: '#000000',
                                    formatter: function () {
                                        return '<b>' + this.point.name + '</b>: ' + ' %' +Highcharts.numberFormat(this.percentage, 1) ;
                                    }
                                }
                            }
                        },
                        series: [{
                            type: 'pie',
                            name: 'مقادیر در محدوده مجاز',
                            data: [
                                        ['کمتر از حد مجاز', <%: ViewData["DataLowerPercent"] %>],
                                        ['بیشتر از حد مجاز', <%: ViewData["DataUpperPercent"] %>],
                                        {
                                            name: 'در محدوده مجاز',
                                            y: <%: ViewData["DataNormalPercent"] %>,
                                            sliced: true,
                                            selected: true
                                        }
                                  ]
                        }]
                    });
                });


            })(jQuery);
</script>


</div>
</asp:Content>
