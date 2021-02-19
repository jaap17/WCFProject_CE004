<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsufficientChoices.aspx.cs" Inherits="CourseAllocationSystemClient.InsufficientChoices" %>

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
             height:300px;
            font-size:30px;
        }

        .admintable td
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
        <div class="admintable">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Back To Homepage" class="btn btn-block btn-success" OnClick="Button1_Click" />
        </div>

    </form>
</body>
</html>
