<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipeDropdown.aspx.cs" Inherits="RedRiverTechnicalWebApp.RecipeDropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Select what drink you want from the list below.</p>
        </div>
        <div>
            <asp:DropDownList ID="RecipeDropdownList" runat="server">
                <asp:ListItem Value="LemonTea">Lemon Tea</asp:ListItem>
                <asp:ListItem Value="Coffee">Coffee</asp:ListItem>
                <asp:ListItem Value="Chocolate">Chocolate</asp:ListItem>
            </asp:DropDownList>
        </div>

        <br/>
        <asp:Button ID="submit1" runat="server" OnClick="SubmitRecipe" Text="Submit" />
        
        <br />
        <br />
        <asp:Label ID="L1" runat="server" EnableViewState="False"></asp:Label>  
    </form>
</body>
</html>
