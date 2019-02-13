<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AddPerscription.aspx.vb" Inherits="AddPerscription" StylesheetTheme="Theme1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div class="pagemid"> 
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style61"></td>
                <td class="auto-style50" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblAddPPerscription" runat="server" Font-Bold="True" Text="Add Prescription"></asp:Label>
                </td>
                <td class="auto-style51"></td>
                <td class="auto-style52"></td>
            </tr>
            <tr>
                <td class="auto-style62">
                    Prescription Number:&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style62">
                    <asp:TextBox ID="TextBox1" runat="server" Width="154px"></asp:TextBox>
                </td>
                <td class="auto-style62">
                    Intake Method:
                </td>
                <td class="auto-style62">
                    <asp:DropDownList ID="ddlIntake" runat="server"></asp:DropDownList>
                </td>
                <td class="auto-style48"></td>
            </tr>
            <tr>
                <td class="auto-style69">
                    Patient Name:&nbsp;&nbsp;
                </td>
                <td class="auto-style69">
                    <asp:Label ID="lblPatient" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style69">
                    Frequency:
                </td>
                <td class="auto-style69">
                    <asp:DropDownList ID="ddlFrequency" runat="server"></asp:DropDownList>
                </td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style69">
                    Physician :&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style69">
                    <asp:DropDownList ID="ddlPhysician" runat="server" Height="16px" Width="154px">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style69">
                    Refill Count:
                </td>
                <td class="auto-style69">
                    <asp:TextBox ID="txtRefill" runat="server" Width="154px"></asp:TextBox>
                </td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style64">
                    Medication:&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style64">
                    <asp:DropDownList ID="ddlMedication" runat="server"></asp:DropDownList>
                   
                </td>
                <td class="auto-style64" rowspan="2">
                    Refill Date:
                </td>
                <td class="auto-style64" rowspan="2">
                    <asp:Label ID="lblRefillDate" runat="server" Text="" BorderStyle="Inset"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39">
                    Dosage:&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style39">
                    <asp:DropDownList ID="ddlDosage" runat="server"></asp:DropDownList>
                </td>
                <td class="auto-style42"></td>
            </tr>
            <tr>
                <td class="auto-style67">
                    &nbsp;</td>
                <td class="auto-style31">
                    &nbsp;</td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td colspan="3">
                    <asp:Button ID="btnAddPrescription" runat="server" BorderStyle="Outset" Text="Add  Prescription" Width="122px" />
                    <asp:Button ID="btnClear" runat="server" BorderStyle="Outset" Text="Clear" Width="100px" />
                    <asp:Button ID="btnExit" runat="server" BorderStyle="Outset" Text="Exit" Width="100px" />
                </td>
                <td class="auto-style19">&nbsp;</td>
            </tr>

            <tr>
                <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Red"></asp:Label>
            </tr>
            <tr>
                <td class="auto-style66"></td>
                <td colspan="2" class="auto-style36">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
                <td class="auto-style37"></td>
                <td class="auto-style38"></td>
            </tr>
        </table>
    
        </div>
</asp:Content>


<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 1104px;
            height: 206px;
        }
    .auto-style29 {
        width: 32px;
        height: 26px;
    }
    .auto-style31 {
        height: 26px;
        width: 7px;
    }
    .auto-style36 {
        height: 65px;
    }
    .auto-style37 {
        width: 32px;
        height: 65px;
    }
    .auto-style38 {
        width: 1px;
        height: 65px;
    }
    .auto-style39 {
        height: 41px;
        text-align: center;
    }
    .auto-style42 {
        width: 1px;
        height: 41px;
    }
    .auto-style48 {
        width: 1px;
        height: 68px;
    }
    .auto-style50 {
        margin-left: 40px;
        height: 47px;
    }
    .auto-style51 {
        width: 32px;
        height: 47px;
    }
    .auto-style52 {
        width: 1px;
        height: 47px;
    }
    .auto-style61 {
        width: 97px;
        height: 47px;
    }
    .auto-style62 {
        text-align: center;
        height: 68px;
    }
    .auto-style64 {
        text-align: center;
    }
    .auto-style66 {
        width: 97px;
        height: 65px;
    }
    .auto-style67 {
        width: 97px;
        height: 26px;
    }
    .auto-style68 {
        width: 97px;
    }
    .auto-style69 {
        height: 26px;
        text-align: center;
    }
    </style>
</asp:Content>



