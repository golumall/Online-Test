<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Id.aspx.cs" Inherits="OnlineTest.Id" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Id</title>
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
         #d2{
             width:90%;
            height:450px;
             background-color:lightgrey;
             border-radius:35px;
         }
        .auto-style1 {
            height: 280px;
            width: 582px;
        }
        .auto-style2 {
            color: #FFFFFF;
            font-weight: bold;
            background-color: #000066;
        }
        .auto-style3 {
            color: #000066;
        }
        .x
        {
            width:80px;
            height:35px;
            background-color:navy;
            color:white;
            border-radius:30px;
        }
        
        .auto-style4 {
            width: 96%;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <center><div id="d1">
       &nbsp;Assign Id to Employee</div></center>
      
            <br />
     <center>  <div id="d2">
         <br />
        <table class="auto-style4">
            <tr><td><center><asp:Button ID="btnback" runat="server" Text="back" CssClass="x" OnClick="btnback_Click"></asp:Button></center></td>
            <td><center><asp:Button ID="btnlogout" runat="server" Text="LogOut" CssClass="x" OnClick="btnlogout_Click"></asp:Button></center></td></tr>
        </table>
         <br /><br /><br />
         <table class="auto-style1">
             <tr>
                 <td><center class="auto-style3"> <strong>Name:</strong></center></td>
                 <td><center><asp:TextBox ID="txtname" runat="server" Width="171px"></asp:TextBox></center></td>
             </tr>
              <tr>
                 <td><center class="auto-style3"> <strong>Email:</strong></center></td>
                 <td><center><asp:TextBox ID="txtemail" runat="server" TextMode="Email" Width="176px"></asp:TextBox></center></td>
             </tr>
              <tr>
                 <td><center class="auto-style3"> <strong>Password:</strong></center></td>
                 <td><center><asp:TextBox ID="txtpass" runat="server" Width="172px"></asp:TextBox></center></td>
             </tr>
             <tr><td colspan="2"><center><strong><asp:Button ID="btnsub" runat="server"  Text="Submit" CssClass="auto-style2" Height="29px" Width="81px" OnClick="btnsub_Click"/></strong></center></td></tr>
         </table>
        </div></center> 
    </form>
</body>
</html>
