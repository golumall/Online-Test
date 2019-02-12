<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineTest.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        #d1
        {
            width:100%;
            height:200px;  
        }
        #img2{
            width:100%;
            height:200px;  
        }
        #d2
        {
            width:100%;
            height:600px;
            background-image:url('Images/IMG_229483.jpg');
        }
        .auto-style2 {
            font-size: x-large;
            height: 74px;
        }
        .auto-style3 {
            width: 507px;
            height: 327px;
        }
        .x
        {
            text-decoration:none;
            color:white;
            font-size:20px;
            font-weight:bold;
        }
        body
        {
            background-image:url('Images/IMG_229483.jpg');
        }
        #btnsub
        {
            border-radius:10px;
            background:darkgreen;
            color:white;
            font-weight:bold;
        }

        .auto-style4 {
            width: 189px;
            height: 69px;
        }

        .auto-style7 {
            height: 69px;
        }

        .auto-style8 {
            width: 189px;
            height: 82px;
        }
        .auto-style9 {
            height: 82px;
        }
        .auto-style10 {
            height: 89px;
        }
       
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="d2">
            <br /><br /><br /><br />
            <table style="width:100%;height:50px;">
            <tr><td><a href="Home.aspx" class="x"><center>Home</center></a></td><td><a href="Register.aspx" class="x"><center>Register</center></td><td><a href="Forget.aspx" class="x"><center>Forget Password</center></a></td></tr>
                </table>
            <br /><br /><br /><br />
            <center>
                <table style="background-color:navy;color:white;border-radius:20px;" class="auto-style3">
                    <tr><td colspan="2" class="auto-style2" style="border-bottom:solid 1px white"><strong><center>User Login</center></strong></td></tr>
                    <tr><td class="auto-style4"><strong><center>Email:</center></strong></td><td class="auto-style7"><center><asp:TextBox ID="txtemail" runat="server" Width="194px" TextMode="Email" CssClass="y"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style8"><strong><center>Password:</center></strong></td><td class="auto-style9"><center><asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="197px" CssClass="y"></asp:TextBox></center></td></tr>
                    <tr><td colspan="2" class="auto-style10"><center><asp:Button ID="btnsub" runat="server" Text="Submit" Width="80px" Height="30px" OnClick="btnsub_Click"/></center></td></tr>
        </table>
                <br /><br />
                                <table style="width:100%;height:50px;">
            <tr><td><a href="Admin.aspx" class="x"><center>Admin Login</center></a></td><td><a href="Employee.aspx" class="x"><center>Employee Login</center></td></tr>
                </table>
                </center>
        </div>
    </form>
</body>
</html>
