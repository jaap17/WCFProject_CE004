<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSubject.aspx.cs" Inherits="CourseAllocationSystemClient.DeleteSubject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.min.css"/>
    <style>
        .header div
        {
            background-color:aqua;
        }

        .delete td
        {
            padding:20px;
            text-align:center;
        }

        .delete
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
             <div class="jumbotron mx-auto text-center">
                <h1>Course Allocation System</h1>
            </div>
        </div>
        <div>
            <table class="delete">
                <tr>
                    <td>

                        <asp:Label ID="Label1" runat="server" Text="Subject Id" Font-Size="XX-Large"></asp:Label>

                    </td>
                    <td>

                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click"  class="btn btn-info btn-block" Text="Delete" />

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" class="btn btn-block btn-success" Text="View Even Subjects" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button3" runat="server" class="btn btn-block btn-danger" Text="View Odd Subjects" OnClick="Button3_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
            <br />

            
           
            
        </div>
    </form>
</body>
</html>
