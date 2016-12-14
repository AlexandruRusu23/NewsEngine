<%@ Page Title="World of News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorldOfNews._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>World of News</h1>
        <p class="lead"> We're all about news for every category you could imagine. You can read the news, rate them, comment your thoughts and
        why not, create news by yourself.</p>
        <p><a href="Articles" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
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
