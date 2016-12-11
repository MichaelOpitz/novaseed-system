<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Project.Novaseed.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="row" style="margin-top: 60px; text-align:center">
            <h2 style="text-align: center;">Información de Contacto</h2>
        </div>
        <div class="row" style="margin-top: 30px; text-align:center">
            <asp:Image ID="imgContactoBanner" ImageUrl="~/images/banerContacto.jpg" runat="server" />
        </div>
        <div class="row" style="margin-top: 30px">
            <div class="container">
                <div class="row row-edge">
                    <div class="col-xs-12 col-sm-12 col-md-4 col-lg-4">
                        <div class="row  ">
                            <div class="container">
                                <div class="row row-edge">
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="text-align: center;">
                                        <h1><span class="glyphicon glyphicon-home"></span></h1>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <h3 style="text-align: center;">Dirección:</h3>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <p style="text-align: center;">NOVASEED. Loteo Pozo de Ripio s/n, Parque Ivian II, Casilla 894, Puerto Varas, Región de los Lagos, Chile.</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-12 col-md-4 col-lg-4">
                        <div class="row  ">
                            <div class="container">
                                <div class="row row-edge">
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="text-align: center;">                                     
                                          <h1><span class="glyphicon glyphicon-earphone"></span></h1>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <h3 style="text-align: center;">Teléfonos:</h3>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <p style="text-align: center;">+56 9 9920 0700</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-12 col-md-4 col-lg-4">
                        <div class="row  ">
                            <div class="container">
                                <div class="row row-edge">
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="text-align: center;">                                      
                                           <h1><span class="glyphicon glyphicon-envelope"></span></h1>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <h3 style="text-align: center;">E-mail:</h3>
                                    </div>
                                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                        <p style="text-align: center;"><a href="mailto:boriscontreras@novaseed.cl">boriscontreras@novaseed.cl</a></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
