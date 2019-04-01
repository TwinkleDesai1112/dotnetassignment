<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="webass.data" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    
   
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        Enter the number 1:<asp:TextBox ID="no1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="no1" Display="Dynamic" ErrorMessage="only enter number" 
            ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        <br /><br />
         Enter the number 2:<asp:TextBox ID="no2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="no2" Display="Dynamic" ErrorMessage="only enter number" 
            ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        <br /><br />
        <asp:Button ID="add" runat="server" Text="+" onclick="adddata" 
            Width="71px" />
        <br /><br />
        <asp:Button ID="sub" runat="server" Text="-" onclick="subdata" 
            Width="69px" />
        <br /><br />
        <asp:Button ID="div" runat="server" Text="/" onclick="divdata" 
            Width="69px" />
        <br /><br />
        <asp:Button ID="mul" runat="server" Text="*" onclick="muldata" 
            Width="68px" />
        <br /><br />
         <asp:Label ID="Label1" runat="server" Text="result_is:="></asp:Label>
   <br />
        <asp:Label ID="ans" runat="server" Text="Label"></asp:Label>
    </div>

   

    </form>
</body>
</html>
