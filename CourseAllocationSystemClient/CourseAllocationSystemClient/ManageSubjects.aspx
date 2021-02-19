<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSubjects.aspx.cs" Inherits="CourseAllocationSystemClient.ManageSubjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <title></title>
    <style>
        .header div
        {
            background-color:aqua;
        }
         .admintable
        {
            margin-top:50px;
            margin-left:400px;
            background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
            height:300px;
            
        }

        .admintable td
        {
            padding:30px;
        }

        body
        {
            background-color:cornsilk;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <div class="header">
             <div class="jumbotron mx-auto text-center">
                <h1>Course Allocation System</h1>
              </div>
   
        </div>
        <div class="nav">
        <a  style="float:right;"  class="btn btn-success" href="AdminHomepage.aspx">Homepage</a>
        <a href="Login.aspx" style="float:right;" class="btn btn-danger">Logout</a>
    </div>
        <div class="container">
             <asp:Label ID="Label1" runat="server" class="bg-primary h2" Text=""></asp:Label>
        </div>
           
         <table class="admintable">
             <tr>
                 <td>
                     <asp:Button ID="Button1" class="btn btn-block btn-success" runat="server" Text="Add Faculty" OnClick="Button1_Click" />
                 </td>

             </tr>
             <tr>
                 <td>
                     <asp:Button ID="Button2" runat="server" Text="Delete Faculty" class="btn btn-block btn-danger" OnClick="Button2_Click" />
                 </td>
                 
             </tr>
         </table>
        </div>
    </form>
</body>
</html>
