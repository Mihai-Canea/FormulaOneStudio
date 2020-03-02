<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TableDrivers.ascx.cs" Inherits="FormulaOneASP_NetFW.MyComponents.TableDrivers" %>

<asp:GridView class="table is-hoverable" ID="gridTable" runat="server" AutoGenerateColumns="false" BorderStyle="None">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Team" HeaderText="Team" />
        <asp:BoundField DataField="Country" HeaderText="Country" />
        <asp:BoundField DataField="Podlumns" HeaderText="Podlumns" />
        <asp:BoundField DataField="Points" HeaderText="Points" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="Date" />
        <asp:BoundField DataField="PlaceOfBirth" HeaderText="Place" />
    </Columns>
</asp:GridView>
