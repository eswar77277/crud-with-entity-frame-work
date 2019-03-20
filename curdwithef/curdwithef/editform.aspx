<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editform.aspx.cs" Inherits="curdwithef.editform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                 <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Button ID="btnsave" runat="server" Text="Insert" OnClick="btnsave_Click" />
                <asp:Button ID="btnupdate" runat="server" Text="Update" Visible="false" OnClick="btnupdate_Click" />
            </div>
        </div>
    </form>
</body>
</html>
