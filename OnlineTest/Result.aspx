<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="OnlineTest.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result</title>
    <style>
        #d1
        {
            width:100%;
            height:180px;
        }
        #img1
        {
            width:100%;
            height:180px;
        }
        #d2
        {
            width:80%;
            height:60px;
            border-radius:35px;
            background-color:darkgreen;
            color:white;
            font-weight:bold;
            font-size:20px;
        }
        #d3
        {
            width:90%;
            height:750px;
            background-color:lightgrey;
            border-radius:35px;
        }
        .auto-style6 {
            font-weight: bold;
            color: #000066;
            font-size: 17px;
            background-color: #000066;
        }
        .auto-style7 {
            height: 51px;
        }
        .auto-style8 {
            width: 822px;
            height: 569px;
        }
        .auto-style9 {
            width: 488px;
            height: 84px;
        }
        .auto-style10 {
            color: #000066;
        }
        .auto-style11 {
            color: #006600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
      <center><div id="d2">
           <br />
                Score Sheet
           
        </div> <br />
        <div id="d3" class="auto-style7">
           <table style="width:80%;"> 
               
              <tr><td><strong><asp:Label ID="lblemail" runat="server"></asp:Label></strong></td> <td style="text-align:right;margin-right:50px;"><strong><asp:Button ID="btnloout" runat="server" Text="LogOut" CssClass="auto-style6" Height="31px" OnClick="btnloout_Click" Width="89px" BackColor="#000066" ForeColor="White"></asp:Button></strong></td>
                  <td><center><strong><asp:Label ID="lblpapercode" runat="server"></asp:Label></strong></center></td>
              </tr></table>
            <br />
           <table class="auto-style8" cellspacing="0" cellpadding="0" border="1">
               <tr><th><center>QuestionNo</center></th><th><center>Your Answer</center></th><th><center>Correct Answer</center></th></tr>
               <tr><td><center>1</center></td><td><center><strong><asp:Label ID="lbly1" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc1" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>2</center></td><td><center><strong><asp:Label ID="lbly2" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc2" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>3</center></td><td><center><strong><asp:Label ID="lbly3" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc3" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>4</center></td><td><center><strong><asp:Label ID="lbly4" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc4" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
                <tr><td><center>5</center></td><td><center><strong><asp:Label ID="lbly5" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc5" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>6</center></td><td><center><strong><asp:Label ID="lbly6" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc6" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>7</center></td><td><center><strong><asp:Label ID="lbly7" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc7" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>8</center></td><td><center><strong><asp:Label ID="lbly8" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc8" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>9</center></td><td><center><strong><asp:Label ID="lbly9" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc9" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>10</center></td><td><center><strong><asp:Label ID="lbly10" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td><center><strong><asp:Label ID="lblc10" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>11</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly11" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc11" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>12</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly12" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc12" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
                <tr><td><center>13</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly13" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc13" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>14</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly14" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc14" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>15</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly15" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc15" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>16</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly16" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc16" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>17</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly17" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc17" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
               <tr><td><center>18</center></td><td class="auto-style10"><center><strong><asp:Label ID="lbly18" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td>
                   <td class="auto-style11"><center><strong><asp:Label ID="lblc18" runat="server" CssClass="auto-style11"></asp:Label></strong></center></td></tr>
           </table>
            <br />
            <table border="1" cellspacing="0" cellpadding="0" class="auto-style9">
                <tr><td><center class="auto-style10"><strong>Your Correct Answer</strong></center></td><td><center><strong><asp:Label ID="lblyourcorrect" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td></tr>
                <tr><td><center class="auto-style10"><strong>Your InCorrect Answer</strong></center></td><td><center><strong><asp:Label ID="lblyourIncoreect" runat="server" CssClass="auto-style10"></asp:Label></strong></center></td></tr>
            </table>
        </div></center>
    </form>
</body>
</html>
