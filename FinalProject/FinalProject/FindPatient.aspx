<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="FindPatient.aspx.vb" Inherits="FindPatient" StylesheetTheme="Theme1" %>



<%--<asp:Content ID="LeftSideBar"></asp:Content>--%>

<asp:Content ID="Body1" ContentPlaceHolderID="Body" runat="server">
    <div class="Page">

    
    <div class="pagehead" align="Center">
        <asp:ValidationSummary ID="valSummary" runat="server" HeaderText="The following errors occurred:" ForeColor="Red" BackColor="WhiteSmoke" />
        
        
        <table>

            <tr>
                <td>
                    <asp:Label ID="lblLname" runat="server" Text="Patient Last Name: "></asp:Label>&nbsp;&nbsp;
                    <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqLname" runat="server" ErrorMessage="Please Enter a Patient's Last Name" ControlToValidate="txtLname" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>

            </tr>
             
                    
        </table>
        <table>

            <tr>

                <td>
                    
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
               
                <td></td>
                <td>
                     <asp:Button ID="btnSearch" runat="server" Text="Search" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear Results" />
                </td>

                
            </tr>
             
                    
        </table>
       
    </div>

    <div class="pagemid">
        <asp:GridView ID="gdvPatients" runat="server" AutoGenerateColumns="false" CssClass="GridView" align="Center" AllowPaging="true" AllowSorting="true" PageSize="5">
            <PagerSettings  FirstPageText="Go to First Page" LastPageText="Go to Last Page" Position="Top" Mode="NumericFirstLast" />
            <Columns>
               
                <asp:CheckBoxField />
                <asp:BoundField DataField="Last Name" HeaderText="Last Name" SortExpression="Last Name" />
                <asp:BoundField DataField="First Name" HeaderText="First Name" SortExpression="First Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="Zip" HeaderText="Zip" />
                <asp:HyperLinkField DataNavigateUrlFields="PATIENT_ID" DataNavigateUrlFormatString="~\ViewPrescriptions.aspx?ID={0}" Text="View Prescriptions" Target="_parent" />

                <asp:TemplateField>
                    <ItemTemplate>
                                                
                        <table>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ibtnAdd" runat="server" ImageUrl="~/Images/add.jpg" Height="42px" Width="42px" ToolTip="Add Prescription for Selected Patient" />
                                </td>

                                <td>
                                    <asp:ImageButton ID="ibtnEdit" runat="server" ImageUrl="~/Images/Edit2.jpg" Height="40px" Width="40px" ToolTip="Edit Patient's Personal Information" />
                                </td>

                            </tr>
                        </table>
                        
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        </div>
    </div>
</asp:content>

<%--<asp:Content ID="LeftSideBar" ContentPlaceHolderID="LeftSideBar" runat="server">
    <div class="pageright">
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnAddPrescription" runat="server" Text="Add Prescription" />
                </td>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnViewPrescriptions" runat="server" Text="View Prescriptions" />
                </td>
            </tr>
                <tr>
                <td>
                    &nbsp;
                </td>
                </tr>
                <tr>
                <td>
                    &nbsp;
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Button ID="btnEditPersonalInfo" runat="server" Text="Edit Personal Info" />
                </td>
            </tr>
        </table>
    </div>
</div>

    </asp:Content>--%>