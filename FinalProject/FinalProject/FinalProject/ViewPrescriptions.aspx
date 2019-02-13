<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="ViewPrescriptions.aspx.vb" Inherits="ViewPrescriptions" StylesheetTheme="Theme1" %>

<asp:Content ID="Body" ContentPlaceHolderID="body" runat="server">
    <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>

    <div class="Page">
        <div class="pagehead" align="Center">
        <asp:Label ID="lblPatName" runat="server" Text="Patient Name:"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="lblNameOutput" runat="server" Text="" BorderStyle="Inset" BackColor="White"></asp:Label>
        <br /><br />
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
<div class="pagemid" align="Center">
    <asp:GridView ID="gdvPrescriptions" runat="server" AutoGenerateColumns="false" CssClass="GridView" AllowSorting="true" AllowPaging="true">
        <Columns>
            <asp:BoundField DataField="Patient Name" HeaderText="Patient Name" />
            <asp:BoundField DataField="Physician Name" HeaderText="Physician Name" SortExpression="Physician Name" />
            <asp:BoundField DataField="Medication" HeaderText="Medication" SortExpression="Medication" />
            <asp:BoundField DataField="Dosage" HeaderText="Dosage" />
            <asp:BoundField DataField="Intake Method" HeaderText="Intake Method" SortExpression="Intake Method" />                 
            <asp:BoundField DataField="Refill" HeaderText="Refill(s)" />             
            <asp:BoundField DataField="REFILL_DATE" HeaderText="Last Refill Date"  />
            
            <asp:TemplateField>
                
                <ItemTemplate>
                    <table>
                        <tr>

                            <td>
                                <asp:ImageButton ID="ibtnRefill" runat="server" ImageUrl="~/Images/pill.jpg" OnCommand="ibtnRefill_Click" CommandArgument='<%#Eval("PRESCRIPTION_NO") %>' Height="40px" Width="40px" ToolTip="Fill Prescription" />
                            </td>

                           
                            <td>
                               <asp:ImageButton ID="ibtnEdit" runat="server" ImageUrl="~/Images/Edit2.jpg" Height="40px" Width="40px" OnCommand="ibtnEdit_Click" CommandArgument='<%#Eval("PRESCRIPTION_NO") %>' ToolTip="Edit Prescription Details" />
                            </td>

                            
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
        </div>
        </div>
</asp:Content>

