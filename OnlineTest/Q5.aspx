<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q5.aspx.cs" Inherits="OnlineTest.Q5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q5</title>
    <link rel="stylesheet" href="question.css" />
</head>
<body>
    <form id="form1" runat="server">
   <center><div id="d3">
           <center>Online Test</center>
       </div>
           <br />
           <div>
              <table class="auto-style9">
                   <tr>
                       <td class="auto-style10"><center><strong>
                       <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ViewStateMode="Enabled">
            <ContentTemplate>       
                 
                     <span style="font-weight:bold">  Spent Time: </span> &nbsp;&nbsp;  <asp:Label ID="lblmin" runat="server" Text="" Font-Bold="true"></asp:Label></strong></center>
                </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>

            </asp:UpdatePanel>
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" Enabled="true">
        </asp:Timer>
                </td>
                       <td><center><strong>Max Time:&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbltime" runat="server" Text="30 Min"></asp:Label></strong></center></td>
                       <td><center><strong><asp:Label ID="lblemail" runat="server" Text=""></asp:Label></strong></center></td></tr>
               </table>
           </div>
       </center>
          <center> <div id="parent">
              
       <table> 
           
       <tr> <td><center class="auto-style1" ><strong>Question</strong></td><td><center class="auto-style3"><strong>Questions</strong></center></td></tr>
           
         <tr>  <td><div id="d1">
          <table style="text-align:left;padding:20px" class="auto-style5">
              <tr><td colspan="3" class="auto-style6">Q5:-<asp:Label ID="lbl1" runat="server"></asp:Label></td></tr>
              <tr><td colspan="2">(a)<asp:RadioButton ID="radioa" runat="server" GroupName="1" /></td><td>(b)<asp:RadioButton ID="radiob" runat="server" GroupName="1" /></td></tr>
              <tr><td colspan="2">(c)<asp:RadioButton ID="radioc" runat="server" GroupName="1" /></td><td>(d)<asp:RadioButton ID="radiod" runat="server" GroupName="1" /></td></tr>
             
          </table>
            <center> <table class="auto-style4">
       <tr>
           <td><center><asp:Button ID="btnsub" runat="server" Text="Submit" Height="33px" Width="62px" OnClick="btnsub_Click" /></center></td>
           <td><center><asp:Button ID="btnskip" runat="server" Text="Skip" Height="33px" Width="50px" OnClick="btnskip_Click" /></center></td>
           
       </tr>
                </table></center>
             <table class="auto-style7">
                                  <tr><td><center><asp:Label ID="lblsub" runat="server" style="width:20px;height:15px;background-color:darkgreen;color:darkgreen" Text="green"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Submitted</center></td></tr>
                                  <tr><td><center><asp:Label ID="lblskip" runat="server" style="width:20px;height:15px;background-color:dimgray;color:dimgray" Text="green"></asp:Label>&nbsp;&nbsp;Not Attempt</center></td></tr>
                
             </table>
        </div></td>
           <td>
        <div id="d2" class="auto-style2">
            <table class="auto-style8">
                <tr><td colspan="3"><strong><center>Web Technology</center></strong></td></tr>
             <tr>
                 <td><center><asp:Button ID="btn1" runat="server" Text="1" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn1_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn2" runat="server" Text="2" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn2_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn3" runat="server" Text="3" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn3_Click"></asp:Button></center></td>
             </tr>
                 <tr>
                 <td><center><asp:Button ID="btn4" runat="server" Text="4" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn4_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn5" runat="server" Text="5" Font-Bold="true" style="width:30px;height:30px;"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn6" runat="server" Text="6" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn6_Click"></asp:Button></center></td>
             </tr>
                <tr><td colspan="3"><strong><center>C Programming</center></strong></td></tr>
                <tr>
                 <td><center><asp:Button ID="btn7" runat="server" Text="7" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn7_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn8" runat="server" Text="8" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn8_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn9" runat="server" Text="9" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn9_Click"></asp:Button></center></td>
             </tr>
                 <tr>
                 <td><center><asp:Button ID="btn10" runat="server" Text="10" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn10_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn11" runat="server" Text="11" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn11_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn12" runat="server" Text="12" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn12_Click"></asp:Button></center></td>
             </tr>
                <tr><td colspan="3"><strong><center>Java Programming</center></strong></td></tr>
                <tr>
                 <td><center><asp:Button ID="btn13" runat="server" Text="13" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn13_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn14" runat="server" Text="14" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn14_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn15" runat="server" Text="15" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn15_Click"></asp:Button></center></td>
             </tr>
                 <tr>
                 <td><center><asp:Button ID="btn16" runat="server" Text="16" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn16_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn17" runat="server" Text="17" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn17_Click"></asp:Button></center></td>
                 <td><center><asp:Button ID="btn18" runat="server" Text="18" Font-Bold="true" style="width:30px;height:30px;" OnClick="btn18_Click"></asp:Button></center></td>
             </tr>
                 </table>
        </div></td></tr></table>
              <div style="margin-left:50px;margin-top:30px;text-align:left">
                 
                  <asp:Label ID="lblans" runat="server"></asp:Label>
              </div>
              </div>

</center>
    </form>
</body>
</html>
