<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePatient.aspx.vb" Inherits="UpdatePatient" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>
<link href="UpdatePatient.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1 align="center">Update Patient Information</h1>

            <table align="center">

                <tr>
                    <td>
                        <b>Patient ID:</b> &nbsp; <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>Cell Phone:</b> &nbsp; <asp:TextBox ID="txtCPhone" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>First Name:</b> &nbsp; <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>Gender:</b> &nbsp; <asp:ListBox ID="lbGender" runat="server" Height="22px" Width="123px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Middle Initial:</b> &nbsp; <asp:TextBox ID="txtMiddle" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>Address:</b> &nbsp; <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Last Name:</b> &nbsp; <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>City:</b> &nbsp; <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Date of Birth:</b> &nbsp; <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>State:</b> &nbsp; <asp:ListBox ID="lbState" runat="server" Height="22px" Width="150px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Home Phone:</b> &nbsp; <asp:TextBox ID="txtHPhone" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <b>Zip:</b> &nbsp; <asp:TextBox ID="txtZip" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
