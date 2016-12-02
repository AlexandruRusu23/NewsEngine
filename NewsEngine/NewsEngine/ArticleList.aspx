<%@ Page Title="Articles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="NewsEngine.ArticleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="articleList" runat="server" DataKeyNames="ArticleID" GroupItemCount="4" ItemType="NewsEngine.Models.Article" SelectMethod="GetArticles">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>

                <EmptyDataTemplate>

                    <td></td>

                </EmptyDataTemplate>

                <GroupTemplate>
                    <tr id="itemPlaceHolderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>

                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ArticleDetails.aspx?articleID=<%#: Item.ArticleID %>">
                                        <img src="/Images/Thumbs/<%#: Item.ImagePath %>" width ="100" height="75" style="border:solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ArticleDetails.aspx?articleID=<%#:Item.ArticleID%>">
                                        <span>
                                            <%#:Item.ArticleName%>
                                        </span>
                                    </a>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>

                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
