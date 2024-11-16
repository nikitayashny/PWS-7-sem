<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsP.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simplex Web Service Client</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Two Numbers</h2>
            <asp:TextBox ID="txtAddX" runat="server" placeholder="Enter first number"></asp:TextBox>
            <asp:TextBox ID="txtAddY" runat="server" placeholder="Enter second number"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <div id="addResult" runat="server"></div>

            <h2>Concatenate String and Double</h2>
            <asp:TextBox ID="txtConcatString" runat="server" placeholder="Enter a string"></asp:TextBox>
            <asp:TextBox ID="txtConcatDouble" runat="server" placeholder="Enter a double"></asp:TextBox>
            <asp:Button ID="btnConcat" runat="server" Text="Concat" OnClick="btnConcat_Click" />
            <div id="concatResult" runat="server"></div>

            <h2>Sum Two Objects</h2>
            <asp:TextBox ID="txtSumString1" runat="server" placeholder="Enter first string"></asp:TextBox>
            <asp:TextBox ID="txtSumInt1" runat="server" placeholder="Enter first integer"></asp:TextBox>
            <asp:TextBox ID="txtSumFloat1" runat="server" placeholder="Enter first float"></asp:TextBox>
            <asp:TextBox ID="txtSumString2" runat="server" placeholder="Enter second string"></asp:TextBox>
            <asp:TextBox ID="txtSumInt2" runat="server" placeholder="Enter second integer"></asp:TextBox>
            <asp:TextBox ID="txtSumFloat2" runat="server" placeholder="Enter second float"></asp:TextBox>
            <asp:Button ID="btnSum" runat="server" Text="Sum" OnClick="btnSum_Click" />
            <div id="sumResult" runat="server"></div>
        </div>
    </form>
</body>
</html>