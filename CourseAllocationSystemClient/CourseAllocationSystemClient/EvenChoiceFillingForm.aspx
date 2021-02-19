<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvenChoiceFillingForm.aspx.cs" Inherits="CourseAllocationSystemClient.EvenChioiceFillingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                
                    Some Instructions for choice filling:-<br />
                    1) Please Select Unique choices in priority.<br />
                    2) No Two different priorities can have the same Subject Selected<br />
                    3) Check your choices before submission<br />
            </p>
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <table>
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
                        <asp:Button ID="Button1" runat="server" Text="Submit Choice Filling" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</body>
</html>
