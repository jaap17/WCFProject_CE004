<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectSemester.aspx.cs" Inherits="CourseAllocationSystemClient.SelectSemester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        #admin
        {
            border-radius:20px;
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
            text-align:center;
            padding:30px;
        }

    </style>
</head>
<body>
     <div class="jumbotron mx-auto text-center">
            <h1>Course Allocation System</h1>
    </div>
     <div class="nav">
        <a  style="float:right;"  class="btn btn-success" href="AdminHomepage.aspx">Homepage</a>
        <a href="Login.aspx" style="float:right;" class="btn btn-danger">Logout</a>
    </div>
    <br />
    <form id="form1" runat="server">
        <div>
            <h1 class="bg-primary" id="admin">
                You are Signed in as <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </h1>
            <br />
            <table class="admintable">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Select the Type of Semester" CssClass="h2"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Even" class="btn btn-success" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="btn btn-danger" Text="Odd" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
