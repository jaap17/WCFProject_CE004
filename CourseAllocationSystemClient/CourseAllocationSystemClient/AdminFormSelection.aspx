<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFormSelection.aspx.cs" Inherits="CourseAllocationSystemClient.AdminFormSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.min.css"/>
    <style>
        body
        {
            background-color:cornsilk;
        }

        .header div
        {
            background-color:aqua;
        }

        .choicetable
        {
             margin-left:400px;
            background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
            
        }

        .choicetable td
        {
            padding:30px;
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
        </div>
        <div class="nav">
        <a  style="float:right;"  class="btn btn-success" href="AdminHomepage.aspx">Homepage</a>
        <a href="Login.aspx" style="float:right;" class="btn btn-danger">Logout</a>
    </div>
        <div>
            <h1>
                You are Signed in as<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </h1>
            <br />
           
            <table class="choicetable">
                <tr>
                    <td>
                         <h1>Select the type of Semester for which the choice Filling has to be Done.</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Even" class="btn btn-block btn-danger" OnClick="Button1_Click" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Odd" class="btn btn-block btn-info" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
