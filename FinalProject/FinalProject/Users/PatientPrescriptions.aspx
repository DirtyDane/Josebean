<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="PatientPrescriptions.aspx.vb" Inherits="Users_PatientPrescriptions" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="lblNameOutput" runat="server" Text="" BorderStyle="Inset" BackColor="White"></asp:Label>
    </div>
    
    <div class="pagemid">
    <asp:GridView ID="gdvPrescriptions" runat="server" AutoGenerateColumns="false" CssClass="GridView" AllowSorting="true" AllowPaging="true">
        <Columns>
           
            
            <asp:BoundField DataField="Medication" HeaderText="Medication" SortExpression="Medication" />
            <asp:BoundField DataField="Dosage" HeaderText="Dosage" SortExpression="Dosage" />
            <asp:BoundField DataField="Intake Method" HeaderText="Intake Method" SortExpression="Intake Method" />
            <asp:BoundField DataField="Physician Name" HeaderText="Physician Name" SortExpression="Physician Name" />
            
            <asp:TemplateField>
                <ItemTemplate>
                    
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>