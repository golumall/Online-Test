<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="OnlineTest.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
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
            height: 68px;
        }
        .auto-style3 {
            width: 507px;
            height: 283px;
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
            border-radius:25px;
            background:darkgreen;
            color:white;
            font-weight:bold;
        }

        .auto-style4 {
            width: 189px;
            height: 59px;
        }

        .auto-style7 {
            height: 59px;
        }

        .auto-style8 {
            width: 189px;
            height: 68px;
        }
        .auto-style9 {
            height: 68px;
        }
       
        .auto-style10 {
            width: 558px;
        }
        .auto-style11 {
            width: 596px;
        }
       
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="d2">
            <br /><br /><br /><br />
            <table style="width:100%;height:50px;">
            <tr><td class="auto-style10"><a href="Home.aspx" class="x"><center>Home</center></a></td><td><center><asp:Button ID="btnsubmit" runat="server"  Text="Foget Password" Font-Bold="True" Font-Size="15px" ForeColor="White" Style="background-color:transparent" OnClick="btnsubmit_Click"/></center></td></tr>
                </table>
            <br /><br /><br /><br />
            <center>
                <table style="background-color:navy;color:white;border-radius:20px;" class="auto-style3">
                    <tr><td colspan="2" class="auto-style2" style="border-bottom:solid 1px white"><strong><center>Admin Login</center></strong></td></tr>
                    <tr><td class="auto-style4"><strong><center>Email:</center></strong></td><td class="auto-style7"><center><asp:TextBox ID="txtemail" runat="server" Width="194px" TextMode="Email" CssClass="y"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style8"><strong><center>Password:</center></strong></td><td class="auto-style9"><center><asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="197px" CssClass="y"></asp:TextBox></center></td></tr>
    <tr><td colspan="2"><center><asp:Button ID="btnsub" runat="server" Text="Submit" OnClick="btnsub_Click" Height="35px" Width="83px" /></center></td></tr>
                    </table>
                <br /><br />
                <table style="width:100%;height:50px;">
            <tr><td class="auto-style11"><a href="Login.aspx" class="x"><center>User Login</center></a></td><td><a href="Employee.aspx" class="x"><center>Employee Login</center></a></td></tr>

                </table>
                </center>
        </div>
                    </form>
</body>
</html>
