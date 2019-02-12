<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineTest.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
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
            width: 630px;
            height: 496px;
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
   <!-- <div id="d1">
    <asp:Image ID="img2" runat="server" ImageUrl="~/Images/onlinetest-banner.jpg" />
    </div> -->
        <div id="d2">
            <br /><br />
            <table style="width:100%;height:50px;">
            <tr><td><a href="Home.aspx" class="x"><center>Home</center></a></td><td><a href="Login.aspx" class="x"><center>Login</center></td></tr>
                </table>
            <br /><br />
            <center>
                <table style="background-color:navy;color:white;border-radius:20px;" class="auto-style3">
                    <tr><td colspan="2" class="auto-style2" style="border-bottom:solid 1px white"><strong><center>Registraion</center></strong></td></tr>
                    <tr><td class="auto-style4"><strong><center>Name:</center></strong></td><td><center><asp:TextBox id="txtname" runat="server" Width="194px"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style4"><strong><center>Email:</center></strong></td><td><center><asp:TextBox ID="txtemail" runat="server" Width="197px"></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="**Pls Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </center></td></tr>
                    <tr><td class="auto-style4"><strong><center>Mobile:</center></strong></td><td><center><asp:TextBox ID="txtmobile" runat="server" TextMode="Number" Width="192px"></asp:TextBox>
                        <br />
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtmobile" ErrorMessage="**Pls Enter Valid Mobile Number" MaximumValue="9999999999" MinimumValue="999999999" Type="Double"></asp:RangeValidator>
                        </center></td></tr>
                    <tr><td rowspan="2" class="auto-style4"><strong><center>Gender</center></strong><br />
                        <br />
                        </td><td><center><asp:RadioButton ID="radiomale" runat="server" text="Male" GroupName="x"/></center></td></tr>
                    <tr><td><center>&nbsp&nbsp<asp:RadioButton ID="radiofemale" runat="server" Text="female" GroupName="x" /></center></td></tr>
                    <tr><td class="auto-style4"><strong><center>Password:</center></strong></td><td><center><asp:TextBox ID="txtpass" runat="server" Width="167px" TextMode="Password"></asp:TextBox></center></td></tr>
                    <tr><td class="auto-style4"><strong><center>Confirm Password:</center></strong></td><td><center><asp:TextBox ID="txtconpass" runat="server" Width="166px" TextMode="Password"></asp:TextBox></center></td></tr>
                    <tr><td colspan="2"><center><asp:Button ID="btnsubmit" runat="server" Text="Submit" Height="29px" Width="80px" OnClick="btnsubmit_Click" /></center></td></tr>

                </table>
            </center>
        </div>
    </form>
</body>
</html>
