<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="FoodHome.aspx.cs" Inherits="WebApplication3.FoodHome" %>

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
                        <a href="UserFood.aspx?id=1"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomePizza.jpg"/>
                        <div class="media__body"><h1>Pizza</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserFood.aspx?id=2"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomePasta.jpg"/>
                        <div class="media__body"><h1>Pasta</h1></div></a>
                </div>
            
            </div>
        </div>
       
        <div class="row">
            <div class="col-lg-6">
               <div class="media">
                        <a href="UserFood.aspx?id=3"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeBurger.jpg"/>
                        <div class="media__body"><h1>Burger</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserFood.aspx?id=4"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeSandwitch.jpg"/>
                        <div class="media__body"><h1>Sandwich</h1></div></a>
                </div>
            
            </div>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=5"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeSteak.jpg"/>
                        <div class="media__body"><h1>Steak</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
               <div class="media">
                        <a href="UserFood.aspx?id=6"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeBeef.jpg"/>
                        <div class="media__body"><h1>Beef Items</h1></div></a>
                </div>
            
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=7"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeDuck.jpg"/>
                        <div class="media__body"><h1>Duck</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserFood.aspx?id=8"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeChiken.jpg"/>
                        <div class="media__body"><h1>Chicken</h1></div></a>
                </div>
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=9"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeRice.jpg"/>
                        <div class="media__body"><h1>Rice and Noodles</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserFood.aspx?id=10"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeBeef.jpg"/>
                        <div class="media__body"><h1>Mutton</h1></div></a>
                </div>
            
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=11"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeSea.jpg"/>
                        <div class="media__body"><h1>Sea Food</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
                <div class="media">
                        <a href="UserFood.aspx?id=12"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeSoup.jpg"/>
                        <div class="media__body"><h1>Soup</h1></div></a>
                </div>
            
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=13"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeTea.jpg"/>
                        <div class="media__body"><h1>Coffee & Tea Items</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
               <div class="media">
                        <a href="UserFood.aspx?id=14"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeKaba.jpg"/>
                        <div class="media__body"><h1>Chaap & Kabab</h1></div></a>
                </div>
            
            </div>
        </div>
    <div class="row">
            <div class="col-lg-6">
                <div class="media">
                        <a href="UserFood.aspx?id=15"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeSetMenu.jpg"/>
                        <div class="media__body"><h1>Set Menu</h1></div></a>
                </div>
            </div>
            <div class="col-lg-6">
              
               <div class="media">
                        <a href="UserFood.aspx?id=16"><img alt="" class="media__image" width="600" height="300" src="pic/FoodHomeDrinks.jpg"/>
                        <div class="media__body"><h1>Drinks & Juice</h1></div></a>
                </div>
            
            </div>
        </div>

   
</asp:Content>