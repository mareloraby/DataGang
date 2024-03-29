﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="DataGang.Homepage" %>
 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">


<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Home</title>
    <!-- Favicon-->
    <!-- <link rel="icon" type="image/x-icon" href="assets/favicon.ico" /> -->
    <!-- Font Awesome icons (free version)-->
    <script src="https://use.fontawesome.com/releases/v5.15.3/js/all.js" crossorigin="anonymous"></script>
    <!-- Google fonts-->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href="css/styles.css" rel="stylesheet" />
</head>


<body id="page-top">
<form id="Form1" method="post" runat="server" EncType="multipart/form-data" action="Homepage.aspx">




    <!-- Navigation-->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand" href="#page-top"><img src="assets/img/BugQuestyellow.png" alt="..." /></a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                Menu
                <i class="fas fa-bars ms-1"></i>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav text-uppercase ms-auto py-4 py-lg-0">

                    <li class="nav-item"><a class="nav-link" href="#about">Steps</a></li>

                    <li class="nav-item"><a class="nav-link" href="#contact">Contact</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Masthead-->

    <header class="masthead">
        <div class="container">
            <div class="masthead-subheading">Welcome To Bug Quest!</div>
            <div class="masthead-heading text-uppercase">Save a plant today!</div>




              

            <br/>
<%--            <a class="btn btn-primary btn-xl text-uppercase" href="">Take A Photo</a>--%>
<%--            <input class="btn btn-primary btn-xl text-uppercase" type="file" id="imageFile" capture="user" accept="image/*">--%>



        </div>
    </header>

  
    <!-- About-->
    <section class="page-section" id="about">
        <div class="container">
            <div class="text-center">
                <h2 class="section-heading text-uppercase"  ><a class="nav-link" style="color:#212529" href="#t1">Steps</a></h2>
                <h3 class="section-subheading text-muted">It's so simple!</h3>
            </div>
            <ul class="timeline" id ="t1">
          
              
                <li>
                    <div class="timeline-image"><img class="rounded-circle img-fluid" src="assets/img/about/0.jpg" alt="..." /></div>
                    <div class="timeline-panel">
                        <div class="timeline-heading">
                            <h4 style="color:#ffc800" class="text-uppercase"></br></h4>


                        </div>
                        <div class="timeline-body">

                            
            <asp:DropDownList ID="DropDownList1" class="btn btn-primary btn-xl text-uppercase" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" BackColor="White" ForeColor="Black">
              <asp:ListItem selected hidden>1. Plant type</asp:ListItem>
                <asp:ListItem>Potato</asp:ListItem>
                <asp:ListItem>Apple</asp:ListItem>
                <asp:ListItem>Cabbage</asp:ListItem>
                <asp:ListItem>Tomato</asp:ListItem>
                <asp:ListItem>Grapes</asp:ListItem>
                
            </asp:DropDownList>


                </div>
                    </div>
                </li>

                <li class="timeline-inverted">
                    <div class="timeline-image"><img class="rounded-circle img-fluid" src="assets/img/about/1.jpg" alt="..." /></div>
                    <div class="timeline-panel">
                        <div class="timeline-heading">
                            <h4><br/> </h4>

                        </div>
                        <label for="oFile" class="btn btn-primary btn-xl text-uppercase"  > 2. Take or Upload your image </label>
                        <div class="timeline-body">

            <input type="file" id="oFile" name="oFile" accept=".jpg, .jpeg, .png" hidden="hidden" runat="server"/>


                        </div>
                    </div>
                </li>

                <li>
                    <div class="timeline-image"><img class="rounded-circle img-fluid" src="assets/img/about/2.jpg" alt="..." /></div>
                    <div class="timeline-panel">
                        <div class="timeline-heading">
                            <h4></br></h4>

                        </div>
                        <div class="timeline-body">
                             <label for="btnUpload" class="btn btn-primary btn-xl text-uppercase"  > 3. Get Diagnosis! </label>
                          <asp:button id="btnUpload" type="submit" text="3. Get Diagnosis!" hidden="hidden" runat="server" class="btn btn-primary btn-xl text-uppercase" ></asp:button>
                            </br>
                            <asp:Label ID="Label1" runat="server" style="  font-weight: bold;"></asp:Label>
                            <br/>

                            <asp:Label ID="Labelsummary" runat="server" Text="" style="overflow-wrap: break-word;"></asp:Label>


                        </div>
                    </div>
                </li>


                   <li class="timeline-inverted">
                    <div class="timeline-image"><img class="rounded-circle img-fluid" src="assets/img/about/3.jpg" alt="..." /></div>
                    <div class="timeline-panel">
                        <div class="timeline-heading">
                           <label for="btnTreat" class="btn btn-primary btn-xl text-uppercase"  > 4. Recommended Treatements </label>
                            <asp:button ID="btnTreat" type="submit"  Text=" 4. Recommended Treatements" hidden="hidden"  runat="server" OnClick="btnTreat_Click"  ></asp:button>
                            <br/>
                            <asp:Label ID="lbltreat" runat="server" Text=""></asp:Label>


                        </div>
                        <div class="timeline-body"></div>
                    </div>
                </li>


                <li class="timeline-inverted">
                    <div class="timeline-image">
                        <h4>
                            <!-- Be Part
                            <br />
                            Of Our
                            <br />
                            Story! -->
                            <br />
                            Done!
                        </h4>
                    </div>
                </li>
            </ul>
        </div>
    </section>

    <!-- Contact-->
    <section class="page-section" id="contact">
        <div class="container">
            <div class="text-center">
                <h2 class="section-heading text-uppercase">Contact An Expert</h2>
                <h3 class="section-subheading text-muted">For further assistance, contact one of out experts with your issue.</h3>
            </div>
<%--            <form id="contactForm" method="post" runat="server" EncType="multipart/form-data" action="Homepage.aspx">--%>
                <div class="row align-items-stretch mb-5">
                    <div class="col-md-6">
                        <div class="form-group">
                            <input class="form-control" id="name" type="text" placeholder="Your Name *" />
                            <p class="help-block text-danger"></p>
                        </div>
                        <div class="form-group">
                            <input class="form-control" id="email" type="email" placeholder="Your Email *"  />
                            <p class="help-block text-danger"></p>
                        </div>
                        <div class="form-group mb-md-0">
                            <input class="form-control" id="phone" type="tel" placeholder="Your Phone *" />
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group form-group-textarea mb-md-0">
                            <textarea class="form-control" id="message" placeholder="Your Message *" ></textarea>
                            <p class="help-block text-danger"></p>
                            <div  style="color:white">
                                 <input id="in" type="file" runat="server" name="oFile" accept="Image/*" /> 
<%--                                 <asp:button id="btnUpload"  type="submit" text="Upload" runat="server" visible="false"></asp:button>--%>
                                 <asp:Panel ID="frmConfirmation" Visible="False" Runat="server">
                                 <asp:Label id="lblUploadResult" Runat="server" ForeColor="White"></asp:Label>
                                 </asp:Panel>   
                                <br/>
                             </div>
                          
                        </div>
                    </div>
                </div>
                <br/>
                <div class="text-center">
                    <div id="success"></div>
                    
                    <asp:Panel ID="Panel1" Visible="False" Runat="server">
                      </asp:Panel>         
                    <button class="btn btn-primary btn-xl text-uppercase" id="sendMessageButton" type="submit">Send Message</button>
                  
                </div>
        </div>
    </section>
    <!-- Footer-->
    <footer class="footer py-4">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-4 text-lg-start">
                    Copyright &copy; Data Gang
                    <!-- This script automatically adds the current year to your website footer-->
                    <!-- (credit: https://updateyourfooter.com/)-->
                    <script>
                        document.write(new Date().getFullYear());
                    </script>
                </div>
                <!-- <div class="col-lg-4 my-3 my-lg-0">
                    <a class="btn btn-dark btn-social mx-2" href="#!"><i class="fab fa-twitter"></i></a>
                    <a class="btn btn-dark btn-social mx-2" href="#!"><i class="fab fa-facebook-f"></i></a>
                    <a class="btn btn-dark btn-social mx-2" href="#!"><i class="fab fa-linkedin-in"></i></a>
                </div> -->
                <div class="col-lg-4 text-lg-end">
                    <a class="link-dark text-decoration-none me-3" href="#!">Privacy Policy</a>
                    <a class="link-dark text-decoration-none" href="#!">Terms of Use</a>
                </div>
            </div>
        </div>
    </footer>


    <!-- Bootstrap core JS-->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Core theme JS-->
    <script src="js/scripts.js"></script>
      </form>
</body>
</html>
