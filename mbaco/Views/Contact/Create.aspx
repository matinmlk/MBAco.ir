<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBAco.BusinessModel.ContactModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    افزودن
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        افزودن</h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>رابط کاری</legend>
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
        <%--        <div class="editor-label">
            <%: Html.LabelFor(model => model.CustomerID) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CustomerID) %>
            <%: Html.ValidationMessageFor(model => model.CustomerID) %>
        </div>--%>

        <div class="editor-label">
            نام کاربری
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Post) %>
            <%: Html.ValidationMessageFor(model => model.Post) %>
        </div>

        <div class="editor-label">
           کلمه عبور
        </div>
        <div class="editor-field">
            <%: Html.Password("password")%>
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
         <br />

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>

        <p>
            <input type="submit" value="افزودن" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("بازگشت به لیست", "Index") %>
    </div>
</asp:Content>
