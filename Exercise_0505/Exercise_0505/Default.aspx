<%@ Page Title="Decimal" Language="C#" Inherits="Exercise_0505.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title><%: Title %></title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <h1><asp:Literal id="h1" runat="server"></asp:Literal></h1>
        <div>    
            <asp:Table runat="server" id="table1" CssClass="OutLine" >
            </asp:Table>
        </div>   
            <br>
        <div>      
            <asp:Label id="lbSelect" runat="server" ></asp:Label>    
            <asp:DropDownList id="dList" runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="Number_Changed"            
                >
                <asp:ListItem  Value=3 >3</asp:ListItem>
                <asp:ListItem  Value=4 >4</asp:ListItem>
                <asp:ListItem  Value=5 >5</asp:ListItem>
                <asp:ListItem  Value=6 >6</asp:ListItem>
                <asp:ListItem  Value=7 >7</asp:ListItem>
                <asp:ListItem  Value=8 >8</asp:ListItem>
                <asp:ListItem  Value=9 >9</asp:ListItem>
                <asp:ListItem  Value=10 Selected="true" >10</asp:ListItem>
                <asp:ListItem  Value=11 >11</asp:ListItem>
                <asp:ListItem  Value=12 >12</asp:ListItem>
                <asp:ListItem  Value=13 >13</asp:ListItem>
                <asp:ListItem  Value=14 >14</asp:ListItem>
                <asp:ListItem  Value=15 >15</asp:ListItem>
            </asp:DropDownList>
        </div>   
        <div>
            <table>
                <tr>
                    <td bgcolor="#FFFF00">Prime Number</td>
                </tr>
            </table>    
                
        </div>
        <div>
            <ul >
                <li><a runat="server" href="~/HexPage.aspx">Hex</a></li>
                <li><a runat="server" href="~/BinaryPage.aspx">Binary</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
