<%@ Page Title="Editor Panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditorPage.aspx.cs" Inherits="WorldOfNews.Editor.EditorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Administration</h1>
    <hr />
    <p></p>
    <br />
    <h3>Add Category:</h3>
    <table class="table">
        <tr>
            <td><asp:Label ID="LabelAddOnlyCategory" AssociatedControlID="AddCategoryName" runat="server">Category Name:</asp:Label>
                <asp:TextBox ID="AddCategoryName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="AddCategoryName" ErrorMessage="The category name field is required." ValidationGroup="addCategoryGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-success" ID="AddCategoryButton" runat="server" Text="Add Category" OnClick="AddCategoryButton_Click" ValidationGroup="addCategoryGroup"/>
    <asp:Label ID="LabelAddCategoryStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />
    <h3>Remove Category:</h3>
    <table class="table">
        <tr>
            <td><asp:Label ID="LabelRemoveCategory" runat="server">Category:</asp:Label>
                <asp:DropDownList ID="DropDownRemoveCategory" runat="server" ItemType="WorldOfNews.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName" DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-danger" ID="RemoveCategoryButton" runat="server" Text="Remove Category" OnClick="RemoveCategoryButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemoveCategoryStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />
    <h3>Add Article:</h3>
    <table class="table">
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
            <td><asp:Label ID="LabelAddName" AssociatedControlID="AddArticleName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="AddArticleName" runat="server" ErrorMessage="The field name is required." ValidationGroup="addArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" AssociatedControlID="AddArticleDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddArticleDescription" Width="350px" Height="150px" TextMode="MultiLine" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="AddArticleDescription" ErrorMessage="The description field is required." ValidationGroup="addArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDate" runat="server">Date:</asp:Label></td>
            <td>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Calendar ID="AddArticleDate" SelectedMode="Day" ShowGridLines="true" OnSelectionChanged="AddArticleDate_SelectionChanged" runat="server">
                            <SelectedDayStyle BackColor="Yellow"
                                   ForeColor="Red">
                            </SelectedDayStyle>
                        </asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" AssociatedControlID="ArticleImage" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ArticleImage" runat="server" />
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="ArticleImage" ErrorMessage="The image field is required." ValidationGroup="addArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-success" ID="AddArticleButton" runat="server" Text="Add Article" OnClick="AddArticleButton_Click" ValidationGroup="addArticleGroup"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />
    <h3>Remove Article:</h3>
    <table class="table">
        <tr>
            <td><asp:Label ID="LabelRemoveArticle" runat="server">Article:</asp:Label>
                <asp:DropDownList ID="DropDownRemoveArticle" runat="server" ItemType="WorldOfNews.Models.Article" 
                    SelectMethod="GetArticles" AppendDataBoundItems="true" 
                    DataTextField="ArticleName" DataValueField="ArticleID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button CssClass="btn btn-danger" ID="RemoveArticleButton" runat="server" Text="Remove Article" OnClick="RemoveArticleButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />
    <h3>Add Extern Article:</h3>
    <table class="table">
        <tr>
            <td><asp:Label ID="LabelAddExternArticle" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddExternCategory" runat="server" 
                    ItemType="WorldOfNews.Models.Category"
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddExterName" AssociatedControlID="AddExternArticleName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddExternArticleName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="AddExternArticleName" runat="server" ErrorMessage="The field name is required." ValidationGroup="addExternArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddExternLink" AssociatedControlID="AddExternArticleLink" runat="server">Link:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddExternArticleLink" Width="350px" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="AddExternArticleLink" ErrorMessage="The link field is required." ValidationGroup="addExternArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddExternDate" runat="server">Date:</asp:Label></td>
            <td>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Calendar ID="AddExternArticleDate" SelectedMode="Day" ShowGridLines="true" OnSelectionChanged="AddExternArticleDate_SelectionChanged" runat="server">
                            <SelectedDayStyle BackColor="Yellow"
                                   ForeColor="Red">
                            </SelectedDayStyle>
                        </asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddExternImage" AssociatedControlID="ExternArticleImage" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ExternArticleImage" runat="server" />
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="ExternArticleImage" ErrorMessage="The image field is required." ValidationGroup="addExternArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-success" ID="AddExternArticleButton" runat="server" Text="Add Extern Article" OnClick="AddExternArticleButton_Click" ValidationGroup="addExternArticleGroup"/>
    <asp:Label ID="LabelAddExternStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />
    <h3>Remove Extern Article:</h3>
    <table class="table">
        <tr>
            <td><asp:Label ID="LabelRemoveExternArticle" runat="server">Extern Article:</asp:Label>
                <asp:DropDownList ID="DropDownRemoveExternArticle" runat="server" ItemType="WorldOfNews.Models.ExternArticle" 
                    SelectMethod="GetExternArticles" AppendDataBoundItems="true" 
                    DataTextField="ArticleName" DataValueField="ArticleID" >
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-danger" ID="Button2" runat="server" Text="Remove Article" OnClick="RemoveExternArticleButton_Click" CausesValidation="false"/>
    <asp:Label ID="LabelRemoveExternStatus" runat="server" Text=""></asp:Label>

</asp:Content>
