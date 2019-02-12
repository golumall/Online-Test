<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminScore.aspx.cs" Inherits="OnlineTest.AdminScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
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
             height:500px;
             background-color:lightgrey;
             border-radius:35px;
         }
         .x
         {
             background-color:green;
             color:white;
             font-weight:bold;
         }

    </style>
</head>
<body>
    <form id="form1" runat="server">
     <center> <div id="d1">
       &nbsp;Score of Student</div></center>
        <center>
            <br />
            <div id="d2"><br />
                <table style="width:80%">
                    <tr>
                        <td><center><asp:Button ID="btnback" runat="server" Text="Back" CssClass="x" OnClick="btnback_Click" Height="32px" Width="70px"></asp:Button></center></td>
                        <td><center><asp:Button ID="btnlogout" runat="server" Text="LogOut" CssClass="x" OnClick="btnlogout_Click" Height="32px" Width="78px"></asp:Button></center></td>
                    </tr>
                </table>
                <br />
                <table style="width:90%;" border="1" cellspacing="0" cellpadding="0">
                    <tr>
                        <th>
                            <center>Attempts</center>
                        </th>
                        <th>
                            <center>Correct Answer</center>
                        </th>
                        <th>
                            <center>InCorrect Answer</center>
                        </th>
                        
                        <th>
                            <center>Date</center>
                        </th>
                        <th>
                            <center>Paper Code</center>
                        </th>
                        <th>
                            <center>Time</center>
                        </th>
                    </tr>
                    <tr>
                        <td><center><strong><asp:Label ID="lblattempt" runat="server" Text=""></asp:Label></strong></center></td>
                        <td><center><strong><asp:Label ID="lblcorrect" runat="server" Text=""></asp:Label></strong></center></td>
                        <td><center><strong><asp:Label ID="lblincorrect" runat="server" Text=""></asp:Label></strong></center></td>
                        <td><center><strong><asp:Label ID="lbldate" runat="server" Text=""></asp:Label></strong></center></td>
                        <td><center><strong><asp:Label ID="lblpapercode" runat="server" Text=""></asp:Label></strong></center></td>
                        <td><center><strong><asp:Label ID="lbltime" runat="server" Text=""></asp:Label></strong></center></td>
                    </tr>
                </table>
            </div>
        </center>
    </form>
</body>
</html>
