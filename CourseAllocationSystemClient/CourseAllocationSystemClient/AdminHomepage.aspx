<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomepage.aspx.cs" Inherits="CourseAllocationSystemClient.AdminHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <style>
         body
         {
            background-color:cornsilk;
        }
        .admintable
        {
            margin-left:400px;
            background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
           
        }

        .admintable td
        {
            padding:30px;
        }

        #admin
        {
            border-radius:20px;
        }
        body{
            background-color:cornsilk;
        }

        .header div
        {
            background-color:aqua;
        }

    </style>
</head>
<body style="height: 66px">
    <div class="header">
         <div class="jumbotron mx-auto text-center">
            <h1>Course Allocation System</h1>
          </div>
   
    </div>
    <div class="nav">
         <a class="btn btn-secondary" style="margin-left:20px;float:right;" href="Login.aspx"> Logout </a>
    </div>
    <br />
    <h1 class="bg-primary text-center text-capitalize" id="admin">Welcome Dr Pankaj Jalote to your Homepage</h1>
    <form id="form1" runat="server" >
        <div>
            <table class="admintable">
                <tr>
                    <td class="text-center">

                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Manage Subjects" class="btn btn-block btn-info"/>

                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Button ID="Button2" runat="server" Text="Generate Choice Filling Forms" OnClick="Button2_Click" class="btn btn-block btn-success"/>
                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Button ID="Button3" runat="server" class="btn btn-block btn-danger" Text="Perform Allocation" OnClick="Button3_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="text-center">
                        <asp:Button ID="Button4" runat="server" class="btn btn-block btn-primary" Text="View Allocation" OnClick="Button4_Click" />
                    </td>
                </tr>
                 <tr>
                    <td class="text-center">
                        <asp:Button ID="Button5" runat="server" class="btn btn-block btn-info" Text="Manage Faculties" OnClick="Button5_Click" />
                    </td>
                </tr>
            </table>   
        </div>
    </form>
</body>
</html>
