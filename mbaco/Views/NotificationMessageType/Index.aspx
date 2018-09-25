﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBAco.BusinessModel.NotificationMessageTypeModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <div class="list-header">
        <div class="page-title-breadcrumb">
            <div class="list-icon">
            </div>
            <h2>
               انواع پیام های سیستمی
            </h2>
        </div>
        <p class="navigation-menu">
    <%: Html.ActionLink("افزودن", "Create") %>
        </p>
    </div>
<table class="list-main">
    <tr>
        <th>
            نام
        </th>
        <th>
            توضیحات
        </th>

        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Name) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Comment) %>
        </td>

        <td><div class="actions">
            <%: Html.ActionLink("ویرایش", "Edit", new { id=item.NotificationMessageTypeID }) %> |
            <%: Html.ActionLink("جزییات", "Details", new { id=item.NotificationMessageTypeID }) %> |
            <%: Html.ActionLink("حذف", "Delete", new { id=item.NotificationMessageTypeID }) %>
       </div> </td>
    </tr>
<% } %>

</table>

</asp:Content>
