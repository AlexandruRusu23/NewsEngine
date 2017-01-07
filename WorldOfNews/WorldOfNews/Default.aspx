<%@ Page Title="World of News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorldOfNews._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>World of News</h1>
        <p class="lead"> We're all about news for every category you could imagine. You can read the news, rate them, comment your thoughts and
        why not, create news by yourself.</p>
        <p><a href="ArticleList" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div>
        <h3>Recent Articles</h3>
        <asp:ListView ID="ArticlesListView" DataSourceID="ArticlesDataSource" GroupItemCount="4" runat="server">
        <LayoutTemplate>
          <table cellpadding="2" width="100%" runat="server" id="RecentArticlesTable">
            <tr runat="server" class="header">
            </tr>
            <tr runat="server" id="groupPlaceholder" />
          </table>
        </LayoutTemplate>
        <GroupTemplate>
          <tr runat="server" id="RecentArticlesRow">
            <td runat="server" id="itemPlaceholder" />
          </tr>
        </GroupTemplate>
        <GroupSeparatorTemplate>
          <tr runat="server">
            <td colspan="3"><hr /></td>
          </tr>
        </GroupSeparatorTemplate>
        <ItemTemplate>
          <td align="center" style="width:300px" runat="server">
            <a href='<%# "ArticleDetails.aspx?articleID=" + Eval("ArticleID") %>'>
                <asp:Image Width="140px" Height="110px" ID="ArticleImage" runat="server" ImageUrl='<%# "~/Images/" + Eval("ImagePath") %>' />
            </a>
            <br />
            <asp:HyperLink ID="ArticleLink" runat="server" Text='<%# Eval("ArticleName") %>' NavigateUrl='<%# "ArticleDetails.aspx?articleID=" + Eval("ArticleID") %>' />
            <br />
          </td>
        </ItemTemplate>
        <ItemSeparatorTemplate>
          <td class="separator" runat="server">&nbsp;</td>
        </ItemSeparatorTemplate>
      </asp:ListView>
      <br />

      <asp:SqlDataSource ID="ArticlesDataSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DefaultConnection%>"
        SelectCommand="SELECT ArticleID, ArticleName, ImagePath FROM Articles ORDER BY DatePublished DESC;">
      </asp:SqlDataSource>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Be an editor for us</h2>
            <p>
               Did you ever wonder how hard is to become an editor? With us, you're just a click away from a great career as editor for our website. Join us! 
            </p>
            <p>
                <a class="btn btn-default" href="Account/Register">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more information</h2>
            <p>
                Do you want to know who we are and what we're doing here at World of News?
            </p>
            <p>
                <a class="btn btn-default" href="About">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contact us!</h2>
            <p>
                You can easily find any answer you want from our developers.
            </p>
            <p>
                <a class="btn btn-default" href="Contact">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
