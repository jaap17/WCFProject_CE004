<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OddChoiceFillingForm.aspx.cs" Inherits="CourseAllocationSystemClient.OddChoiceFillingForm" %>

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
        </div>
        <div class="nav">
            <asp:Button ID="Button2" class="btn btn-primary" runat="server" style="float:right;" Text="Homepage" OnClick="Button2_Click" /> 
            <a class="btn btn-secondary" style="margin-left:20px;float:right;" href="Login.aspx"> Logout </a>
        </div>
        <div>
            <p class="h3">
                
                    Some Instructions for choice filling:-<br />
                    1) Please Select Unique choices in priority.<br />
                    2) No Two different priorities can have the same Subject Selected<br />
                    3) Check your choices before submission<br />
            </p>
            <br />
            <p class="text-center bg-info">You are Signed in as<asp:Label ID="Label2" runat="server" Text=""></asp:Label></p>
            <br />
            <table class="choicetable">
                <tr>
                    <td>
                        <h2>Priority</h2>
                    </td>
                    <td>
                        <h2>
                            Subject Selection
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h2>1</h2>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <h2>2</h2>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <h2>3</h2>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <h2>4</h2>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <h2>5</h2>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList5" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit Choices" class="btn btn-block btn-info" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <br /><br />
    </form>
</body>
</html>
