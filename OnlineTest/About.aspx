<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="OnlineTest.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About</title>
    <style>
        #d1
        {
            width:60%;
            height:50px;
            background-color:lightsteelblue;
            color:navy;
            font-weight:bold;
            border-radius:35px;
        }
        h3{
            padding:20px;
        }
        #d2
        {
            
            background-color:lightgrey;
            border-radius:30px;
            width:80%;
            height:450px;
        }
        .auto-style1 {
            font-size: large;
        }
        caption {
        }
        a{
            text-decoration:none;
            font-size:20px;
            font-weight:bold;
            color:navy;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <center>    <div id="d1">
       
    <center><h3>About Online Test</h3></center>
    </div></center><br /><br />
       <center> <div id="d2">
           <div style="text-align:left;padding:40px">
             <ul>
                 <li class="auto-style1">Online Examination System is very useful for educational institue to prepare an exam, safe the time that will take to check the paper and prepare mark sheets.It will help the institue to testing of students and develop their skills.But the disadvantages for this system it take a lot of times when you prepare the exam at first time fro usage.And we need number of computer with number of students.</li>
             <br /><br />
                 <li class="auto-style1">The Effective use of &quot;Online Examination System&quot; any education institute or training centers can be use it to develop their strategy for putting the exam, and for gettingt better result in less time.</li>
                 <br /><br />
                 <li class="auto-style1">By Use of this project any educational institute,training centres can organise online examination on five subjects like Web Technology,C programming,C++ Programming,Java Programming and DBMS.</li>
                <br /><br />
                  <li class="auto-style1">For Use this project student must be Registered. When user register he can login by use his email id and password.after login he cant read the instructions about the exam and then he can give exam of every subjects. When user click on finish button he saw his result.</li>
           

             </ul>
               <br /><br />
               <a href="Home.aspx">Home</a>
           </div>
        </div></center>
    </form>
</body>
</html>
