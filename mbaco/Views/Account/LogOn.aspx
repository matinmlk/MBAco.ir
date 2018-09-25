<%@ Page Language="C#" MasterPageFile="~/Views/Shared/LoginSite.Master" Inherits="System.Web.Mvc.ViewPage<mbaco.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    ورود به سیستم
</asp:Content>
<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<h2>ورود به سیستم</h2>
    <p>
        نام کاربری و کلمه عبور خود را وارد کنید. <%: Html.ActionLink("ثبت نام", "Register") %>.
    </p>--%>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true, "ورود شما با مشکل مواجه شد لطفا دوباره تلاش کنید") %>
    <%:Html.Hidden("accRelation", ViewData["accRelation"])%>
    <%:Html.Hidden("guidu", ViewData["guidu"])%>
    <div style="color: White">
        <%-- <fieldset style="border:none">
                <legend>اطلاعات حساب</legend>--%>
        <table style="vertical-align: center; width:100%; height:100%;margin-top:300px;">
            <tr>
                <td style="vertical-align: center; width:100%; height:100%; ">

                    <div class="login-input-box">
                        <div class="editor-field">
                            نام کاربری
                            <%: Html.TextBoxFor(m => m.UserName) %>
                            <%: Html.ValidationMessageFor(m => m.UserName) %>
                        </div>
                        <div class="editor-field">
                            کلمه عبور
                            <%: Html.PasswordFor(m => m.Password) %>
                            <%: Html.ValidationMessageFor(m => m.Password) %>
                        </div>
                        <div class="editor-label remember-password" style="height:8px; display:block;">
                            <%: Html.CheckBoxFor(m => m.RememberMe) %>
                            بخاطر سپردن
                        </div>
                        <div class="editor-label remember-password">                            
                            
                        </div>
                        <p class="login-button">
                            <input type="submit" value="ورود" />
                        </p>
                    </div>

                    <div class="login-icon">
                    </div>
                     <div class="login-title-background">
                     <h1>سامانه جامع پروفایل مشتریان محافظان بهبود آب</h1>
                    </div>
                </td>
            </tr>

        </table>
        <%--</fieldset>--%>
    </div>
    <% } %>
</asp:Content>
