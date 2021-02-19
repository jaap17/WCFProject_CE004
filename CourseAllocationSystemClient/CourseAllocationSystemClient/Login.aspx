<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CourseAllocationSystemClient.Login" %>

 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background-color:cornsilk;
        }

        #form1
        {
            margin:auto;
            margin-left:500px;
        }

        

        td{
            padding:25px;
        }

        #table1
        {
            background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
            margin:20px;
        }
    </style>
</head>
<body>
    <div class="jumbotron mx-auto text-center">
            <h1>Course Allocation System</h1>
    </div>
    <br />
    <form id="form1" runat="server" >
        <div>
            <table id="table1">
                <tr>
                    <td colspan="2" class="text-center" style="font-size:40px;margin:15px;" >
                        Login Page 
                        
                    </td>
                </tr>
                <tr style="margin-top:20px;">
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Textbox1" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="Textbox2" runat="server" TextMode="Password"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" class="btn-block btn-danger" />
                    </td>
                </tr>
            </table>

            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>

            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
