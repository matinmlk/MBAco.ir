<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ProcedureParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>حذف</h2>

<h3>برای حذف تمامی داده های این دستورالعمل اطمینان دارید؟</h3>
<% using (Html.BeginForm()) { %>

    <p>
        <input type="submit" value="حذف" /> |
        <%: Html.ActionLink("بازگشت به لیست", "Index") %>
    </p>
<% } %>

</asp:Content>
