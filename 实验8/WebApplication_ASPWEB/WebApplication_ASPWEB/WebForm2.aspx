<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_ASPWEB.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
body,table{
font-size:12px;
}
table{
table-layout:fixed;
empty-cells:show;
border-collapse: collapse;
margin:0 auto;
width:auto;
text-align:center;
}
td{
height:30px;
}
h1,h2,h3{
font-size:12px;
margin:0;
padding:0;

}
.table{
border:1px solid #cad9ea;
color:#666;
}
.table th {
background-repeat:repeat-x;
height:30px;
}
.table td,.table th{
border:1px solid #cad9ea;
padding:0 1em 0;
}
.table tr.alter{
background-color:#f5fafe;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0px auto; width:20%; height:auto">
            This is my ugly web build 2</div>

        <asp:Table ID="Table1" runat="server" GridLines="Horizontal" HorizontalAlign="Center" CssClass="alter">
            <asp:TableRow runat="server">
                <asp:TableCell><asp:Label ID="Label1" runat="server" Text="Name" BorderStyle="NotSet"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ForeColor="Red" ControlToValidate="TextBox_Name" ErrorMessage="RequiredFieldValidator" Text="No Empty Name" Font-Bold="True"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Age"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox_Age" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="119" MinimumValue="0" Type="Integer" ForeColor="Red" Text="0<=Age<=119" Font-Bold="True" ControlToValidate="TextBox_Age"></asp:RangeValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox_Phone" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="/^[1][3,4,5,7,8][0-9]{9}$/" ControlToValidate="TextBox_Phone" Text="Invalid Number" ForeColor="Red" Font-Bold="True" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Label4" runat="server" Text="PW"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox_PW1" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Label5" runat="server" Text="PW Confirm"></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="TextBox_PW2" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:CompareValidator ID="CompareValidator1" ControlToCompare="TextBox_PW1" ControlToValidate="TextBox_PW2" ForeColor="Red" runat="server" ErrorMessage="CompareValidator" Font-Bold="True" Text="Discrepant PW!"></asp:CompareValidator></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <div style="text-align:center; height:auto"><asp:Button ID="Button1" runat="server" Text="Submit" /></div>
        
        
    </form>
</body>
</html>
