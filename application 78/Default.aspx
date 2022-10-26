<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="application_78._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
   <div style="font-size:x-large" align="center">Student Information System<br />
    </div>
    <table class="nav-justified">
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">Student ID</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">Student Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">Address</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="127px">
                    <asp:ListItem>Dhaka</asp:ListItem>
                    <asp:ListItem>Natore</asp:ListItem>
                    <asp:ListItem>Pabna</asp:ListItem>
                    <asp:ListItem>Rajshahi</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">Age</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">Contact</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 233px">&nbsp;</td>
            <td style="width: 326px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#666699" ForeColor="White" OnClick="Button1_Click" Text="Insert" />
&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="Blue" ForeColor="White" OnClick="Button2_Click" Text="Update" />
&nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="Black" ForeColor="White" OnClick="Button3_Click" Text="Delete" />
&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="White" ForeColor="#FF0066" OnClick="Button4_Click" Text="Search" />
&nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#666699" ForeColor="#99FFCC" OnClick="Button5_Click" Text="Find" Width="47px" />
                <br />
                <asp:GridView ID="GridView1" runat="server" style="margin-right: 277px" Width="698px">
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
</div>
</asp:Content>
