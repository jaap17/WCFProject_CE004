<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllocation.aspx.cs" Inherits="CourseAllocationSystemClient.ViewAllocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"  href="Content/bootstrap.min.css" />
    <title></title>
    <style>
        .header div
        {
            background-color:aqua;
        }
        body
        {
            background-color:cornsilk;
        }
        #GridView1
        {
            margin-left:500px;
            height:500px;
            background-color:cadetblue;
        }

        #GridView1 td
        {
            padding:20px;
            margin:10px;
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
            <a class="btn btn-danger" style="float:right" href="Login.aspx">Logout</a>
        </div>
        <div class="h1">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
