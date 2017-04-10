<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Javascript_on_String.aspx.cs" Inherits="WebApplication1.Javascript_on_String" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            height: 27px;
            width: 71px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <input id="Button1" type="button" value="button" onclick="stringoperations()"/></div>
    </form>

    <script type="text/javascript">
         
        function stringoperations()
        {
            var string1 = "Hello";
            var string2 = "World";

            alert(string1 + string2);

            alert(string1.toLowerCase() + (" ") + string2);

            var myarray = new Array(4);
            myarray[0] = 10;
            myarray[1] = 20;
            myarray[2] = 30;
            myarray[3] = 40;

            alert(myarray);

            
            for(var i =0; i < myarray.length; i++)
            {
                alert(myarray[i]);
            }

            var mystringarray = ["string1", "string2", "string3", "string1"];
            document.writeln(mystringarray.filter(
                function compare(value, index, mystringarray) 
                { 
                    if (mystringarray.indexOf(value) == index)
                        return true;
            }));

            //var localvariable = 10;
            
        }

        alert("value of a local variable" + localvariable);
    </script>
</body>
</html>
