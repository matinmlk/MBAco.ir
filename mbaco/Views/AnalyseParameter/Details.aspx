<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.AnalayseParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>جزییات</h2>

<fieldset>
    <legend>پارامتر آنالیز</legend>

    <div class="display-label">Name</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Name) %>
    </div>

    <div class="display-label">Symbol</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Symbol) %>
    </div>

    <div class="display-label">AnalyseParameterTypeId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnalyseParameterTypeId) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

</fieldset>
<p>

    <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.AnalayseParameterID }) %> |
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</p>

</asp:Content>
