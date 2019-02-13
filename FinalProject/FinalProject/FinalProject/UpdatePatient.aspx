<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePatient.aspx.vb" Inherits="UpdatePatient" MasterPageFile="~/MasterPage.master" StylesheetTheme="Theme1"%>


<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
     <div>
            <h1 align="center"><u>Update Patient Information</u></h1>

            <table align="center">

                <tr>
                    <td>
                        <asp:Label ID="lblFName" runat="server" Text="First Name:" Font-Bold="true"></asp:Label> 
                        <asp:RequiredFieldValidator ID="rfvFName" runat="server" ErrorMessage="*" ControlToValidate="txtFName" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblGender" runat="server" Text="Gender:" Font-Bold="true"></asp:Label>
                        <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="*" ControlToValidate="ddlGender" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMiddle" runat="server" Text="Middle Initial:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtMiddle" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblAddress" runat="server" Text="Address:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLName" runat="server" Text="Last Name:" Font-Bold="true"></asp:Label>
                        <asp:RequiredFieldValidator ID="rfvLName" runat="server" ErrorMessage="*" ControlToValidate="txtLName" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCity" runat="server" Text="City:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth:" Font-Bold="true"></asp:Label>
                        <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ErrorMessage="*" ControlToValidate="txtDOB" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblState" runat="server" Text="State:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem Selected="True">Select State</asp:ListItem>
                            <asp:ListItem>Alabama</asp:ListItem>
                            <asp:ListItem>Alaska</asp:ListItem>
                            <asp:ListItem>Arizona</asp:ListItem>
                            <asp:ListItem>Arkansas</asp:ListItem>
                            <asp:ListItem>California</asp:ListItem>
                            <asp:ListItem>Colorado</asp:ListItem>
                            <asp:ListItem>Connecticut</asp:ListItem>
                            <asp:ListItem>Delaware</asp:ListItem>
                            <asp:ListItem>Flordia</asp:ListItem>
                            <asp:ListItem>Georgia</asp:ListItem>
                            <asp:ListItem>Hawaii</asp:ListItem>
                            <asp:ListItem>Idaho</asp:ListItem>
                            <asp:ListItem>Illinois</asp:ListItem>
                            <asp:ListItem>Indiana</asp:ListItem>
                            <asp:ListItem>Iowa</asp:ListItem>
                            <asp:ListItem>Kansas </asp:ListItem>
                            <asp:ListItem>Kentucky</asp:ListItem>
                            <asp:ListItem>Louisiana </asp:ListItem>
                            <asp:ListItem>Maine </asp:ListItem>
                            <asp:ListItem>Maryland</asp:ListItem>
                            <asp:ListItem>Massachusetts </asp:ListItem>
                            <asp:ListItem>Michigan</asp:ListItem>
                            <asp:ListItem>Minnesota </asp:ListItem>
                            <asp:ListItem>Mississippi </asp:ListItem>
                            <asp:ListItem>Missouri</asp:ListItem>
                            <asp:ListItem>Montana</asp:ListItem>
                            <asp:ListItem>Nebraska</asp:ListItem>
                            <asp:ListItem>Nevada</asp:ListItem>
                            <asp:ListItem>New Hampshire</asp:ListItem>
                            <asp:ListItem>New Jersey </asp:ListItem>
                            <asp:ListItem>New Mexico</asp:ListItem>
                            <asp:ListItem>New York </asp:ListItem>
                            <asp:ListItem>North Carolina </asp:ListItem>
                            <asp:ListItem>North Dakota</asp:ListItem>
                            <asp:ListItem>Ohio</asp:ListItem>
                            <asp:ListItem>Oklahoma</asp:ListItem>
                            <asp:ListItem>Oregon</asp:ListItem>
                            <asp:ListItem>Pennsylvania</asp:ListItem>
                            <asp:ListItem>Rhode Island</asp:ListItem>
                            <asp:ListItem>South Carolina</asp:ListItem>
                            <asp:ListItem>South Dakota</asp:ListItem>
                            <asp:ListItem>Tennessee</asp:ListItem>
                            <asp:ListItem>Texas</asp:ListItem>
                            <asp:ListItem>Utah</asp:ListItem>
                            <asp:ListItem>Vermont </asp:ListItem>
                            <asp:ListItem>Virginia</asp:ListItem>
                            <asp:ListItem>Washington </asp:ListItem>
                            <asp:ListItem>West Virginia </asp:ListItem>
                            <asp:ListItem>Wisconsin</asp:ListItem>
                            <asp:ListItem>Wyoming</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblHomePhone" runat="server" Text="Home Phone:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtHPhone" runat="server" TextMode="Phone"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblZip" runat="server" Text="Zip:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtZip" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCellPhone" runat="server" Text="Cell Phone:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:TextBox ID="txtCPhone" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update"  />             
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
            <asp:Button ID="btnExit" runat="server" Text="Exit" />

            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>
</asp:Content>