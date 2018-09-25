<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ContactModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>رابط کاری</legend>

        <%: Html.HiddenFor(model => model.ContactID) %>


        <br />
        
        <div class="editor-label">
            نام کاربری
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Post) %>
            
        </div>
        <br />
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Family) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Family) %>
            <%: Html.ValidationMessageFor(model => model.Family) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Email) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PhoneNumber) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PhoneNumber) %>
            <%: Html.ValidationMessageFor(model => model.PhoneNumber) %>
        </div>

 <%--       <div class="editor-label">
            <%: Html.LabelFor(model => model.CustomerID) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CustomerID) %>
            <%: Html.ValidationMessageFor(model => model.CustomerID) %>
        </div>--%>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>

        <div class="editor-label">
             کلمه عبور قبلی
        </div>
        <div class="editor-field">
            <%: Html.Password("password")%>
        </div>

        <div class="editor-label">
            کلمه عبور جدید
        </div>
        <div class="editor-field">
            <%: Html.Password("password")%>
        </div>
        <br />

         <div class="editor-label">
            نقش کاربر
        </div>
        <div class="editor-field">
            <%: Html.CheckBox("Customer") %>مشتری
        </div>
        <br />

        <div class="editor-field">
            <%: Html.CheckBox("Analyser")%>آنالیزر
        </div>
        <br />

        <div class="editor-field">
            <%: Html.CheckBox("Techhead")%>مدیر فنی
        </div>
        <br />
        <div class="editor-field">
            <%: Html.CheckBox("Approver")%>تأیید کننده 
        </div>

        <p>
            <input type="submit" value="ذخیره" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("بازگشت به لیست", "Index") %>
</div>

</asp:Content>
