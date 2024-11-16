<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WCF Client</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>WCF Service Client</h2>

            <h3>Add Two Numbers</h3>
            <label for="num1">Number 1:</label>
            <asp:TextBox ID="num1" runat="server"></asp:TextBox><br />
            <label for="num2">Number 2:</label>
            <asp:TextBox ID="num2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" /><br />
            <asp:Label ID="lblResultAdd" runat="server" Text=""></asp:Label>

            <h3>Concatenate String and Number</h3>
            <label for="strInput">String:</label>
            <asp:TextBox ID="strInput" runat="server"></asp:TextBox><br />
            <label for="numInput">Number:</label>
            <asp:TextBox ID="numInput" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnConcat" runat="server" Text="Concat" OnClick="btnConcat_Click" /><br />
            <asp:Label ID="lblResultConcat" runat="server" Text=""></asp:Label>

            <h3>Sum Objects</h3>
            <label for="strA1">String A1:</label>
            <asp:TextBox ID="strA1" runat="server"></asp:TextBox><br />
            <label for="numA1">Number A1:</label>
            <asp:TextBox ID="numA1" runat="server"></asp:TextBox><br />
            <label for="floatA1">Float A1:</label>
            <asp:TextBox ID="floatA1" runat="server"></asp:TextBox><br />
            <label for="strA2">String A2:</label>
            <asp:TextBox ID="strA2" runat="server"></asp:TextBox><br />
            <label for="numA2">Number A2:</label>
            <asp:TextBox ID="numA2" runat="server"></asp:TextBox><br />
            <label for="floatA2">Float A2:</label>
            <asp:TextBox ID="floatA2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSum" runat="server" Text="Sum" OnClick="btnSum_Click" /><br />
            <asp:Label ID="lblResultSum" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>