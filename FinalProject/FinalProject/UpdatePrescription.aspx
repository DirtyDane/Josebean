<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePrescription.aspx.vb" Inherits="UpdatePrescription" %>

<!DOCTYPE html>

<link href="UpdatePrescription.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
 <h1 align="center">Update Prescription Information</h1>
            <table align="center" style="height: 0px; width: 651px">
             
                <tr>
                    <td>
                <b>Prescription No.:</b> &nbsp;<asp:TextBox ID="txtPrescriptNo" runat="server"></asp:TextBox>
                    </td>  
                </tr>
               
                <tr>
                    <td>
                <b>Patient Name:</b> &nbsp;<asp:TextBox ID="txtPatient" runat="server"></asp:TextBox> 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <b>Dosage:</b> &nbsp; <asp:DropDownList ID="ddlDosage" runat="server"></asp:DropDownList>
                    </td>
                </tr>
               
                <tr>
                    <td>
                <b>Physician Name:</b> &nbsp;<asp:TextBox ID="txtPhysician" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <b>Intake Method:</b> &nbsp;<asp:DropDownList ID="ddlIntakeMethod" runat="server"></asp:DropDownList>
                    </td>
                </tr>
              
                <tr>
                    <td>
                <b>Medication:</b> &nbsp;<asp:DropDownList ID="ddlMedication" runat="server"></asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <b>Frequency:</b> &nbsp; <asp:DropDownList ID="ddlFrequency" runat="server"></asp:DropDownList>
                    </td>
                </tr>
             
                <tr>
                    <td>
                <b>Refill(s):</b> &nbsp;<asp:TextBox ID="txtRefills" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
