<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.cs" Inherits="Exercise_0505.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


            <asp:GridView runat="server" id="GV1" >
                <Columns>
                    
                </Columns>
            </asp:GridView>
            
            <asp:Table runat="server" id="table1" >
            </asp:Table>
            
            <table>
                <tr>
                    <td title='Miyuki'  height="40" width='60' bgcolor='blue' align='center' >abc</td>
                </tr>
            </table>
            
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
            
            <asp:Label id="lbFormat" runat="server" ></asp:Label> 
            <asp:DropDownList id="dListFormat" runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="Format_Changed"            
                >
                <asp:ListItem  Value="decimal" Selected="true" >decimal</asp:ListItem>
                <asp:ListItem  Value="binary" >binary</asp:ListItem>
                <asp:ListItem  Value="hex" >hex</asp:ListItem>
            </asp:DropDownList>

        <asp:Label id="lbl1" runat="server" ></asp:Label>    
        <asp:Label id="lbl2" runat="server" ></asp:Label> 
            
</asp:Content>
