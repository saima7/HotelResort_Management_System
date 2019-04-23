<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="RoomHome.aspx.cs" Inherits="WebApplication3.RoomHome" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<style>
    .media {
    display: inline-block;
    position: relative;
    vertical-align: top;
}

.media__image { display: block; }

.media__body {
  background: rgba(192, 192, 192, 0.7);
  bottom: 0;
  color: white;
  font-size: 1em;
  left: 0;
  opacity: 0;
  overflow: hidden;
  padding: 3.75em 3em;
  position: absolute;
  text-align: center;
  top: 0;
  right: 0;
  -webkit-transition: 0.6s;
  transition: 0.6s;
}

.media__body:hover { opacity: 1; }

.media__body:after,
.media__body:before {
  border: 1px solid rgba(255, 255, 255, 0.7);
  bottom: 1em;
  content: '';
  left: 1em;
  opacity: 0;
  position: absolute;
  right: 1em;
  top: 1em;
  -webkit-transform: scale(1.5);
  -ms-transform: scale(1.5);
  transform: scale(1.5);
  -webkit-transition: 0.6s 0.2s;
  transition: 0.6s 0.2s;
}

.media__body:before {
  border-bottom: none;
  border-top: none;
  left: 2em;
  right: 2em;
}

.media__body:after {
  border-left: none;
  border-right: none;
  bottom: 2em;
  top: 2em;
}

.media__body:hover:after,
.media__body:hover:before {
  -webkit-transform: scale(1);
  -ms-transform: scale(1);
  transform: scale(1);
  opacity: 1;
}

.media__body h2 { margin-top: 0; }

.media__body p { margin-bottom: 1.5em; }
</style>
    <br />
    <br>
    <br />
     
        <div class="row">
            <div class="col-lg-6">
           
                    <div class="media">
                        <a href="UserRoom.aspx?id=1"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_1.jpg"/>
                        <div class="media__body"><h1>Single Standard</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserRoom.aspx?id=2"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_2.jpg"/>
                        <div class="media__body"><h1>Double Standard</h1></div></a>
                </div>
            
            </div>
        </div>
       
        <div class="row">
            <div class="col-lg-6">
               <div class="media">
                        <a href="UserRoom.aspx?id=3"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_3.jpg"/>
                        <div class="media__body"><h1>Triple Standard</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserRoom.aspx?id=4"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_4.jpg"/>
                        <div class="media__body"><h1>Single Deluxe</h1></div></a>
                </div>
            
            </div>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserRoom.aspx?id=5"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_5.jpg"/>
                        <div class="media__body"><h1>Double Deluxe</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
               <div class="media">
                        <a href="UserRoom.aspx?id=6"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_6.jpg"/>
                        <div class="media__body"><h1>Triple Deluxe</h1></div></a>
                </div>
            
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserRoom.aspx?id=7"><img alt="" class="media__image" width="600" height="300" src="pic/pic11.jpg"/>
                        <div class="media__body"><h1>Honeymoon suite</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserRoom.aspx?id=8"><img alt="" class="media__image" width="600" height="300" src="pic/bedroom_4.jpg"/>
                        <div class="media__body"><h1>Exclusive suite</h1></div></a>
                </div>
            </div>
        </div>
    

   
</asp:Content>