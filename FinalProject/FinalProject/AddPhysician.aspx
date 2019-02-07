<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddPhysician.aspx.vb" Inherits="AddPhysician" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
                <td class="auto-style1">
                    <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="drpState" runat="server" Height="16px" Width="127px">
                        <asp:ListItem>Select State</asp:ListItem>
                        <asp:ListItem Value="AL">Alabama</asp:ListItem>
                        <asp:ListItem Value="AK">Alaska</asp:ListItem>
                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                        <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                        <asp:ListItem Value="CA">California</asp:ListItem>
                        <asp:ListItem Value="CO">Colorado</asp:ListItem>
                        <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                        <asp:ListItem Value="DE">Delaware</asp:ListItem>
                        <asp:ListItem Value="FL">Florida</asp:ListItem>
                        <asp:ListItem Value="GA">Georgia</asp:ListItem>
                        <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                        <asp:ListItem Value="ID">Idaho</asp:ListItem>
                        <asp:ListItem Value="IL">Illinois</asp:ListItem>
                        <asp:ListItem Value="IN">Indiana</asp:ListItem>
                        <asp:ListItem Value="IA">Iowa</asp:ListItem>
                        <asp:ListItem Value="KS">Kansas</asp:ListItem>
                        <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                        <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                        <asp:ListItem Value="ME">Maine</asp:ListItem>
                        <asp:ListItem Value="MD">Maryland</asp:ListItem>
                        <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                        <asp:ListItem Value="MI">Michigan</asp:ListItem>
                        <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                        <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                        <asp:ListItem Value="MO">Missouri</asp:ListItem>
                        <asp:ListItem Value="MT">Montana</asp:ListItem>
                        <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                        <asp:ListItem Value="NV">Nevada</asp:ListItem>
                        <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                        <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                        <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                        <asp:ListItem Value="NY">New York</asp:ListItem>
                        <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                        <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                        <asp:ListItem Value="OH">Ohio</asp:ListItem>
                        <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                        <asp:ListItem Value="OR">Oregon</asp:ListItem>
                        <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                        <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                        <asp:ListItem Value="SC">South Caronlina</asp:ListItem>
                        <asp:ListItem Value="SD">South Daokta</asp:ListItem>
                        <asp:ListItem Value="TN">Temmessee</asp:ListItem>
                        <asp:ListItem Value="TX">Texas</asp:ListItem>
                        <asp:ListItem Value="UT">Utah</asp:ListItem>
                        <asp:ListItem Value="VT">Vermont</asp:ListItem>
                        <asp:ListItem Value="VA">Virginia</asp:ListItem>
                        <asp:ListItem Value="WA">Washington</asp:ListItem>
                        <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                        <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                        <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1"></td>
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
    </form>
</body>
</html>
