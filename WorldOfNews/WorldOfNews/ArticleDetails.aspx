<%@ Page Title="World of News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="WorldOfNews.ArticleDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="articleDetail" runat="server" ItemType="WorldOfNews.Models.Article" SelectMethod ="GetArticle" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ArticleName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.ArticleName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Date:</b><br /><%#:Item.DatePublished %><br />
                        <b>Description:</b><br /><%#:Item.Description %><br /><span><b>Article Number:</b>&nbsp;<%#:Item.ArticleID %></span><br /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>

    <div>
        <br />  
            <h3>Add Comment:</h3>
           
            <table class="table">
                <tr>
                    <td><asp:Label runat="server">Article Number:</asp:Label>
                        <asp:DropDownList ID="DropDownAddComment" runat="server" 
                            ItemType="WorldOfNews.Models.Article"
                            SelectMethod="GetArticle" DataTextField="ArticleID" 
                            DataValueField="ArticleID">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="LabelAddAuthor" AssociatedControlID="AddCommentAuthor" runat="server">Nickname:</asp:Label>
                        <asp:TextBox ID="AddCommentAuthor" runat="server"></asp:TextBox></td>
                    <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="AddCommentAuthor" ErrorMessage="The nickname field is required." runat="server"></asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelAddCommentDescription" AssociatedControlID="AddComment" runat="server"></asp:Label>
                        <asp:TextBox Width="500px" Height="150px" ID="AddComment" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                    <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="AddComment" ErrorMessage="The description field is required." runat="server"></asp:RequiredFieldValidator>
                </tr>
            </table>
            <p></p>
            <p></p>
            
            <asp:Button CssClass="btn btn-primary" ID="AddCommentButton" runat="server" Text="Add Comment" OnClick="AddCommentButton_Click"/>

            <asp:Label ID="LabelAddStatus" runat="server"></asp:Label>    
            
            <br />
            <br />
            
            <hgroup>
                <h2>Comments Section</h2>
            </hgroup>
            <p></p>


            <asp:ListView ID="commentList" runat="server" 
                DataKeyNames="ArticleID" GroupItemCount="1"
                ItemType="WorldOfNews.Models.Comment" SelectMethod="GetComments">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>There is no comment for this article.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <b><%#: Item.Author %></b>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span>
                                         <%#:Item.Description%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <ItemSeparatorTemplate>  <hr />  </ItemSeparatorTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
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

</asp:Content>
