<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeAdmin.aspx.cs" Inherits="OnlineTest.WelcomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Panel</title>
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
             background-color:lightgrey;
             border-radius:35px;
             padding:20px;
        
             width:90%;
             height:450px;
         }
        .auto-style1 {
            height: 218px;
            width: 500px;
            border:solid 1px brown;
            float:left;
            margin-left:50px;
        }
        .auto-style2 {
            font-weight: bold;
            background-color:brown;
            border-radius:20px;
            color:white;
        }
        .auto-style3 {
            background-color: #0099FF;
        }
        .auto-style4 {
            color: #000066;
        }
        a
        {
            text-decoration:none;
            color:navy;
            font-weight:bold;
            font-weight:20px;
            
        }
        .auto-style5 {
            width: 90%;
            height: 287px;
        }
        .auto-style6 {
            color: #000066;
            font-weight: bold;
            background-color:transparent;
        }
        .auto-style7 {
            height: 258px;
        }
        .auto-style8 {
            width: 92%;
        }
        .auto-style9 {
            width: 297px;
        }
        .auto-style10 {
            width: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <center> <div id="d1">
       Admin Panel</div></center>
        <br />
       <center> <div id="d2">
           <table class="auto-style8">
               <tr>
                   <td class="auto-style9"><center><strong>No of Students Attempt Exam:</center></td>
                   <td class="auto-style10"><center><strong><asp:Label ID="lblstudent" runat="server" Text=""></asp:Label></strong></strong></center></td>
                   <td><a href="PaperCode.aspx"><strong><center>SetPaper Code</center></strong></a></td>
               </tr>
           </table>
           <br />
           <div class="auto-style7">
           <table class="auto-style1">
               <tr><td colspan="2" class="auto-style3"><center class="auto-style4"><strong>See Score</strong></center></td></tr>
               <tr><td><center class="auto-style4"><strong>Enter Student Email:</strong></center></td><td><center><asp:TextBox ID="txtemail" runat="server" TextMode="Email" Width="239px"></asp:TextBox></center></td></tr>
               <tr><td colspan="2"><center><strong><asp:Button ID="btnsub" runat="server" Text="Submit" CssClass="auto-style2" Height="32px" Width="85px" OnClick="btnsub_Click" /></strong></center></td></tr>
                          </table>
           <table class="auto-style1">
               <tr><td colspan="2" class="auto-style3"><center class="auto-style4"><strong>Delete Employee</strong></center></td></tr>
               <tr><td><center class="auto-style4"><strong>Enter Employee Email:</strong></center></td><td><center><asp:TextBox ID="txtemployee" runat="server" TextMode="Email" Width="239px"></asp:TextBox></center></td></tr>
               <tr><td colspan="2"><center><strong><asp:Button ID="btnemp" runat="server" Text="Submit" CssClass="auto-style2" Height="32px" Width="85px" OnClick="btnemp_Click"/></strong></center></td></tr>
                          </table>
        <br />

         <table class="auto-style5">
             <tr>
                 <td style="text-align:left"><a href="WelcomeEmployee.aspx"><strong>Set Question Paper</strong></a><strong></td>
                 <td style="text-align:left"><strong><asp:Button ID="btnid" runat="server" Text="Assign Id" CssClass="auto-style6" OnClick="btnid_Click"></asp:Button></strong></td>
                 <td style="text-align:right"><a href="Login.aspx"><strong>Logout</strong></a></td>
             </tr>
         </table>
        </div></center>

    </form>
   
</body>
</html>
