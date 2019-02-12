<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeEmployee.aspx.cs" Inherits="OnlineTest.WelcomeEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Set Paper</title>
    <style>
        #d1
        {
            width:60%;
            height:50px;
            color:white;
            background-color:brown;
            border-radius:40px;
            font-size:25px;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-weight:bold;
        }
        #d3
        {
            width:80%;
           border:solid 1px grey;
           background-color:lightgrey;
           border-radius:25px; 
           height:500px;
        }
        #d2{
            text-align:left;
        }
        a{
            text-decoration:none;
            color:navy;
            font-weight:bold;
            font-size:20px;
           
        }
        .auto-style1 {
            width: 80%;
            height: 473px;
        }
        #btnsub
        {
            background-color:darkblue;
            color:white;
            font-weight:bold;
            border-radius:15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <center>
    <div id="d1">
    <center>Set Question Paper</center>
    </div>
         </center>
            <div id="d2">
                <a href="Login.aspx">LogOut</a>
            </div>
        <br />
        <center>
            <div id="d3">
                <table class="auto-style1">
                    <tr><td><center><strong>Select Question No.</strong></center></td><td><center>
                        <asp:DropDownList ID="dropqueno" runat="server" AutoPostBack="True" Height="27px" OnSelectedIndexChanged="dropqueno_SelectedIndexChanged" Width="172px">
                            <asp:ListItem>Select Question No</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:Label ID="lblsub" runat="server"></asp:Label>
                        </strong></center></td></tr>
                    <tr><td><center><strong>Question:</strong><br />
                        <br />
                        <br />
                        </center></td><td><center><asp:TextBox ID="txtquestion" runat="server" Height="66px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td><center><strong>OptionA:</strong></center></td><td><center><asp:TextBox ID="txtopa" runat="server" Height="24px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td><center><strong>OptionB:</strong></center></td><td><center><asp:TextBox ID="txtopb" runat="server" Height="24px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td><center><strong>OptionC:</strong></center></td><td><center><asp:TextBox ID="txtopc" runat="server" Height="24px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td><center><strong>OptionD:</strong></center></td><td><center><asp:TextBox ID="txtopd" runat="server" Height="24px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td><center><strong>True Answer:</strong></center></td><td><center><asp:TextBox ID="txttrueanswer" runat="server" Height="24px" Width="520px" TextMode="MultiLine"></asp:TextBox></center></td></tr>
                    <tr><td colspan="2"><center><asp:Button ID="btnsub" runat="server"  Text="Update" Height="31px" Width="84px" OnClick="btnsub_Click"/></center></td></tr>
                </table>
            </div>
        </center>
  
        
        
    </form>
</body>
</html>
