<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.CustomerModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ثبت گزارش
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        ثبت گزارش
    </h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true)%>
    <fieldset>
        <legend>
            <%= Html.DropDownList(
                               "ddl", ViewData["Customers"] as SelectList,
                                new
                                {
                                    onchange = @"
                                    var form = document.forms[0]; 
                                    form.submit();"
                                })%>
            <%--<% if (Model != null){ %><%: Model.Name%><%} %>--%>
        </legend>
        
        <%: Html.HiddenFor(model => model.CustomerID)%>
        <% if (Model != null)
           { %>
        <table cellpadding="7">
            <%
               foreach (var item in Model.ProcedureParameters)
               { %>
            <tr>
                <td style="width: 100px; text-align: left">
                    <strong style="line-height: 20px;">
                        <%: Html.DisplayFor(modelItem => item.AnalayseParameter.Symbol)%></strong><br />
                    <span style="font-size: 10px; line-height: 15px;">
                        <%: Html.DisplayFor(modelItem => item.AnalayseParameter.Name)%></span>
                </td>
                <td style="width: 200px; color: #999">
                    <%: Html.Editor("ProcedureValue")%>
                    <span style="font-size: 10px">
                        <% if (item.PossibleMinLimit != 0)
                           { %>
                        مقدار باید مابین
                        <%: item.PossibleMinLimit%>
                        و
                        <%: item.PossibleMaxLimit%>
                        باشد.
                        <% }
                           else
                           { %>
                        مقدار باید کمتر از
                        <%: item.PossibleMaxLimit%>
                        باشد.
                        <% } %>
                    </span>
                </td>
                <td>
                    <%: Html.HiddenFor(modelItem => item.ProcedureParameterID)%>
                </td>
            </tr>
            <% } %>
        </table>
        <p>
            <input type="submit" value="ذخیره" />
        </p>
        <% } if (ViewData["emailContent"] != null)
           { %>
        <%: Html.Raw(ViewData["emailContent"].ToString())%>
        <% } if ((List<String>)ViewData["Params"] != null)
           { %>
        <table>
            <%
               foreach (var m in (List<String>)ViewData["Params"])
               { %>
            <tr>
                <td>
                    <%: m.ToString()%>
                </td>
            </tr>
            <% } %>
        </table>
        <% } %>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("بازگشت به لیست", "Index")%>
    </div>
</asp:Content>
