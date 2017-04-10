<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allControlActions_WebForm.aspx.cs" Inherits="WebApplication_controlActions.allControlActions_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 574px;
        }
    </style>
</head>
<body style="height: 577px">
    <form id="form1" runat="server">
    <div style="height: 571px">
    
        <asp:DropDownList ID="continentsDropDownList" runat="server" Height="16px" Width="197px" AutoPostBack="True" OnSelectedIndexChanged="onSelectionChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="countriesDropDownList" runat="server" Height="16px" Width="197px" AutoPostBack="true" OnSelectedIndexChanged="onCountriesSelectionChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="citiesDropDownList" runat="server" Height="16px" Width="197px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
    
        <hr />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#009900" Text="Checkbox ListItems Concepts"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxListCollection" runat="server" RepeatColumns="2" Width="201px">
            <asp:ListItem Value="0">Graduate</asp:ListItem>
            <asp:ListItem Value="1">PostGraduate</asp:ListItem>
            <asp:ListItem Value="2">Diploma</asp:ListItem>
            <asp:ListItem Value="3">Phd</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select All" />
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DeSelect All" />
        <hr />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#009900" Text="Validators"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" Text="Age" runat="server" Font-Bold="true"> </asp:Label>
        &nbsp;<asp:TextBox ID="AgeTextBox" runat="server" AutoPostBack="True" ToolTip="Enter Age"></asp:TextBox>
&nbsp;
        
        <asp:RangeValidator ID="AgeRangeValidator" runat="server" ErrorMessage="Age Should be between 1 to 100." ControlToValidate="AgeTextBox" Display="Dynamic" Font-Bold="True" ForeColor="#FF3300" MaximumValue="100" MinimumValue="1" ViewStateMode="Disabled" EnableViewState="False" Type="Integer"></asp:RangeValidator>
    
        <asp:CompareValidator ID="AgeCompareValidator" runat="server" ControlToValidate="AgeTextBox" Display="Dynamic" ErrorMessage="Age must be Number" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
    
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Ok" OnClick="OK_Click" />
    
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
&nbsp;
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
&nbsp;
        <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email Address is not valid" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
