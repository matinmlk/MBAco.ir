<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ProcedureParameterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Index</h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>افزودن گروهی
            <% = Model.AnalayseParameter.Name %>
            -
            <% = Model.Customer.Name %></legend>از تکرار در وارد کردن و استفاده از کاراکتر
        های غیر عددی یا تاریخی خودداری کنید.
        <br />
        <div class="editor-label">
            متن داده ها برای وارد کردن
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>
        <p>
            <input type="submit" value="ذخیره" />
        </p>
    </fieldset>
    <% } %>
    <div id="container" style="min-width: 400px; margin: 0 auto;">
    </div>
</asp:Content>
