<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PasoconStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Contact information</h3>
        <address>
            Japan, Aichi-Ken<br />
            Minami-Oodaka<br />
            <abbr title="Phone">P:</abbr>
            +375445491728
        </address>

        <address>
            <strong>Support:</strong>   <a href="https://vk.com/id497249669">https://vk.com/id497249669</a><br />
            <strong>GitHub:</strong> <a href="https://github.com/FusionNotOfficial">FusionNotOfficial</a>
        </address>
    </main>
</asp:Content>
