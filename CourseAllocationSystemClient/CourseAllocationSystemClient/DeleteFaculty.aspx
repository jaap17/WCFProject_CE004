<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteFaculty.aspx.cs" Inherits="CourseAllocationSystemClient.DeleteFaculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
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
    
       <div class="header">
          <div class="jumbotron mx-auto text-center">
                <h1>Course Allocation System</h1>
          </div>
   
       </div>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <table class="admintable">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Faculty First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Delete Faculty" class="btn btn-block btn-danger" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
