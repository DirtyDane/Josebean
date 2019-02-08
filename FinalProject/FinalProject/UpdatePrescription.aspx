<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePrescription.aspx.vb" Inherits="UpdatePrescription" MasterPageFile="~/MasterPage.master" StylesheetTheme="Theme1"%>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div>
 <h1 align="center"><u>Update Prescription Information</u></h1>
            <table align="center" style="height: 0px; width: 651px">
             
                <tr>
                    <td>
                        <asp:Label ID="lblPrescript" runat="server" Text="Prescription No.:" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:TextBox ID="txtPrescriptNo" runat="server"></asp:TextBox>
                    </td>  
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="lblPatient" runat="server" Text="Patient Name:" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:TextBox ID="txtPatient" runat="server"></asp:TextBox> 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDosage" runat="server" Text="Dosage:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:DropDownList ID="ddlDosage" runat="server">
                            <asp:ListItem Selected="True">Select mg</asp:ListItem>
                            <asp:ListItem>10mg</asp:ListItem>
                            <asp:ListItem>20mg</asp:ListItem>
                            <asp:ListItem>25mg</asp:ListItem>
                            <asp:ListItem>50mg</asp:ListItem>
                            <asp:ListItem>80mg</asp:ListItem>
                            <asp:ListItem>100mg</asp:ListItem>
                            <asp:ListItem>150mg</asp:ListItem>
                            <asp:ListItem>200mg</asp:ListItem>
                            <asp:ListItem>300mg</asp:ListItem>
                            <asp:ListItem>500mg</asp:ListItem>
                            <asp:ListItem>1000mg</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="lblPhysician" runat="server" Text="Physician Name:" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:TextBox ID="txtPhysician" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblIntakeMethod" runat="server" Text="Intake Method:" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:DropDownList ID="ddlIntakeMethod" runat="server">
                            <asp:ListItem Selected="True">Select Intake Method</asp:ListItem>
                            <asp:ListItem>Oral</asp:ListItem>
                            <asp:ListItem>Suppository</asp:ListItem>
                            <asp:ListItem>Injection</asp:ListItem>
                            <asp:ListItem>IV</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
              
                <tr>
                    <td>
                        <asp:Label ID="lblMedication" runat="server" Text="Medication:" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:DropDownList ID="ddlMedication" runat="server"></asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblFrequency" runat="server" Text="Frequency:" Font-Bold="true"></asp:Label> &nbsp; 
                        <asp:DropDownList ID="ddlFrequency" runat="server">
                            <asp:ListItem Selected="True">Select Frequency</asp:ListItem>
                            <asp:ListItem>1x Daily</asp:ListItem>
                            <asp:ListItem>2x Daily</asp:ListItem>
                            <asp:ListItem>Every 4 Hours</asp:ListItem>
                            <asp:ListItem>Every 8 Hours</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
             
                <tr>
                    <td>
                        <asp:Label ID="lblRefills" runat="server" Text="Refill(s):" Font-Bold="true"></asp:Label> &nbsp;
                        <asp:TextBox ID="txtRefills" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
</asp:Content>