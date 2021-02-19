<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Allocation.aspx.cs" Inherits="CourseAllocationSystemClient.Allocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background-color:cornsilk;
        }

        .choice
        {
            border:none;
            margin-left:400px;
        }

        .choice tr
        {
            text-align: left;
            vertical-align: top;
        }

        .choice td
        {
             vertical-align: top;
             text-align:center;
             padding-bottom: 50px;
        }

        #Table1
        {
           
            margin-left:400px;
            padding:10px;
        }

       

        #Button1
        {
            margin-left:550px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron mx-auto text-center">
            <h1>Course Allocation System</h1>
        </div>
        <div class="nav">
        <a  style="float:right;"  class="btn btn-success" href="AdminHomepage.aspx">Homepage</a>
        <a href="Login.aspx" style="float:right;" class="btn btn-danger">Logout</a>
    </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" class="choice" ></asp:GridView>
            <br />
           
                <asp:Table ID="Table1"  runat="server">
                
                </asp:Table>
                <br />
                <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Store Allocation" OnClick="Button1_Click" />
         
            
        </div>
        
             <asp:GridView ID="GridView2" runat="server" CssClass="bg-info"></asp:GridView>
        
       
        <br />
        <asp:GridView ID="GridView3" runat="server"></asp:GridView><br />
        <asp:Label ID="label5" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
