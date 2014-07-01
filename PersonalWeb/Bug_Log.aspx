<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bug_Log.aspx.cs" Inherits="PersonalWeb.Bug_Log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log your bugs</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border:solid;width:100%">
        <tr><td class="auto-style1">
            <h2>Bug Monitor</h2>
            </td></tr>
        <tr style="border:solid"><td>
            <table style="width:100%">
                <tr><td colspan="4"><h3>Please enter defect details below</h3></td></tr>
                <tr><td>Name</td><td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td><td>Type</td><td>
                    <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
                    </td></tr>
                <tr><td>Severity</td><td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">High</asp:ListItem>
                        <asp:ListItem Value="2">Medium</asp:ListItem>
                        <asp:ListItem Value="3">Low</asp:ListItem>
                    </asp:DropDownList>
                    </td><td>Priority</td><td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>High</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Low</asp:ListItem>
                    </asp:DropDownList>
                    </td></tr>
                <tr><td>Raised By</td><td>
                    <asp:TextBox ID="txtRaisedBy" runat="server"></asp:TextBox>
                    </td><td>Logged Date</td><td>
                    <asp:TextBox ID="txtLoggedDate" runat="server" ReadOnly="True" TextMode="DateTimeLocal"></asp:TextBox>
                    </td></tr>
                <tr><td>Subject</td><td>
                    <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                    </td><td></td><td></td></tr>
                <tr><td>Description</td><td colspan="3">
                    <asp:TextBox ID="txtDescription" runat="server" Width="527px" Height="100px" TextMode="MultiLine"></asp:TextBox>
                    </td></tr>
                <tr><td>Comments</td><td colspan="3">
                    <asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine" Height="37px" Width="527px"></asp:TextBox>
                    </td></tr>
                <tr><td>Attachment</td><td>
                    <asp:FileUpload ID="fileUpload" runat="server" />
                    </td><td>&nbsp;</td><td></td></tr>
                <tr><td></td><td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td><td></td><td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" />
                    </td></tr>
                <tr><td></td><td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                    </td><td></td><td></td></tr>
                </table>
                                 </td></tr>
        <tr style="border:solid"><td>

                                 </td></tr>
    </table>
    </div>
    </form>
</body>
</html>
