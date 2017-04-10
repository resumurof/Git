<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ValidateForm()
        {
            Alert("Hello")
            var ret = true;
            if (document.getElementById("txtFirstName").value == "")
            {
                document.getElementById("lblFirstName").innerText = "FirstName is Required";
                ret = false;
            }
            //else
            //{
            //    document.getElementById("lblFirstName").innerText = txtFirstName.value;
            //    ret = true;
            //}
                
            if (document.getElementById("txtLastName").value == "") {
                document.getElementById("lblLastName").innerText = "LastName is Required";
                ret = false;
            }
            //else {
            //    document.getElementById("lblLastName").innerText = txtLastName.value;
            //    ret = true;
            //}

            if (document.getElementById("txtEmail").value == "") {
                document.getElementById("lblEmail").innerText = "Email is Required";
                ret = false;
            }
            //else {
            //    document.getElementById("lblEmail").innerText = txtEmail.value;
            //    ret = true;
            //}
        }
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <centre>
            <div>

                <table style="border:1px solid black; font-family:Arial">
                <tr>
                    <td>
                        <b>First Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" AutoPostBack="True"></asp:TextBox>
                        <asp:Label ID="lblFirstName" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Last Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" AutoPostBack="True"></asp:TextBox>
                        <asp:Label ID="lblLastName" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" AutoPostBack="True"></asp:TextBox>
                        <asp:Label ID="lblEmail" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  OnClientClick="return ValidateForm()" OnClick="btnSubmit_Click"/>
                    </td>
                </tr>
            </table>
        </div>
   </centre>
    </form>
</body>
</html>
