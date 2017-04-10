<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Closure_WebForm.aspx.cs" Inherits="WebApplication1.Closure_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <input id="Button1" type="button" value="button" onclick="secondfunc()"/></div>
    </form>
    <script type="text/javascript">
        function outerfunction(firstnumber, secondnumber)
        {
            var result = "The Result is : "
            function innerfunction()
            {
                return result + (firstnumber + secondnumber)
            }
            return innerfunction;
        }

        function secondfunc()
        {
            var funcresult = outerfunction(10, 20);
            document.write(funcresult());
        }


    </script>
</body>
</html>
