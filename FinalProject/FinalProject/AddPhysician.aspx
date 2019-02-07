<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="AddPhysician.aspx.vb" Inherits="AddPhysician" StylesheetTheme="Theme1" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div class="pagemid">
    <table class="auto-style1">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style13" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblAddPhysician" runat="server" Font-Bold="True" Text="Add Physician"></asp:Label>
                </td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
                    &nbsp;<asp:RequiredFieldValidator ID="valFname" runat="server" ControlToValidate="txtFname" ErrorMessage="Must have First name." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                    &nbsp;<asp:RequiredFieldValidator ID="valGender" runat="server" BorderColor="Red" ControlToValidate="dprGender" ErrorMessage="Must Select Gender" ForeColor="Red" InitialValue="Gender" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style21">
                    <asp:DropDownList ID="dprGender" runat="server" Height="22px" Width="126px">
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
                    &nbsp;<asp:RequiredFieldValidator ID="valLname" runat="server" ControlToValidate="txtLname" ErrorMessage="Must fill in Last name." ForeColor="Red">*</asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtHmPn" runat="server">(___)___-____</asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="txtZip" runat="server">_____</asp:TextBox>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblCell" runat="server" Text="Cell Phone"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCell" runat="server">(___)___-____</asp:TextBox>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style18"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="3">
                    <asp:Button ID="btnAddPhysician" runat="server" BorderStyle="Ridge" Text="Add  Physisican" Width="114px" />
                    <asp:Button ID="btnClear" runat="server" BorderStyle="Ridge" Text="Clear" Width="100px" CausesValidation="False" />
                    <asp:Button ID="btnExit" runat="server" BorderStyle="Ridge" Text="Exit" Width="100px" CausesValidation="False" />
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
                <td class="auto-style21">
                    <asp:Label ID="lblSuccess" runat="server" Text="Success" Visible="False"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
        </table>
        </div>
</asp:Content>