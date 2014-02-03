<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_1_hur_manga_versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/app.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server">Hur många versaler?</asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="SendButton" runat="server" Text="Skicka" OnClick="SendButton_Click" />
            </p>
            <p>
                <asp:Button ID="ClearButton" runat="server" Text="Rensa" Visible="false" />
            </p>
            <p>
                <asp:Label ID="UppercaseCount" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
