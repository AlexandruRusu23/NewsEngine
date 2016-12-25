<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditorPage.aspx.cs" Inherits="WorldOfNews.Editor.EditorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Administration</h1>
    <hr />
    <p></p>
    <h3>Add Category:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddOnlyCategory" runat="server">Category Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddCategoryName" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddCategoryButton" runat="server" Text="Add Category" OnClick="AddCategoryButton_Click"  CausesValidation="true"/>
    <p></p>
    <h3>Remove Category:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveCategory" runat="server" ItemType="WorldOfNews.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName" DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="RemoveCategoryButton" runat="server" Text="Remove Category" OnClick="RemoveCategoryButton_Click" CausesValidation="false" />
    <p></p>
    <h3>Add Article:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddCategory" runat="server" 
                    ItemType="WorldOfNews.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ArticleImage" runat="server" />
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddArticleButton" runat="server" Text="Add Article" OnClick="AddArticleButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Article:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveArticle" runat="server">Article:</asp:Label></td>
            <td><asp:DropDownList ID="DropDownRemoveArticle" runat="server" ItemType="WorldOfNews.Models.Article" 
                    SelectMethod="GetArticles" AppendDataBoundItems="true" 
                    DataTextField="ArticleName" DataValueField="ArticleID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveArticleButton" runat="server" Text="Remove Article" OnClick="RemoveArticleButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>

</asp:Content>
