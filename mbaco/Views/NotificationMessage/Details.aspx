﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.NotificationMessageModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>جزییات</h2>

<fieldset>
    <legend>پیام اطلاع رسانی</legend>

<%--    <div class="display-label">CultureID</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CultureID) %>
    </div>--%>

    <div class="display-label">TypeId</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Type.Name) %>
    </div>

    <div class="display-label">Text</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Text) %>
    </div>

    <div class="display-label">ShortText</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ShortText) %>
    </div>

    <div class="display-label">FullText</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.FullText) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>


</fieldset>
<p>

    <%: Html.ActionLink("ویرایش", "Edit", new { id=Model.NotificationMessageID }) %> |
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</p>

</asp:Content>
