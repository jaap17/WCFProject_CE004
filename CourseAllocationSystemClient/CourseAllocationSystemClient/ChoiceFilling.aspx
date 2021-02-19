<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChoiceFilling.aspx.cs" Inherits="CourseAllocationSystemClient.ChoiceFilling" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label> to Your Homepage
            <table>
                <tr>
                    <td>Priority</td>
                    <td>Subject Selection</td>
                </tr>
                <tr>
                    <td>
                        
                        <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
                        
                    </td>
                    <td>
                        
                        <asp:DropDownList ID="DropDownList1" runat="server">
                           
                           
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="2"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                             
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="3"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server">
                           
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="4"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList4" runat="server">
                           
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="5"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList5" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit Choice Filling" OnClick="Button1_Click" />
                    </td>
                </tr>
               
            </table>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
             <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
