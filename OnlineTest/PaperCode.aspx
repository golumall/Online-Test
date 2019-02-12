<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaperCode.aspx.cs" Inherits="OnlineTest.PaperCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Paper Code</title>
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
         #d2
         {
             width:90%;
             height:450px;
             background-color:lightgrey;
             border-radius:35px;
         }
        .auto-style1 {
            width: 949px;
        }
        .auto-style2 {
            width: 637px;
            height: 299px;
        }
        .auto-style3 {
            background-color: #0099FF;
        }
        .auto-style4 {
            color: #000066;
        }
        .auto-style5 {
            font-size: 20px;
            color: #003300;
        }
        #btnsub
        {
            background-color:green;
            color:white;
            font-weight:bold;
            border-radius:25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <center> <div id="d1">
       Admin Panel</div></center>
        <br />
     <center>
           <div id="d2">
               <br />
               <table class="auto-style1">
                   <tr>
                       <td><a href="WelcomeAdmin.aspx" style="text-decoration:none;color:navy;font-weight:bold;font-size:20px;text-align:left"><center>Back</center></a></td>
                       <td><a href="Login.aspx" style="text-decoration:none;color:navy;font-weight:bold;font-size:20px;text-align:right"><center>LogOut</center></a></td>
                   </tr>
               </table>
               <br /><br />
               <table style="border:solid 1px brown;" class="auto-style2">
                   <tr><td colspan="2" class="auto-style3"><center class="auto-style5"><strong>Set Paper Code</strong></center></td></tr>
                   <tr><td><center class="auto-style4"><strong>Enter Paper Code:</strong></center></td><td><center><asp:TextBox ID="txtcode" runat="server" Width="152px"></asp:TextBox></center></td></tr>
                   <tr><td colspan="2"><center><asp:Button ID="btnsub" runat="server" Text="Submit" Height="35px" Width="93px" OnClick="btnsub_Click"></asp:Button></center></td></tr>
               </table>
           </div>
         </center>
    </form>
</body>
</html>
