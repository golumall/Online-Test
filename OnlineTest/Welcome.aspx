<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="OnlineTest.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
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
        .auto-style1 {
            width: 907px;
        }
        .auto-style2 {
            width: 658px;
        }
        .auto-style3 {
            width: 100%;
            height: 85px;
        }
        #d2
        {
            width:80%;
            height:350px;
            background-color:lightgrey;
            border-radius:20px;
        }
       
        .auto-style4 {
            font-size: x-large;
            color: #660033;
        }
       
        .auto-style5 {
            height: 187px;
            width: 521px;
        }
       #btnsubmit
       {
           background:green;
           border-radius:20px;
           color:white;
           font-weight:bold;
           height:40px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="d1" class="auto-style1">
    <asp:Image ID="img1" runat="server" ImageUrl="~/Images/onlinetest-banner.jpg" />
    </div>
        
            <table class="auto-style3">
                <tr><td class="auto-style2"><strong>Welcome : <asp:Label ID="lblname" runat="server"></asp:Label></strong></td>
                    <td><a href="Home.aspx" style="text-decoration:none;color:navy;font-weight:bold">Logout</a></td>
                </tr>
                <tr>
                    
                    <td colspan="2" style="text-align:right"><strong><asp:Label ID="lblemail" runat="server"></asp:Label></strong></td>
                </tr>
            </table>
        <br />
        <center>
            <div id="d2" >
                <strong><span class="auto-style4">
                <br />
                Instructions</span></strong><br /><br />
           <table class="auto-style5">
                  <tr>  <td style="text-align:left"><strong>1. Test contains five sections.</strong></td></tr>
                    <tr>  <td style="text-align:left"> <strong>2. Each correct answer will give you 1 points.</strong></td></tr>
                    <tr>  <td style="text-align:left"> <strong>3. No Negative Marking.</strong></td></tr>
                    <tr>  <td style="text-align:left"> <strong>4. Once you click Finish you can not go back.</strong></td></tr>
                    <tr>  <td style="text-align:left"> <strong>5. Your test will be 30 min and 18 questions.</strong></td></tr>
               <tr>  <td style="text-align:left"> <strong>6. If you want to close exam Click on 18 button and then Finish..</strong></td></tr>
                </table>
                <br /><br />
                <asp:Button ID="btnsubmit" runat="server" Text="Start Exam" OnClick="btnsubmit_Click" />
            </div>
        </center>
    </form>
</body>
</html>
