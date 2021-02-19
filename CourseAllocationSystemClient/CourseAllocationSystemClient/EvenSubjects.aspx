<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvenSubjects.aspx.cs" Inherits="CourseAllocationSystemClient.EvenSubjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 
        {
            margin-left: 18px;
        }

        body
        {
            background-color:cornsilk;
        }

        .eventable
        {
            margin-left:300px;
            
            width:50%;
            border-radius:20px;
            padding:20px;
        }

        .eventable td
        {
            padding:20px;
            background-color:aqua;
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
            <table class="eventable">
                <tr>
                    <td colspan="3" class="text-center">
                        <h2>List of Even Semester Subjects</h2>
                    </td>
                </tr>
                <tr>
                    <td> 
                        <table border="1">
                            <tr>
                                <td>
                                     <asp:GridView ID="GridView3" runat="server" BackColor="YellowGreen">
                                    </asp:GridView>
                       
                                </td>
                              
                            </tr>
                            <tr>
                                <td>

                                    <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Add Subject" OnClick="Button1_Click" />


                                    <asp:Button ID="Button2"  runat="server" class="btn btn-danger" OnClick="Button2_Click" Text="Delete" Width="88px" />


                                </td>
                               
                                
                            </tr>
                        </table>
                       

                    </td>
                   <td>
                       <table border="1">
                           <tr>
                               <td>
                                   <asp:GridView ID="GridView4" runat="server">
                                    </asp:GridView>
                               </td>
                           </tr>
                           <tr>
                                <td>

                                    <asp:Button ID="Button3" class="btn btn-primary" runat="server" Text="Add Subject" OnClick="Button1_Click" />


                                    <asp:Button ID="Button4" runat="server" class="btn btn-danger" OnClick="Button2_Click" Text="Delete" Width="88px" />


                                </td>
                           </tr>
                       </table>
                       

                   </td>
                    <td>

                         <table border="1">
                           <tr>
                               <td>
                                   <asp:GridView ID="GridView5" runat="server">
                                    </asp:GridView>
                               </td>
                           </tr>
                           <tr>
                                <td>

                                    <asp:Button ID="Button5" runat="server" class="btn btn-primary" Text="Add Subject" OnClick="Button1_Click" />


                                    <asp:Button ID="Button6" runat="server" class="btn btn-danger" OnClick="Button2_Click" Text="Delete" Width="88px" />


                                </td>
                           </tr>
                       </table>

                    </td>
                       
                </tr>
            </table>
            <br /><br />
        </div>
    </form>
</body>
</html>

