<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="ViewPrescriptions.aspx.vb" Inherits="ViewPrescriptions" StylesheetTheme="Theme1" %>

<asp:Content ID="Body" ContentPlaceHolderID="body" runat="server">
    <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>

    <div class="Page">
        <asp:Label ID="lblPatName" runat="server" Text="Patient Name:"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="lblNameOutput" runat="server" Text="" BorderStyle="Inset" BackColor="White"></asp:Label>
        <br /><br />
    

    <asp:GridView ID="gdvPrescriptions" runat="server" AutoGenerateColumns="false" CssClass="GridView" AllowSorting="true" AllowPaging="true">
        <Columns>
            <asp:BoundField DataField="Patient Name" HeaderText="Patient Name" SortExpression="Patient Name" />
            <asp:BoundField DataField="Physician Name" HeaderText="Physician Name" SortExpression="Physician Name" />
            <asp:BoundField DataField="Medication" HeaderText="Medication" SortExpression="Medication" />
            <asp:BoundField DataField="Dosage" HeaderText="Dosage" SortExpression="Dosage" />
            <asp:BoundField DataField="Intake Method" HeaderText="Intake Method" SortExpression="Intake Method" />
            
            <asp:TemplateField>
                <ItemTemplate>
                    <table>
                        <tr>

                            <td>
                                <asp:ImageButton ID="ibtnRefill" runat="server" ImageUrl="~/Images/pill.jpg" Height="40px" Width="40px" ToolTip="Fill Prescription" />
                            </td>

                            <td>
                               <asp:ImageButton ID="ibtnAdd" runat="server" ImageUrl="~/Images/add.jpg" Height="42px" Width="42px" ToolTip="Add Refills" />
                            </td>

                            <td>
                               <asp:ImageButton ID="ibtnEdit" runat="server" ImageUrl="~/Images/Edit2.jpg" Height="40px" Width="40px" ToolTip="Edit Prescription Details" />
                            </td>

                            
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>

