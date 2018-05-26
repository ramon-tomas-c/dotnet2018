<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="beerList" ItemPlaceholderID="itemPlaceHolder" runat="server" ItemType="Beer">            
            <ItemTemplate>
                <div class="col-xs-4 col-md-4">
                    <a href="#" class="thumbnail wrapper">
                        <img src="<%#:Item.ImageUrl%>" alt="...">
                        <div class="footer">
                            <span class="label pull-left">&nbsp;<%#:Item.Name%></span>
                            <span class="label pull-right"><i class="fas fa-thumbtack"></i>&nbsp;<%#:Item.Country%></span>
                        </div>
                    </a>            
                </div>
            </ItemTemplate>
        </asp:ListView>
    <style>
    .wrapper {
        width: 300px;
        height: 340px;
        overflow: hidden;
        background-size: cover;
    }

    .footer {
        background-color: rgba(0,0,0, 0.8);
        height: 40px;
        color: white;
        bottom: 0;
    }

    .footer .label {
        font-size: 15px;
        margin-top: 7px;
        font-family: 'Pacifico', cursive;
        font-weight:100;
    }
</style>
</asp:Content>


