<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisteredPage.aspx.cs" Inherits="WorldOfNews.Registered.RegisteredPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Contribution</h1>
    <hr />
    <p></p>
    <br />
    <h3>Propose Article:</h3>
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
            <td><asp:Label ID="LabelAddImageFile" AssociatedControlID="ArticleImage" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ArticleImage" runat="server" />
                <asp:RequiredFieldValidator CssClass="text-danger" runat="server" ControlToValidate="ArticleImage" ErrorMessage="The image field is required." ValidationGroup="addArticleGroup"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button CssClass="btn btn-success" ID="AddArticleButton" runat="server" Text="Send Article" OnClick="AddArticleButton_Click" ValidationGroup="addArticleGroup"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <br />

</asp:Content>
