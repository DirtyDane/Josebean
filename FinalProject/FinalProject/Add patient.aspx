<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Add patient.aspx.vb" Inherits="Add_patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 97%;
        }
        .auto-style3 {
            width: 137px;
        }
        .auto-style6 {
            width: 137px;
            height: 26px;
        }
        .auto-style9 {
            width: 111px;
        }
        .auto-style10 {
            width: 111px;
            height: 26px;
        }
        .auto-style12 {
            width: 66px;
            height: 26px;
        }
        .auto-style13 {
            margin-left: 40px;
        }
        .auto-style16 {
            width: 66px;
        }
        .auto-style18 {
            height: 26px;
            width: 10px;
        }
        .auto-style19 {
            width: 1px;
        }
        .auto-style20 {
            width: 1px;
            height: 26px;
        }
        .auto-style21 {
            width: 10px;
        }
    </style>
</head>
<body style="width: 475px; height: 270px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style13" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblAddPhysician" runat="server" Font-Bold="True" Text="Add Patient"></asp:Label>
                </td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
                    <asp:RequiredFieldValidator ID="valFname" runat="server" ControlToValidate="txtFname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                    <asp:RequiredFieldValidator ID="valGender" runat="server" ControlToValidate="drpGender" ErrorMessage="*" ForeColor="Red" InitialValue="Gender"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="drpGender" runat="server" Width="122px">
                        <asp:ListItem>Gender</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblMidinit" runat="server" Text="Middle Initial"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtMidinit" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblLname" runat="server" Text="Last Name"></asp:Label>
                    <asp:RequiredFieldValidator ID="valLname" runat="server" ControlToValidate="txtLname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
                    <asp:RequiredFieldValidator ID="valDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblHmPn" runat="server" Text="Home Phone"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtHmPn" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="txtZip" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblCell" runat="server" Text="Cell Phone"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCell" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style18"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="3">
                    <asp:Button ID="btnAddPhysician" runat="server" BorderStyle="Outset" Text="Add  Patient" Width="100px" />
                    <asp:Button ID="btnClear" runat="server" BorderStyle="Inset" Text="Clear" Width="100px" />
                    <asp:Button ID="btnExit" runat="server" BorderStyle="Outset" Text="Exit" Width="100px" />
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
