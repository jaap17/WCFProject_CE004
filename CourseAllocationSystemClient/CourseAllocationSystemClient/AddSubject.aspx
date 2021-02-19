<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="CourseAllocationSystemClient.AddSubjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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

        .addsubject
        {
             background-color:rebeccapurple;
            width:50%;
            border-radius:20px;
            padding:20px;
            margin:20px;
            margin-left:400px;
            height:500px;
        }

         .addsubject td
        {
              padding:20px;
              text-align:center;
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
    <link rel="stylesheet" href="Content/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
             <div class="jumbotron mx-auto text-center">
                <h1>Course Allocation System</h1>
            </div>
        </div>
        <div>
            <table class="addsubject">
                <tr>
                    <td>

                        <asp:Label ID="Label1" runat="server" Text="SubjectId" Font-Size="XX-Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="Label2" runat="server" Text="Subject Name" Font-Size="XX-Large"></asp:Label>

                    </td>
                    <td>

                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="Label3" runat="server" Text="Semester" Font-Size="XX-Large"></asp:Label>

                    </td>
                    <td>

                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button ID="Button1" class="btn btn-block btn-info"   runat="server" OnClick="Button1_Click" Text="Add Subject" />

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" class="btn btn-block btn-success" runat="server" Text="View Odd Subjects" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button3" class="btn btn-block btn-danger" runat="server" Text="View Even Subjects" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>  
            
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label> 
        </div>
    </form>
</body>
</html>
