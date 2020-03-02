<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CardDriver.ascx.cs" Inherits="FormulaOneASP_NetFW.MyComponents.CardDriver" %>
<div class="column is-one-third">
    <section class="container">
        <div class="columns features">
            <div class="column modal-button" data-target="modal-card">
                <div class="card is-shady">
                    <div class="card-image">
                        <%--<figure class="image is-5by3">--%>
                        <!-- <figure class="image is-128x128">-->
                        <asp:Image ID="imgDriver" runat="server" ImageUrl="URL" />
                        <%--</figure>--%>
                    </div>
                    <div class="card-content">
                        <div class="content">
                            <h4>
                                <asp:Label ID="lblNome" runat="server" Text="NOME"></asp:Label>
                            </h4>
                            <h5>
                                <asp:Label ID="lblTeam" runat="server" Text="TEAM"></asp:Label>
                            </h5>
                            <span class="button is-link modal-button">More</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>

