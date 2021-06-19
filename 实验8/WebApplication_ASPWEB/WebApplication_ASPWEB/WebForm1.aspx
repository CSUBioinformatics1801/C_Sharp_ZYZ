<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_ASPWEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>uglyweb1</title>
    <link rel="stylesheet" href="mGrid.css"/>
    <style>
    @import "StyleSheet1.css";
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border:#4169E1 1px solid">
            This is my ugly web build1</div>
        <asp:GridView ID="GridView1" CssClass="mGrid" runat="server" AllowPaging="True" AllowSorting="True" PageSize="4" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="St_ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
             <FooterStyle CssClass="GridViewFooterStyle" />
                <RowStyle CssClass="GridViewRowStyle" />  
                <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                <PagerStyle CssClass="GridViewPagerStyle" />
                <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                <HeaderStyle CssClass="GridViewHeaderStyle" />

            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="St_ID" HeaderText="St_ID" ReadOnly="True" SortExpression="St_ID" />
                <asp:BoundField DataField="St_name" HeaderText="St_name" SortExpression="St_name" />
                <asp:BoundField DataField="Subject_name" HeaderText="Subject_name" SortExpression="Subject_name" />
                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
                <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button" /> 
       
            </Columns>

            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Temp_dbConnectionString %>" SelectCommand="SELECT * FROM [Table_score]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Table_score] WHERE [St_ID] = @original_St_ID AND [St_name] = @original_St_name AND [Subject_name] = @original_Subject_name AND [Score] = @original_Score" InsertCommand="INSERT INTO [Table_score] ([St_ID], [St_name], [Subject_name], [Score]) VALUES (@St_ID, @St_name, @Subject_name, @Score)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Table_score] SET [St_name] = @St_name, [Subject_name] = @Subject_name, [Score] = @Score WHERE [St_ID] = @original_St_ID AND [St_name] = @original_St_name AND [Subject_name] = @original_Subject_name AND [Score] = @original_Score">
            <DeleteParameters>
                <asp:Parameter Name="original_St_ID" Type="Int32" />
                <asp:Parameter Name="original_St_name" Type="String" />
                <asp:Parameter Name="original_Subject_name" Type="String" />
                <asp:Parameter Name="original_Score" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="St_ID" Type="Int32" />
                <asp:Parameter Name="St_name" Type="String" />
                <asp:Parameter Name="Subject_name" Type="String" />
                <asp:Parameter Name="Score" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="St_name" Type="String" />
                <asp:Parameter Name="Subject_name" Type="String" />
                <asp:Parameter Name="Score" Type="Int32" />
                <asp:Parameter Name="original_St_ID" Type="Int32" />
                <asp:Parameter Name="original_St_name" Type="String" />
                <asp:Parameter Name="original_Subject_name" Type="String" />
                <asp:Parameter Name="original_Score" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DefaultMode="Insert" DataKeyNames="St_ID" DataSourceID="SqlDataSource1" Height="50px" Width="125px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="St_ID" HeaderText="St_ID" ReadOnly="True" SortExpression="St_ID" />
                <asp:BoundField DataField="St_name" HeaderText="St_name" SortExpression="St_name" />
                <asp:BoundField DataField="Subject_name" HeaderText="Subject_name" SortExpression="Subject_name" />
                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
                <asp:CommandField ShowInsertButton="True" ButtonType="Button" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
    </form>
</body>
</html>
