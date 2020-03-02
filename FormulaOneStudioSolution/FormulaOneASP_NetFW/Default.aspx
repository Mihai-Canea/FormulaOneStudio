﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneASP_NetFW.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cheatsheet Concept</title>
    <link rel="icon" type="image/png" sizes="32x32" href="../images/favicon.png">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css">
    <!-- Bulma Version 0.8.x-->
    <link rel='stylesheet' href='https://unpkg.com/bulma@0.8.0/css/bulma.min.css'>
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/overlayscrollbars/1.9.1/css/OverlayScrollbars.min.css'>
    <link rel='stylesheet' href='https://kingsora.github.io/OverlayScrollbars/etc/os-theme-thin-dark.css'>
    <link rel='stylesheet' href="CSS/prism.css">
    <link rel="stylesheet" href="CSS/cheatsheet.css">
    <script src="https://kit.fontawesome.com/7dc3015a44.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <section class="hero is-primary">
            <div class="hero-body">
                <div class="columns">
                    <div class="column is-12">
                        <div class="container content">
                            <h1 class="title">Formula One Studio</h1>
                            <h3 class="subtitle">School project</h3>
                            <a href="https://github.com/BulmaTemplates/bulma-templates" target="_blank" class="button is-primary is-large">
                                <span class="icon">
                                    <i class="fab fa-github"></i>
                                </span>
                                <span>Github</span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section class="section">
            <div class="container">
                <div class="columns">
                    <div class="column is-3">
                        <aside class="is-medium menu">
                            <p class="menu-label">
                                categories
                            </p>
                            <ul class="menu-list">
                                <li class="is-right">
                                    <asp:Button ID="btnDrivers" class="button is-danger is-outlined is-fullwidth" runat="server" Text="Drivers" />
                                </li>
                                <li>
                                    <asp:Button ID="btnTeams" class="button is-danger is-outlined is-fullwidth" runat="server" Text="Teams" />
                                </li>
                            </ul>
                            <p class="menu-label">
                                More to read...
                            </p>
                            <%--<ul class="menu-list">
                                <li><span class="tag is-white is-medium">Lorem</span></li>
                                <li><span class="tag is-white is-medium">Ipsum</span></li>
                                <li><span class="tag is-white is-medium">Dolor</span></li>
                                <li><span class="tag is-white is-medium">Animi</span></li>
                                <li><span class="tag is-white is-medium">Eximi</span></li>
                                <li><span class="tag is-white is-medium">Nullius</span></li>
                                <li><span class="tag is-white is-medium">Oxipi</span></li>
                                <li><span class="tag is-white is-medium">Vultus</span></li>
                                <li><span class="tag is-white is-medium">Voluptatis</span></li>
                                <li><span class="tag is-white is-medium">Exomarphis</span></li>
                                <li><span class="tag is-white is-medium">Finimi</span></li>
                                <li><span class="tag is-white is-medium">Aenigma</span></li>
                                <li><span class="tag is-white is-medium">Arkham</span></li>
                                <li><span class="tag is-white is-medium">Blue</span></li>
                                <li><span class="tag is-white is-medium">Medium</span></li>
                            </ul>--%>
                        </aside>
                    </div>
                    <div class="column is-9">
                        <div class="box">
                            <section class="container">
                                <div class="columns features">
                                    <div class="column is-4 modal-button" data-target="modal-card">
                                        <div class="card is-shady">
                                            <div class="card-image ">
                                                <figure class="image is-5by4">
                                                    <!-- <figure class="image is-128x128">-->
                                                    <img src="https://www.formula1.com/content/dam/fom-website/drivers/C/CHALEC01_Charles_Leclerc/chalec01.png.transform/2col/image.png" alt="Placeholder image">
                                                </figure>
                                            </div>
                                            <div class="card-content">
                                                <div class="content">
                                                    <h4>Charles Leclerc</h4>
                                                    <p>Ferrari</p>
                                                    <span class="button is-link modal-button">more info....</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>

                            <section class="container">
                                <div class="columns features">
                                    <div class="column is-4 modal-button" data-target="modal-card">
                                        <div class="card is-shady">
                                            <div class="card-image ">
                                                <figure class="image is-5by4">
                                                    <!-- <figure class="image is-128x128">-->
                                                    <img src="https://www.formula1.com/content/dam/fom-website/drivers/C/CHALEC01_Charles_Leclerc/chalec01.png.transform/2col/image.png" alt="Placeholder image">
                                                </figure>
                                            </div>
                                            <div class="card-content">
                                                <div class="content">
                                                    <h4>Charles Leclerc</h4>
                                                    <p>Ferrari</p>
                                                    <span class="button is-link modal-button">more info....</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>

                            <section class="container">
                                <div class="columns features">
                                    <div class="column is-4 modal-button" data-target="modal-card">
                                        <div class="card is-shady">
                                            <div class="card-image ">
                                                <figure class="image is-5by4">
                                                    <!-- <figure class="image is-128x128">-->
                                                    <img src="https://www.formula1.com/content/dam/fom-website/drivers/C/CHALEC01_Charles_Leclerc/chalec01.png.transform/2col/image.png" alt="Placeholder image">
                                                </figure>
                                            </div>
                                            <div class="card-content">
                                                <div class="content">
                                                    <h4>Charles Leclerc</h4>
                                                    <p>Ferrari</p>
                                                    <span class="button is-link modal-button">more info....</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>
                        </div>
                        <div class="content is-medium">
                            <h3 class="title is-3">Snippets ¯\_(ツ)_/¯</h3>
                            <div class="box">
                                <h4 id="const" class="title is-3">const</h4>
                                <article class="message is-primary">
                                    <span class="icon has-text-primary">
                                        <i class="fab fa-js"></i>
                                    </span>
                                    <div class="message-body">
                                        Block-scoped. Cannot be re-assigned. Not immutable.
                                    </div>
                                </article>
                                <pre><code class="language-javascript">const test = 'test';</code></pre>
                            </div>
                            <div class="box">
                                <h4 id="let" class="title is-3">let</h4>
                                <article class="message is-primary">
                                    <span class="icon has-text-primary">
                                        <i class="fas fa-info-circle"></i>
                                    </span>
                                    <div class="message-body">
                                        Block-scoped. Can be re-assigned.
                                    </div>
                                </article>
                                <pre><code class="language-javascript">let i = 0;</code></pre>
                            </div>
                            <h3 class="title is-3">More to Come...</h3>
                            <div class="box">
                                <h4 id="lorem" class="title is-4">More to come...</h4>
                                <article class="message is-primary">
                                    <span class="icon has-text-primary">
                                        <i class="fas fa-info-circle"></i>
                                    </span>
                                    <div class="message-body">
                                        Lorem ipsum dolor sit amet, mea ne viderer veritus menandri, id scaevola gloriatur instructior sit.
                                    </div>
                                </article>
                                <pre><code class="language-javascript">let i = 0;</code></pre>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

    </form>

    <script src='https://cdnjs.cloudflare.com/ajax/libs/prism/9000.0.1/prism.js'></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/overlayscrollbars/1.9.1/js/OverlayScrollbars.min.js'></script>
</body>
</html>
