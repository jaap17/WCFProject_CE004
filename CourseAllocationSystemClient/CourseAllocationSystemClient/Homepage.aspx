<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="CourseAllocationSystemClient.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .header div
        {
            background-color:aqua;
        }

        body
        {
            background-color:cornsilk;
        }

        .user td
        {
            padding:20px;
            text-align:center;
        }

        .user
        {
            background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
            margin:20px;
            margin-left:400px;
            height:500px;
        }

        #Button1
        {
            height:50px;
            border-radius:20px;
            font-size:20px;
            padding:20px;
            text-align:center;
        }

        #Button2
        {
            height:50px;
            border-radius:20px;
            font-size:20px;
            padding:20px;
            margin-bottom:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
             <div class="jumbotron mx-auto text-center">
                <h1>Course Allocation System</h1>
            </div>
        </div>
         <div class="nav">
         <a class="btn btn-secondary" style="margin-left:20px;float:right;" href="Login.aspx"> Logout </a>
        </div>
        <div>
            <div class="h1 text-center">
                 You are Signed in as <asp:Label ID="Label1" BackColor="WhiteSmoke" Font-Italic="true" runat="server"></asp:Label>
            </div>
           
            <br />
            <table class="user">
                <tr>
                    <td>
                        <h1>Select one of the Below options</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" BackColor="YellowGreen"  class="btn btn-block btn-success" Text="Perform Choice Filling" runat="server" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Button ID="Button2" class="btn btn-block btn-info"  Text="View Course Allocation" runat="server" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>

    </form>
</body>
</html>
