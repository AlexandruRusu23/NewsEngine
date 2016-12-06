<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="NewsEngine.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Administration</h1>
    <hr />

    <h3>Add Category:</h3>
    <table>

    </table>
    <p></p>
    <p></p>

    <h3>Remove Category:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveCategory" runat="server" ItemType="NewsEngine.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName" DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="RemoveCategoryButton" runat="server" Text="Remove Category" OnClick="RemoveCategoryButton_Click" CausesValidation="false" />

    <h3>Add Article:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddCategory" runat="server" 
                    ItemType="NewsEngine.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Article name required." ControlToValidate="AddArticleName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Description required." ControlToValidate="AddArticleDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ArticleImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="ArticleImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddArticleButton" runat="server" Text="Add Article" OnClick="AddArticleButton_Click" CausesValidation="true" />
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Article:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelRemoveArticle" runat="server">Article</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveArticle" runat="server" ItemType="NewsEngine.Models.Article" SelectMethod="GetArticles" AppendDataBoundItems="true"
                    DataTextField="ArticleName" DataValueField="ArticleID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveArticleButton" runat="server" Text="Remove Article" OnClick="RemoveArticleButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
    
</asp:Content>
