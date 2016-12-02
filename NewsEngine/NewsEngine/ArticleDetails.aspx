<%@ Page Title="Article Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="NewsEngine.ArticleDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID ="articleDetail" runat="server" ItemType="NewsEngine.Models.Article" SelectMethod="GetArticle" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#: Item.ArticleName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="Images/Thumbs/<%#: Item.ImagePath %>" style="border:solid" height="300px" alt="<%#: Item.ArticleName %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align:left">
                        <b>Description:</b><br /><%#: Item.Description %>
                        <br />
                        <span><b>Article number:</b>&nbsp;<%#: Item.ArticleID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
