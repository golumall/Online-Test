<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forget.aspx.cs" Inherits="OnlineTest.Forget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password</title>
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
            height: 347px;
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
        #btnsubmit
        {
            border-radius:10px;
            background:darkgreen;
            color:white;
            font-weight:bold;
        }

        .auto-style4 {
            width: 189px;
        }

    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="d2">
            <br /><br />
            <table style="width:100%;height:50px;">
            <tr><td><a href="Home.aspx" class="x"><center>Home</center></a></td><td><a href="Login.aspx" class="x"><center>Login</center></td></tr>
                </table>
            <br /><br /><br /><br />
            <center>
                <table style="background-color:navy;color:white;border-radius:20px;" class="auto-style3">
                    <tr><td colspan="2" class="auto-style2" style="border-bottom:solid 1px white"><strong><center>Forget Password</center></strong></td></tr>
                    
                    <tr><td class="auto-style4"><strong><center>Email:</center></strong></td><td><center><asp:TextBox ID="txtemail" runat="server" TextMode="Email" Width="197px"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style4"><strong><center>New Password:</center></strong></td><td><center><asp:TextBox id="txtpassword" runat="server" Width="194px" TextMode="Password"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style4"><strong><center>Confirm Password:</center></strong></td><td><center><asp:TextBox ID="txtconpass" runat="server" TextMode="Password" Width="192px"></asp:TextBox></center></td></tr>
                    <tr><td colspan="2"><center><asp:Button ID="btnsubmit" runat="server" Text="Submit" width="80px" Height="30px" OnClick="btnsubmit_Click"/></center></td></tr>
        </table>
                </center>
        </div>
    </form>
</body>
</html>
