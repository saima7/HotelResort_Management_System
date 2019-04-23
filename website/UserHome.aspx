<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="WebApplication3.UserHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style>
html, body{
	margin:0;
	font-size: 100%;
	font-family: 'Lato', sans-serif;
	background: #fff;
    height:100%;
    width:100%;
}
body a {
	text-decoration:none;
	transition:0.5s all;
	-webkit-transition:0.5s all;
	-moz-transition:0.5s all;
	-o-transition:0.5s all;
	-ms-transition:0.5s all;
}
a:hover{
 text-decoration:none;
}
input[type="button"],input[type="submit"]{
	transition:0.5s all;
	-webkit-transition:0.5s all;
	-moz-transition:0.5s all;
	-o-transition:0.5s all;
	-ms-transition:0.5s all;
}
h1,h2,h3,h4,h5,h6{
	margin:0;
	font-family: 'Federo', sans-serif;
    font-weight: 600;
}	
p{
	margin:0;
}
ul{
	margin:0;
	padding:0;
}
label{
	margin:0;
}
/*-- header --*/
/*--header -top--*/
.social-bnr-agileits{
	float:left;
	margin-left:1em;
}
/*--social-icons--*/
ul.social-icons3 {
    display: block;
    padding: 0;
    margin-top: .55em;
}
.social-icons3 li{
	display:inline-block;
}
.social-icons3 li a{  
    display: block;
    height: 30px;
    width: 30px;
    margin-right: 1em;
    -webkit-transition: .5s all;
    transition: .5s all;
    -moz-transition: .5s all;
	margin-right: 1em;
	-webkit-transition: .5s all;
    transition: .5s all;
    -moz-transition: .5s all;
	box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -webkit-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -moz-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -o-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -ms-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    line-height: 30px;
	color:#fff;
	text-align:center;
}
.social-icons3 li a.fa.fa-facebook.icon-border.facebook{
	 background:#4D669C;
}
.social-icons3 li a.fa.fa-twitter.icon-border.twitter{
	 background:#1da1f2;
}
.social-icons3 li a.fa.fa-google-plus.icon-border.googleplus{
	 background:#d34836;
}
.social-icons3 li a.fa.fa-rss.icon-border.rss{
	 background:#ee802f;
}
.social-icons3 li a:hover{
	text-decoration:none;
	opacity:0.8;
}
.contact-bnr-w3-agile {
    float: right;
}
.contact-bnr-w3-agile ul li {
    list-style: none;
    display: inline-block;
       /*border-left: 1px solid #0066b2;*/
    padding: 13px 20px;
        color: #101010;
	font-size:14px;
	 transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -o-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -ms-transition: 0.5s all;
}
.contact-bnr-w3-agile ul li a{
	    color: #101010;
	text-decoration:none;
	 transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -o-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -ms-transition: 0.5s all;
	text-transform: lowercase;
	font-size: 15px;
}
.contact-bnr-w3-agile ul li a:hover{
	 color: #0066b2;
	 transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -o-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -ms-transition: 0.5s all;
}
.contact-bnr-w3-agile ul li i {
       color: #000000;
    font-size: 16px;
    margin-right: 15px;
}
/*--search--*/
.contact-bnr-w3-agile ul li.s-bar {
    background: #ffce14;
	border-left:1px solid #ffce14;
}
.search label.icon-search {
    color: #212121;
	cursor: pointer;
}
.search_form{
	position:absolute;
	z-index:9999;
	right:0;
	top:15px;
	overflow: hidden;
	width: 20px;
	height:0px;
	background: #000000;
	transition: height 0.2s ease-out 0.5s , top 0.2s ease-out 0.5s, padding 0.2s ease-out 0.5s, width 0.3s ease-out 0.2s;
	-webkit-transition: height 0.2s ease-out 0.5s , top 0.2s ease-out 0.5s, padding 0.2s ease-out 0.5s, width 0.3s ease-out 0.2s;
}
.search_form form{
	opacity:0;
	transition:all 0.3s ease-out;
	-webkit-transition:all 0.3s ease-out;
}
.search_form input[type='search']{
      width: 353px;
    padding: 6px;
    outline: none;
    font-size: 14px;
    color: #555;
    border: 1px solid #fff;
    background: #fff;
	font-family: 'Lato', sans-serif;
}
.search_form input[type='search']::-webkit-input-placeholder{
	color:#fff !important;
}
.search_form input[type='submit'] {
    outline: none;
    display: inline-block;
    color: #fff;
    font-size: 14px;
    letter-spacing: .5px;
    background: #0f2453;
    border: 2px solid #ffffff;
    text-transform: uppercase;
    padding: 5px 31px;
	font-family: 'Federo', sans-serif;
}
.search_form input[type='submit']:hover {
    background: #ffce14;
    color: #000;
}
.search_box{
	visibility: hidden;
}
.search_box:checked~.search_form{
       width: 500px;
      height: 53px;
    padding: 10px;
        top: 52px;
	transition: height 0.2s ease-out, top 0.2s ease-out, padding 0.2s ease-out, 0.3s width ease-out 0.2s;
	-webkit-transition: height 0.2s ease-out, top 0.2s ease-out, padding 0.2s ease-out, 0.3s width ease-out 0.2s;
}
.search_box:checked~.search_form form{
	opacity:1;
	transition:0.3s all ease-out 0.5s;
	-webkit-transition:0.3s all ease-out 0.5s;
}
label.icon-search span {
    color: #fff;
    font-size: 1.2em;
    top: 2px;
    right: 2px;
    padding-right: 12px;
}
/*--//search--*/
/*-- nav --*/
.w3_navigation {
    background: #8e7a7a ;
}
.navbar-default {
    background: none;
    border: none;
}
.navbar {
    margin-bottom: 0;
}
.navbar-collapse {
    padding: 0;
}
.navbar-right {
    margin-right: 0;
}
.navbar-default .navbar-nav > .active > a, .navbar-default .navbar-nav > .active > a:hover, .navbar-default .navbar-nav > .active > a:focus {
    color:#fff;
    background:none;
}
.navbar-default .navbar-nav > li > a {
    font-weight: 500;
    letter-spacing: 1px;
}
.navbar-nav > li > a {
    margin: 0;
    padding:0 1.5em;
    text-transform: uppercase;
}
.navbar-default .navbar-nav > li > a:hover{
    color:#ffce14;
}
.navbar-default .navbar-nav > li > a:focus {
    color: #000000;
	outline:none;
}
nav.navbar.navbar-default {
    background: none;
    padding: .9em 0 .4em 0;
}
.navbar-default .navbar-nav > .open > a, .navbar-default .navbar-nav > .open > a:hover, .navbar-default .navbar-nav > .open > a:focus {
    color:#000000;
    background: none;
}
.navbar-default .navbar-nav > li > a {
    color: #000000;
}
.navbar-default .navbar-nav  > .active.open > a:focus {
	background: #0a9dbd;
	color: #fff;
}
.navbar-default .navbar-brand,.navbar-default .navbar-brand:hover, .navbar-default .navbar-brand:focus {
    color: #fff;
}
.navbar-brand {
    padding: 0;
    font-size: 31px;
    text-transform: uppercase;
    letter-spacing: 5px;
    line-height: 25px;
    position: relative;
    font-weight: bold;
}
.navbar-brand span {
       color: #ffce14;
}
p.logo_w3l_agile_caption {
    text-transform: uppercase;
    letter-spacing: 5.7px;
    font-size: 11px;
    color: #c79f07;
    text-shadow: 0px 1px 3px #454a47;
    font-family: 'Lato', sans-serif;
    font-weight: 600;
}
.agile_short_dropdown {
    border-radius: 0;
    background: #ffffff;
    text-align: center;
	padding:0;
	border: none;
}
.agile_short_dropdown li a{
	text-transform:uppercase;
	color:#212121;
	font-size:13px;
	font-weight:600;
	padding: .8em 0;
}
.agile_short_dropdown > li > a:hover{
    color: #fff;
    text-decoration: none;
   background-color: #ffce14;
}
/*-- nav-effect --*/
.menu__list {
    position: relative;
    margin: 0.69em 0 0;
}

.menu__item {
	display: block;
	margin: 1em 0;
}

.menu__link {
	font-size: .9em;
	font-weight: bold;
	display: block;
	padding: 1em;
	cursor: pointer;
	-webkit-user-select: none;
	-moz-user-select: none;
	-ms-user-select: none;
	user-select: none;
	-webkit-touch-callout: none;
	-khtml-user-select: none;
	-webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}
/* Iris */
.menu--iris .menu__item {
	margin:0 0.3em;
}
li.menu__item:nth-child(6) {
    margin-right: 0;
}
.menu--iris .menu__link {
	position: relative;
	text-align: center;
	-webkit-transition: color 0.3s;
	transition: color 0.3s;
	text-shadow: 0px 1px 3px #033815;
}

.menu--iris .menu__link:hover,
.menu--iris .menu__link:focus {
	color: #929292;
}

.menu--iris .menu__item--current .menu__link,.menu__link:hover {
	color:#ffce14;
}

.menu--iris .menu__link::before,
.menu--iris .menu__link::after {
	content: '';
	position: absolute;
	width: 10px;
	height: 10px;
	opacity: 0;
	border: 2px solid #ffce14;
	-webkit-transition: -webkit-transform 0.3s, opacity 0.3s;
	transition: transform 0.3s, opacity 0.3s;
	-webkit-transition-timing-function: cubic-bezier(0.17, 0.67, 0.05, 1.29);
	transition-timing-function: cubic-bezier(0.17, 0.67, 0.05, 1.29);
}

.menu--iris .menu__link::before {
	top: 0;
	left: 0;
	border-width: 2px 0 0 2px;
	-webkit-transform: translate3d(10px, 10px, 0);
	transform: translate3d(10px, 10px, 0);
}

.menu--iris .menu__link::after {
	right: 0;
	bottom: 0;
	border-width: 0 2px 2px 0;
	-webkit-transform: translate3d(-10px, -10px, 0);
	transform: translate3d(-10px, -10px, 0);
}

.menu--iris .menu__item--current .menu__link::before,
.menu--iris .menu__item--current .menu__link::after,.menu__link:hover::before,.menu__link:hover::after {
	opacity: 1;
	-webkit-transform: translate3d(0, 0, 0);
	transform: translate3d(0, 0, 0);
}
/*-- //nav-effect --*/
/*-- //header --*/
/*-- banner-text --*/ 
.header-w3layouts{
    position: absolute;
    top: 0;
    z-index: 99;
    text-align: center;
    left: 0;
    width: 100%;
}
.agileits-banner-info h4 {
    font-size: 4em;
    color: #ffce14;
    letter-spacing: 27px;
    font-weight: bold;
    text-transform: uppercase;
    font-family: 'Oswald', sans-serif;
}
.agileits-banner-info h3 {
    color: #fff;
    font-size: 1.5em;
    margin: 10px 0 0;
    letter-spacing: 10px;
    text-transform: uppercase;
    font-weight: 700;
}
.agileits-banner-info h3 span {
    background: rgba(0, 0, 0, 0.68);
    padding: 0 36px;
}
.agileits-banner-info {
    text-align: center;
    padding: 7em 2em;
    margin-top: 8em;
}
.agileits-banner-info p {
    color: #ffce14;
    font-size: 1em;
    line-height: 1.8em;
    letter-spacing: 11px;
    margin: 1em auto;
    font-weight: 300;
    text-transform: uppercase;
}
.agileits_w3layouts_more{
	position:relative;
}
.agileits_w3layouts_more a {
    font-size: 13px;
    color: #fff;
    text-decoration: none;
    text-transform: uppercase;
    letter-spacing: 2px;
    padding: 8px 25px;
    position: relative;
    display: inline-block;
    background: #0f2453;
	    margin-top: 3em;
    z-index: 9999;
    border: 2px solid #fff;
}
.agileits_w3layouts_more a:focus{
	outline:none;
}
.agileits_w3layouts_more a:hover{
	color:#000;
	border: 2px solid #fff;
	background: #ffce14;
}
/*-- //banner-text --*/
/*-- banner-top --*/
.w3layouts-banner-top{
    background: url(../pic/1.jpg) no-repeat 0px 0px;
    background-size: cover;	
	-webkit-background-size: cover;	
	-moz-background-size: cover;
	-o-background-size: cover;		
	-moz-background-size: cover;
}
.w3layouts-banner-top1{
	background: url(../pic/2.jpg) no-repeat 0px 0px;
    background-size: cover;	
	-webkit-background-size: cover;	
	-moz-background-size: cover;
	-o-background-size: cover;		
	-moz-background-size: cover;
}
.w3layouts-banner-top2{
	background: url(../pic/3.jpg) no-repeat 0px 0px;
    background-size: cover;	
	-webkit-background-size: cover;	
	-moz-background-size: cover;
	-o-background-size: cover;		
	-moz-background-size: cover;	
}
.w3layouts-banner-top,.w3layouts-banner-top1,.w3layouts-banner-top2{
	min-height:700px;
}
.w3ls-banner {
    position: relative;
}
/*-- //banner-top --*/ 
/*--slider--*/
#slider2,
#slider3 {
  box-shadow: none;
  -moz-box-shadow: none;
  -webkit-box-shadow: none;
  margin: 0 auto;
}
.rslides_tabs li:first-child {
  margin-left: 0;
}
.rslides_tabs .rslides_here a {
  background: rgba(255,255,255,.1);
  color: #fff;
  font-weight: bold;
}
.events {
  list-style: none;
}
.callbacks_container {
  position: relative;
  float: left;
  width: 100%;
}
.callbacks {
  position: relative;
  list-style: none;
  overflow: hidden;
  width: 100%;
  padding: 0;
  margin: 0;
}
.callbacks li {
  position: absolute;
  width: 100%;
}
.callbacks img {
  position: relative;
  z-index: 1;
  height: auto;
  border: 0;
}
.callbacks .caption {
	display: block;
	position: absolute;
	z-index: 2;
	font-size: 20px;
	text-shadow: none;
	color: #fff;
	left: 0;
	right: 0;
	padding: 10px 20px;
	margin: 0;
	max-width: none;
	top: 10%;
	text-align: center;
}

.callbacks_nav {
    position: absolute;
    -webkit-tap-highlight-color: rgba(0,0,0,0);
    top:55%;
    left: 40px;
    opacity: 0.7;
    z-index: 3;
    text-indent: -9999px;
    overflow: hidden;
    text-decoration: none;
    height: 34px;
    width: 34px;
    background: url(../pic/left.png) no-repeat 0px 0px;
}
.callbacks_nav.next {
    left: auto;
    background: url(../pic/right.png) no-repeat 0px 0px;
    right: -62px;
}
.callbacks_nav.prev {
    left: auto;
    background: url(../pic/left.png) no-repeat 0px 0px;
    left: -58px;
}
#slider3-pager a {
  display: inline-block;
}
#slider3-pager span{
  float: left;
}
#slider3-pager span{
	width:100px;
	height:15px;
	background:#fff;
	display:inline-block;
	border-radius:30em;
	opacity:0.6;
}
#slider3-pager .rslides_here a {
  background: #FFF;
  border-radius:30em;
  opacity:1;
}
#slider3-pager a {
  padding: 0;
}
#slider3-pager li{
	display:inline-block;
}
.rslides {
  position: relative;
  list-style: none;
  overflow: hidden;
  width: 100%;
  padding: 0;
}
.rslides li {
  -webkit-backface-visibility: hidden;
  position: absolute;
  display:none;
  width: 100%;
  left: 0;
  top: 0;
}
.rslides li{
  position: relative;
  display:block;
  float: left;
}
.rslides img {
  height: auto;
  border: 0;
  }
.callbacks_tabs {
    list-style: none;
    position: absolute;
    top: 56%;
    left: 46.5%;
    padding: 0;
    margin: 0;
    display: block;
    z-index: 99;
}
.slider-top span{
	font-weight:600;
}
.callbacks_tabs li {
    display:inline-block;
    margin: 0px 7px;
}
/*----*/
.callbacks_tabs a{
 visibility: hidden;
}
.callbacks_tabs a:after {
    content: "\f111";
    font-size: 0;
    font-family: FontAwesome;
    visibility: visible;
    display: block;
    height:10px;
    width:10px;
    display: inline-block;
    background: #ffffff;
    border-radius: 50%;
    -webkit-border-radius: 50%;
    -o-border-radius: 50%;
    -moz-border-radius: 50%;
    -ms-border-radius: 50%;
}
.callbacks_here a:after{
       background:#ffce14;
}
.thim-click-to-bottom {
    position: absolute;
    bottom: 12%;
    left: 49%;
    width: 40px;
    height: 40px;
    font-size: 40px;
    line-height: 40px;
    -webkit-animation: bounce 2s infinite ease-in-out;
    z-index: 99;
}
.thim-click-to-bottom i {
    color: #ffce14;
    border: 2px solid #fff;
    font-size: 18px;
    width: 30px;
    height: 57px;
    text-align: center;
    line-height: 54px;
    border-radius: 20px;
	-webkit-border-radius: 20px;
    -o-border-radius: 20px;
    -moz-border-radius: 20px;
    -ms-border-radius: 20px;
}
@-webkit-keyframes bounce {
	0%, 20%, 60%, 100%  { -ms-transform: translateY(0); }
	0%, 20%, 60%, 100%  { -o-transform: translateY(0); }
	0%, 20%, 60%, 100%  { -moz-transform: translateY(0); }
	0%, 20%, 60%, 100%  { -webkit-transform: translateY(0); }
    40%  { -webkit-transform: translateY(-20px); }
	80% { -webkit-transform: translateY(-10px); }
}
/*-- //slider --*/

/*--modal--*/
.modal-content  img{
	width:100%;
}
.modal-content h4 {
    color: #0f2453;
    text-align: center;
    font-size: 26px;
    margin-bottom: .5em;
    text-transform: uppercase;
}
.modal-content h4 span {
    color: #ffce14;
}
.modal-content h5 {
    color: #000;
    padding-top: 15px;
    font-size: 22px;
	letter-spacing: 1px;
}
.modal-content p {
    color: #636363;
    font-size: 14.5px;
    letter-spacing: .8px;
    line-height: 32px;
    padding-top: 10px;
	word-spacing: .5px;
}
.modal-header {
    padding: 30px;
}
/*--//modal--*/
/*-- banner-form--*/
.book-form-left-w3layouts {
    padding: 0;
}
.book-form-left-w3layouts h2 {
    color: #fff;
    background: #ffce14;
    padding: 60px 0;
    text-align: center;
    font-size: 25px;
    letter-spacing: 4px;
}
.book-form input[type="text"],.book-form input[type="date"],.book-form input[type="time"],.book-form input[type="email"] ,.book-form .form-control{
      width: 100%;
    color: #9a9797;
    outline: none;
    font-size: 0.9em;
    line-height: 25px;
    padding: 3px 10px;
    border: 2px solid #fff;
    -webkit-appearance: none;
    margin-bottom: 1em;
    background: none;
	font-family: 'Lato', sans-serif;
}
.book-form input[type="text"]{
	 border: 2px solid #fff;
}
.book-form form input[type="submit"] {
    text-transform: capitalize;
    background: #0a1735;
    color: #FFFFFF;
    padding: 0em 2em;
    height: 147px!important;
    border: none;
    font-size: 16px;
    letter-spacing: 2px;
    outline: none;
    -webkit-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -o-transition: 0.5s all;
    -ms-transition: 0.5s all;
    text-transform: uppercase;
    /* width: 23%; */
    font-weight: 600;
    margin-left: 1em;
    -webkit-appearance: none;
}
.book-form {
    background: #0f2453;
    height: 147px;
    padding: 0 0 0 27px;
}
.fields-w3ls {
    width: 22%;
    float: left;
    margin: 2.2em 1em 0 0;
}
.book-form p {
    color: #fff;
    font-size: 13px;
    font-weight: bold;
    margin-bottom: .8em;
    letter-spacing: 2px;
    word-spacing: 1px;
    text-transform: uppercase;
}
.book-form select.form-control {
    /* outline: none; */
    /* font-size: 1em; */
    /* padding: 5px 10px; */
    /* width: 100%; */
    /* line-height: 20px; */
    border-radius: 0;
    /* background: none; */
    /* color: #9a9797; */
    /* border: 2px solid #fff; */
    box-shadow: none!important;
}
.form-date-w3-agileits.second-agile {
    width: 30%;
}
.form-date-w3-agileits.second-agile,.form-time-w3layouts.second-agile,.form-left-agileits-w3layouts.second-agile,.form-left-agileits-w3layouts.bottom-w3ls.second-agile {
 
    margin-right:0!important;
	    padding:0!important;
}
.form-left-agileits-w3layouts.bottom-w3ls {
    padding:0!important;
}
.book-form input[type=submit]:hover {
    background: #ffce14;
    color: #fff;
}
/*-- //banner-form--*/
/*-- banner-bottom --*/
.banner-bottom{
	text-align:center;
}
.agileits_banner_bottom{
	width: 70%;
    margin: 0 auto;
}
.banner-bottom h3 {
    font-size: 1em;
    color: #ffce14;
    line-height: 2.3em;
    text-transform: uppercase;
    letter-spacing: 3px;
    font-weight: 600;
}
.banner-bottom h3 span {
    display: block;
    font-size: 25px!important;
    color: #000000;
    font-weight: 500;
}
.banner-bottom h3 i{
	font-weight:300;
}
.w3ls_banner_bottom_grids{
	margin:3em 0 0;
}
.w3l_banner_bottom_grid{
	padding:2em;
	text-align:center;
	border:2px solid #999;
}
/*-- grid-effect --*/
/* General grid styles */
.cbp-ig-grid {
	list-style: none;
	padding:0;
	margin: 0;
}

/* Clear floats */
.cbp-ig-grid:before, 
.cbp-ig-grid:after { 
	content: " "; 
	display: table; 
}

.cbp-ig-grid:after { 
	clear: both; 
}

/* grid item */
.cbp-ig-grid li {
	width: 25%;
    float: left;
    text-align: center;
    border-left: 1px solid #cfdbf3;
}

.cbp-ig-grid li:last-child{
	border-right: 1px solid #cfdbf3;
}

.w3_grid_effect {
    padding: 2em;
    background: rgba(52, 74, 113, 0.09);
}

/* anchor style */
.cbp-ig-grid li > a {
	display: block;
	height: 100%;
	color: #47a3da;
	-webkit-transition: background 0.2s;
	-moz-transition: background 0.2s;
	transition: background 0.2s;
}

/* the icon with pseudo class for icon font */
.cbp-ig-icon {
	padding: 1.5em 0 0;
	display: block;
	-webkit-transition: -webkit-transform 0.2s;
	transition: -moz-transform 0.2s;
	transition: transform 0.2s;
}

.cbp-ig-icon:before {
	font-family:FontAwesome;
	font-size: 5em;
	speak: none;
	color: #0f2453;
	font-style: normal;
	font-weight: normal;
	font-variant: normal;
	text-transform: none;
	line-height: 1;
	-webkit-font-smoothing: antialiased;
}

.w3_road:before {
	content: "\f236";
}

.w3_cube:before {
	content: "\f1ad";
}

.w3_users:before {
	content: "\f0f4";
}

.w3_ticket:before {
	content: "\f1eb";
}

/* title element */
.cbp-ig-grid .cbp-ig-title {
	margin: 20px 0 10px 0;
    padding: 20px 0 0 0;
    font-size: 1em;
    position: relative;
    -webkit-transition: -webkit-transform 0.2s;
    -moz-transition: -moz-transform 0.2s;
    transition: transform 0.2s;
    text-transform: uppercase;
    letter-spacing: 4px;
	color:#212121;
}

.cbp-ig-grid .cbp-ig-title:before {
	content: '';
	position: absolute;
	background:#ffce14;
	width: 160px;
	height: 6px;
	top: 0px;
	left: 50%;
	margin: -10px 0 0 -80px;
	-webkit-transition: margin-top 0.2s; /* top or translate does not seem to work in Firefox */
	-moz-transition: margin-top 0.2s;
	transition: margin-top 0.2s;
}

.cbp-ig-grid .cbp-ig-category {
	text-transform: uppercase;
	display: inline-block;
	font-size: 1em;
	letter-spacing: 1px;
	color: #ffce14;
	-webkit-transform: translateY(10px);
	-moz-transform: -moz-translateY(10px);
	-ms-transform: -ms-translateY(10px);
	transform: translateY(10px);
	opacity: 0;
	-webkit-transition: -webkit-transform 0.3s, opacity 0.2s;
	-moz-transition: -moz-transform 0.3s, opacity 0.2s;
	-webkit-transition: transform 0.3s, opacity 0.2s;
}

.cbp-ig-grid li:hover .cbp-ig-category,
.touch .cbp-ig-grid li .cbp-ig-category {
	opacity: 1;
	-webkit-transform: translateY(0px);
	-moz-transform: translateY(0px);
	-ms-transform: translateY(0px);
	transform: translateY(0px);
}

/* Hover styles */

.cbp-ig-grid li > .w3_grid_effect:hover {
    background: #0f2453;
}

.cbp-ig-grid li > .w3_grid_effect:hover .cbp-ig-icon {
	-webkit-transform: translateY(-20px);
	-moz-transform: translateY(-20px);
	-ms-transform: translateY(-20px);
	transform: translateY(-20px);
}

.cbp-ig-grid li > .w3_grid_effect:hover .cbp-ig-icon:before
 {
	color: #ffce14;
}
.cbp-ig-grid li > .w3_grid_effect:hover .cbp-ig-title{
	color:#fff;
}

.cbp-ig-grid li > .w3_grid_effect:hover .cbp-ig-title {
	-webkit-transform: translateY(-45px);
	-moz-transform: translateY(-45px);
	-ms-transform: translateY(-45px);
	transform: translateY(-45px);
}

.cbp-ig-grid li > .w3_grid_effect:hover .cbp-ig-title:before {
	background: #fff;
	margin-top: 68px;
}


@media screen and (max-width: 62.75em) {
	.cbp-ig-grid li {
		width: 50%;
	}
}

@media screen and (max-width: 25em) { 
	.cbp-ig-grid {
		font-size: 80%;
	}
}
/*-- //banner-bottom --*/
/*--main--*/
.contact-w3ls,.advantages,.banner-bottom ,.w3l-visitors-agile,.plans-section,.team{
	padding: 100px 0px;
}
h3.title-w3-agileits {
    font-size: 3em;
    color: #FFF;
	font-weight: 300;
    letter-spacing: 3px;
    margin-bottom: 1em;
    text-align: center;  
	text-transform: capitalize;
	font-family:'Oswald', sans-serif;
}
.title-black-wthree{
	color:#0f2453!important;
}
/*--//main--*/
/*-- /about --*/
.about-wthree {
    padding: 5em 0 22.6em 0px;
    background: #eceef2;
}
.ab-w3l-spa {
    text-align: center;
    position: relative;
}
.w3l-slider-img {
    border: 10px solid rgba(255, 255, 255, 0.4);
    position: absolute;
    left: 2em;
    top: 29em;
}
.w3ls-info-about {
    position: absolute;
    left: 46%;
    z-index: 99;
    padding: 2em 4.5em;
    top: 107%;
    border: 10px solid #000;
}
.w3ls-info-about h4 {
    font-size: 1.5em;
    letter-spacing: 1px;
    color: #ffce14;
    /* margin-bottom: 11px; */
    line-height: 1.4em;
    text-transform: capitalize;
    background: #0f2453;
    padding: 10px 15px;
}
.w3ls-info-about p {
    /* margin: 0em 0 2em 0; */
    color: #ffffff;
    line-height: 2.2em;
    background: rgba(0, 0, 0, 0.85);
    font-size: 0.9em;
    letter-spacing: 2px;
}
p.about-para-w3ls {
    color: #777;
    font-size: 16px;
    line-height: 33px;
    letter-spacing: 0.5px;
    margin-bottom: 2em;
}
/*-- //about --*/
/*--sevices-section--*/
.advantages {
    background: url(../pic/services.jpg)no-repeat;
    min-height: 350px;
    background-size: cover;
}
.advantage-block {
    padding:2em 2em;
    background: rgba(0, 0, 0, 0.52);
    text-align: center;
}
.advantage-block:hover {
    background: rgba(255, 255, 255, 0.22);
    transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -o-transition: 0.5s all;
}
.advantage-block h4 {
    font-size: 1.5em;
    color: #fff;
    margin: 0.5em 0em 0.5em 0em;
    text-transform: capitalize;
    letter-spacing: 1px;
}
.advantage-block p {
    font-size: 16px;
    color: #FFF;
    /* line-height: 1.8em; */
    text-align: left;
    padding-left: 3em;
    line-height: 35px;
	letter-spacing: .8px;
}
.advantage-grid {
    padding: 0;
}
.left-w3ls {
    border-right: 1px solid #b1b1b1;
}
.advantage-block .fa-credit-card,.advantage-block .fa-clock-o {
    color: #ffce14;
    font-size: 45px;
    margin-bottom: 10px;
}
.advantage-block p i {
    color: #ffce14;
    font-size: 13px;
    margin-right: 10px;
}
/*--//services-section--*/
/*-- team --*/

.tab1 .team-img-w3-agile{
	  background: url(../pic/teamb1.jpg)no-repeat 0px 0px;
}
.tab2 .team-img-w3-agile{
	  background: url(../pic/teamb2.jpg)no-repeat 0px 0px;
}
.tab3 .team-img-w3-agile{
	  background: url(../pic/teamb3.jpg)no-repeat 0px 0px;
}
.tab4 .team-img-w3-agile{
	  background: url(../pic/teamb4.jpg)no-repeat 0px 0px;
}
.tab1 .team-img-w3-agile,.tab2 .team-img-w3-agile,.tab3 .team-img-w3-agile,.tab4 .team-img-w3-agile{
	-webkit-background-size: cover;
	-moz-background-size: cover;
	-o-background-size: cover;
	-ms-background-size: cover;
    background-size: cover;
	min-height: 360px;
    width: 27%;
	margin-left: 4em;
}
.team-Info-agileits {
    text-align: left;
    padding: 4em 0 0 3em;
}
.team-Info-agileits h4 {
    font-size: 25px;
    letter-spacing: 1px;
}
.team-Info-agileits span {
    font-size: 12px;
    text-transform: uppercase;
    letter-spacing: 1px;
    color: #7d7a7a;
}
.team-Info-agileits p {
    font-size: 16px;
    /* text-transform: uppercase; */
    letter-spacing: .5px;
    color: #337ab7;
    line-height: 30px;
    margin: 1.5em 0 1em;
}
.resp-tabs-list li{
    opacity: .5;
}
li.resp-tab-item.resp-tab-active{
	opacity:1;
}
ul.resp-tabs-list {
    margin-left: 15em;
}
.resp-tabs-list li img {
    border-radius: 100%;
	-webkit-border-radius: 100%;
    -o-border-radius: 100%;
    -moz-border-radius: 100%;
    -ms-border-radius: 100%;
	box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -webkit-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -moz-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -o-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
    -ms-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);

}
/*-- //team --*/
/*--rooms & rates --*/
.price-list ul {
    padding: 0px;
    list-style: none;
}
.price-gd-top {
    text-align: center;
    position: relative;
}
.price-gd-top h4 {
    font-size: 1.5em;
    color: #fff;
    padding: 0.4em 1em;
    background: #0f2453;
    font-weight: 300;
    position: absolute;
    top: 9.6em;
    right: 0em;
}
.price-selet h3 {
    padding: 0.2em 0em 0em 0em;
    font-size: 1.7em;
    float: left;
    margin-left: 20px;
}
.price-selet h3 span {
    color: #ef0404;
    font-size: 31px;
    margin-right: 5px;
}
.price-gd-bottom {
    background: #fff;
    text-align: center;
    padding: 1.8em 0em 1em;
}
.price-gd-top img {
    width: 100%;
}
.price-list ul li {
    padding: 0.5em 0em;
    font-size: 0.9em;
    color: #2b2b2b;
    display: inline-block;
}
.price-selet {
    padding: 1em 0em;
    text-align: center;
    background: #fff;
}
.price-selet a {
    font-size: 1.1em;
    color: #fff;
    display: block;
}
.price-selet a {
    font-size: 0.9em;
    color: #000000;
    display: inline-block;
    padding: 0.5em 2em;
    background: #ffce14;
    text-decoration: none;
    border: 2px solid #ecbf11;
}
.price-block {
    box-shadow: 0px 0px 2px 1px rgba(0,0,0,0.15);
    transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -o-transition: 0.5s all;
}
.price-block:hover,.w3layouts-pricing:hover,.w3-agileits-vpn-grid:hover {
    transform: scale(1.1);
    -webkit-transform: scale(1.1);
    -moz-transform: scale(1.1);
    -o-transform: scale(1.1);
    -ms-transform: scale(1.1);
    z-index: 1;
}
/*--//rooms & rates --*/
  /*-- visitors --*/
  .w3l-visitors-agile {
    background: rgba(15, 36, 83, 0.07);
}
.title-agileits1 {
    text-align: center;
}
.title-agileits1 h3{
    display: block;
    color: #212121;
    font-size: 2.5em;
    position: relative;
    padding-bottom: .5em;
}

.title-agileits1 h3:before {
       content: '';
    background: #bdbdbd;
    height: 1px;
    width: 23%;
    position: absolute;
    bottom: 0%;
    left: 38%;
}
.title-agileits1 h3:after {
         content: '';
    background: #00a4e4;
    height: 4px;
    width: 10%;
    position: absolute;
    bottom: -1px;
    left: 44%;
}

h3.w3l-agile:before,h2.w3l-agile:before  {
	content: '';
    background: #ccc;
    height: 1px;
    width: 15%;
    position: absolute;
    bottom: 0%;
    left: 43%;
}

.w3layouts_work_grid_left{
	float:left;
	width:50%;
	position:relative;
}
.w3layouts_work_grid_left_pos{
	position: absolute;
    top: 18%;
    right: -7%;
    width: 60%;
}
.w3layouts_work_grid_right {
    float: right;
    width: 50%;
    padding: 5em 13em 0em 6em;
    margin-top: 5em;
}
.w3layouts_work_grid_left_pos img {
      border: 10px solid #ffffff;
	  box-shadow: 0 0 15px rgba(98,98,98,0.32);
	  -webkit-box-shadow: 0 0 15px rgba(98,98,98,0.32);
}
.w3layouts_work_grid_right h4{
	font-size:1em;
       color: #0f2453;
    text-transform: uppercase;
    letter-spacing: 2px;
}
.w3layouts_work_grid_right h4 i{
       color: #ffce14!important;
}
.w3layouts_work_grid_right h5 {
    font-size: 1.5em;
    letter-spacing: 2px;
	text-align:right;
    margin-top: 10px;
    color: #212121;
    line-height: 1.4em;
    text-transform: capitalize;
}
.w3layouts_work_grid_right p {
    margin: 2em 0 0;
    color: #444;
    font-size: 16px;
    line-height: 2.2em;
    letter-spacing: 1px;
}
.w3layouts_work_grid_right p:nth-child(4) {
    color: #ffce14;
    text-align: right;
    margin-top: 0!important;
    font-size: 14px;
    line-height: 20px;
}
  /*-- //visitors --*/
/*-- Gallery Section --*/
#portfolio p {
  line-height: 1.8em;
  margin: 25px 0 0 0;
  font-size:1.1em;
  color: #ffffff;
  font-weight: 300;
}
.gallery-section h3{
   margin: 0;
  color: #ffffff;
  font-size: 36px;
  font-weight: 500;
  letter-spacing: 18px;
}
.gallery-grid {
  padding: 0;
}
.gallery1 {
position:relative;
}
.gallery1 .textbox {
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0;
    left: 0;
    -webkit-transform: scale(0);
    transform: scale(0);
    background-color: rgba(15, 36, 83, 0.62);
}
.gallery1:hover .textbox {
	-webkit-transform: scale(1);
	transform: scale(1);
}
.gallery-grid img{
		width:100%;
}

.textbox {
-webkit-transition: all 0.7s ease;
transition: all 0.7s ease;
text-align:center;
}
.textbox h4 {
    font-size: 2em;
    color: #FFF;
    margin-top: 3.5em;
    text-transform: uppercase;
    font-weight: 700;
    letter-spacing: 5px;
}
.textbox p {
     font-size: 26px !important;
    color: #fff;
    margin: 6px 0 0 0!important;
    padding: 3px 0;
}
.gallery-grids {
  margin-top: 50px;
}
/*-- //Gallery Section --*/
/*-- contact --*/
section.contact-w3ls {
	background:url(../pic/contact.jpg) no-repeat;
	background-position:center;
	background-attachment:fixed;
	background-size:100% 100%;
	-webkit-background-size:100% 100%;
	-moz-background-size:100% 100%;
	-o-background-size:100% 100%;
	-ms-background-size:100% 100%;
}
section.contact-w3ls p.contact-agile1 {
    font-size: 15px;
	letter-spacing: 1px;
    font-weight: normal;
    padding-bottom: 10px;
    line-height: 29px;
    color: #fff;
}
section.contact-w3ls p.contact-agile1 strong {
    font-family: 'Federo', sans-serif;
    letter-spacing: 1.5px;
    color: #ffce14!important;
	font-size: 16px;
}
section.contact-w3ls p.contact-agile1 a {
	color:#fff;
}
section.contact-w3ls .contact-agileits,.contact-w3-agile1 {
    background-color: rgba(0, 0, 0, 0.55);
    padding: 20px 35px;
}
section.contact-w3ls h4 {
	font-size:35px;
	letter-spacing: 1.5px;
	font-weight:normal;
	color:#fff;
	padding-bottom:20px;
	font-family: 'Federo', sans-serif;
	text-align:center;
}
section.contact-w3ls p.contact-agile2 {
	font-size:16px;
	font-weight:normal;
	padding-bottom:20px;
	line-height:30px;
	color:#ffce14;
	text-align:center;
}
section.contact-w3ls label.contact-p1 {
    font-size: 17px;
	letter-spacing: 1px;
    font-weight: 300;
    color:#fff;
    padding-bottom: 10px;
	font-family: 'Federo', sans-serif;
}
.form-group {
    margin-bottom: 5px;
}
section.contact-w3ls p.help-block {
    color:#ff0500!important;
}
section.contact-w3ls input#name, section.contact-w3ls input#email, section.contact-w3ls input#phone  {
	height:37px;
}
section.contact-w3ls input#name, section.contact-w3ls input#email, section.contact-w3ls input#phone {
	font-size:17px;
	font-weight:normal;
	color:#fff;
	background-color:transparent;
	border-radius:0;
	border-color:#fff;
	font-family: 'Lato', sans-serif;
}
section.contact-w3ls button.btn.btn-primary {
	color:#ffce14;
    background-color:transparent;
    border: 2px solid #ffce14;
    font-size: 17px;
    padding: 10px 20px;	
	width:100%;
	font-family: 'Federo', sans-serif;
	margin: 25px 0 8px;
}
section.contact-w3ls button.btn.btn-primary:hover {
	color: #fff;
    background-color:#ffce14;
    border: 2px solid #ffce14;
}
input::-webkit-input-placeholder {
color: #fff !important;
} 
input:-moz-placeholder { /* Firefox 18- */
color: #fff !important;  
} 
input::-moz-placeholder {  /* Firefox 19+ */
color: #fff !important;  
} 
input:-ms-input-placeholder {  
color: #fff !important;  
}
.footer-icons-agileinfo{
	margin-left:0!important;
}
.contact-w3-agile1 iframe {
    width: 100%;
    height: 190px;
    margin-top: 1.5em;
    outline: none;
    border: none;
}
/*-- /contact --*/
/*--copy-right--*/
.copy {
    text-align: center;
    background: #0f2453;
}
.copy p {
    color: #fff;
    font-size: 14px;
    letter-spacing: 2px;
    padding: 1em;
}
.copy p a {
    color: #ffce14;
    text-decoration: none;
	transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -o-transition: 0.5s all;
    -ms-transition: 0.5s all;
}
.copy p a:hover{
	color:#fff;
	transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -o-transition: 0.5s all;
    -ms-transition: 0.5s all;
}
/*--//copy-right--*/
/*--//footer--*/
/*-- to-top --*/
#toTop {
    display: none;
    text-decoration: none;
    position: fixed;
    bottom: 30px;
    right: 25px;
    overflow: hidden;
    z-index: 999;
    width: 32px;
    height: 32px;
    border: none;
    text-indent: 100%;
    background: url(../images/arr.png) no-repeat 0px 0px;
}
#toTopHover {
    width: 32px;
    height: 32px;
	display: block;
	overflow: hidden;
	float: right;
	opacity: 0;
	-moz-opacity: 0;
	filter: alpha(opacity=0);
}
/*-- //to-top --*/
/*--responsive--*/
@media(max-width:1600px){
	.callbacks_tabs {
		top: 56%;
	}
	.thim-click-to-bottom {
		bottom: 6%;
		left: 49%;
	}
}
@media(max-width:1440px){
	.agileits-banner-info {
		padding: 5em 2em;
	}
	.callbacks_tabs {
		left: 46%;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 640px;
	}
	.thim-click-to-bottom {
		bottom: 11%;
	}
	.fields-w3ls {
		width: 21.5%;
	}
}
@media(max-width:1366px){
	.agileits-banner-info h4 {
		font-size: 3.5em;
	}
	.agileits-banner-info {
		margin-top: 5em;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 560px;
	}
	.callbacks_tabs {
		top: 54.5%;
	}
	.thim-click-to-bottom i {
		height: 53px;
	}
	.book-form-left-w3layouts h2 {
		padding: 61px 0;
		font-size: 23px;
		letter-spacing: 3.5px;
	}
	.w3layouts_work_grid_right {
		padding: 5em 11em 0em 6em;
		margin-top: 4em;
	}
	.contact-w3-agile1 iframe {
		height: 190px;
	}
	ul.resp-tabs-list {
		margin-left: 17em;
	}
}
@media(max-width:1280px){
	.book-form form input[type="submit"] {
		margin-left: 0.2em;
	}
	.book-form {
		padding: 0 0 0 23px;
	}
	.w3layouts_work_grid_right {
		padding: 5em 11em 0em 5em;
		margin-top: 2.5em;
	}
	.textbox h4 {
		font-size: 1.7em;
	}
}
@media(max-width:1080px){
	.navbar-brand {
		font-size: 26px;
	}
	p.logo_w3l_agile_caption {
		letter-spacing: 4.7px;
		font-size: 10px;
	}
	.menu__link {
		font-size: .8em;
	}
	.agileits-banner-info h4 {
		font-size: 3.3em;
		letter-spacing: 23px;
	}
	.agileits-banner-info h3 {
		font-size: 1.2em;
		letter-spacing: 9px;
	}
	.agileits-banner-info p {
		font-size: .9em;
		letter-spacing: 9px;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 500px;
	}
	.agileits-banner-info {
		margin-top: 4em;
	}
	.callbacks_tabs {
		left: 44.8%;
	}
	.agileits_w3layouts_more a {
		font-size: 12.5px;
		margin-top: 2.5em;
	}
	.thim-click-to-bottom {
		bottom: 11%;
		left: 48.5%;
	}
	.book-form-left-w3layouts h2 {
		padding: 54px 0;
		font-size: 16px;
	}
	.book-form form input[type="submit"] {
		padding: 0em 1.6em;
		height: 125px!important;
		font-size: 14px;
	}
	.book-form p {
		font-size: 12px;
	}
	.fields-w3ls {
		width: 20.5%;
		margin: 1.8em 1em 0 0;
	}
	.book-form {
		height: 125px;
	}
	.contact-w3ls, .advantages, .banner-bottom, .w3l-visitors-agile, .plans-section, .team {
		padding: 70px 0px;
	}
	.about-wthree {
		padding: 4em 0 21.2em 0px;
	}
	.banner-bottom h3 span {
		font-size: 22px!important;
		letter-spacing: 2px;
	}
	.cbp-ig-icon:before {
		font-size: 3em;
	}
	.cbp-ig-grid .cbp-ig-title {
		font-size: .9em;
		letter-spacing: 2px;
	}
	.cbp-ig-grid .cbp-ig-category {
		text-transform: uppercase;
		display: inline-block;
		font-size: .8em;
		letter-spacing: 1.5px;
	}
	h3.title-w3-agileits {
		font-size: 2.4em;
		margin-bottom: .8em;
	}
	.w3l-slider-img {
		top: 23em;
	}
	.w3ls-info-about h4 {
		font-size: 1.2em;
	}
	.w3ls-info-about {
		left: 48%;
		padding: 2em 3em;
		top: 110%;
	}
	.w3ls-info-about p {
		letter-spacing: 1.5px;
	}
	.advantage-block p {
		padding-left: 1em;
	}
	.advantage-block .fa-credit-card, .advantage-block .fa-clock-o {
		font-size: 40px;
	}
	.advantage-block h4 {
		font-size: 23px;
		letter-spacing: 2px;
	}
	.resp-tabs-list li img {
		border-radius: 100%;
		width: 85%;
		margin: 0 auto;
	}
	.resp-tabs-list li {
		padding: 11px 10px;
	}
	ul.resp-tabs-list {
		margin-left: 11.5em;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		width: 33%;
	}
	.team-Info-agileits h4 {
		font-size: 23px;
	}
	.team-Info-agileits {
		padding: 3.3em 0 0 3em;
	}
	.team-Info-agileits p {
		margin: 1.3em 0 .8em;
	}
	.price-grid {
		padding: 0px 10px;
	}
	.price-gd-top h4 {
		font-size: 1.3em;
		top: 9.4em;
	}
	.price-selet h3 {
		font-size: 1.5em;
	}
	.price-selet a {
		padding: 0.5em 1.7em;
	}
	.w3layouts_work_grid_left {
		width: 45%;
	}
	.w3layouts_work_grid_right h4 {
		font-size: 15px;
	}
	.w3layouts_work_grid_right {
		padding: 1em 9em 0em 1em;
		margin-top: 2.5em;
	}
	.w3layouts_work_grid_right h5 {
		font-size: 1.3em;
	}
	.flex-control-nav {
		top: 23%;
	}
	section.contact-w3ls h4 {
		font-size: 29px;
	}
	section.contact-w3ls label.contact-p1 {
		font-size: 15px;
		padding-bottom: 6px;
	}
	section.contact-w3ls p.contact-agile1 {
		line-height: 24.7px;
	}
	section.contact-w3ls button.btn.btn-primary {
		padding: 8px 20px;
	}
	.contact-w3-agile1 iframe {
		height: 185px;
	}
	section.contact-w3ls p.contact-agile1 {
		font-size: 13px;
	}
	.textbox h4 {
		font-size: 1.5em;
	}
}
@media(max-width:1050px){
	
}
@media(max-width:1024px){
	.navbar-brand {
		font-size: 23px;
		letter-spacing: 4px;
	}
	p.logo_w3l_agile_caption {
		letter-spacing: 3.2px;
	}
	.search_form input[type='search'] {
		width: 266px;
	}
	.search_form input[type='submit'] {
		font-size: 12px;
		letter-spacing: 1px;
		padding: 6.5px 19px;
	}
	.search_box:checked~.search_form {
		width: 384px;
	}
	.agileits-banner-info h4 {
		font-size: 2.9em;
		letter-spacing: 20px;
	}
	.agileits-banner-info h3 {
		font-size: 1.1em;
		letter-spacing: 8px;
	}
	.agileits-banner-info p {
		letter-spacing: 9px;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 480px;
	}
	.callbacks_tabs {
		left: 44.5%;
		top: 50.5%;
	}
	.thim-click-to-bottom {
		bottom: 19%;
	}
	.agileits-banner-info {
		margin-top: 3em;
	}
	.w3layouts_work_grid_right {
		margin-top: 2em;
	}
	.thim-click-to-bottom {
		bottom: 10%;
	}
	.textbox h4 {
		font-size: 1.3em;
	}
}
@media(max-width:991px){
	.menu__link {
		font-size: .76em;
	}
	.navbar-nav > li > a {
		padding: 0 1em;
	}
	.navbar-brand {
		font-size: 22px;
	}
	p.logo_w3l_agile_caption {
		letter-spacing: 3px;
	}
	.agileits-banner-info {
		padding: 4em 0em;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 460px;
	}
	.thim-click-to-bottom {
		bottom: 14%;
	}
	.book-form-left-w3layouts h2 {
		padding: 20px 0;
	}
	.book-form {
		padding: 0 0 0 57px;
	}
	.book-form form input[type="submit"] {
		margin-left: 1.3em;
	}
	.banner-bottom h3 span {
		font-size: 20px!important;
	}
	.banner-bottom h3 {
		font-size: 14px;
		line-height: 2.5em;
	}
	.cbp-ig-grid li:last-child,.cbp-ig-grid li:nth-child(3) {
		border-top: 1px solid #cfdbf3;
	}
	.cbp-ig-grid li:nth-child(2){
		border-right: 1px solid #cfdbf3;
	}
	.w3l-slider-img {
		width: 60%;
		left: 1em;
	}
	.w3ls-info-about {
		left: 32%;
		padding: 1.5em 3em;
		top: 104.5%;
		width: 68%;
		border: 8px solid #000;
	}
	.w3l-slider-img {
		border: 8px solid rgba(255, 255, 255, 0.4);
	}
	.left-w3ls {
		border-bottom: 1px solid #b1b1b1;
		border-right: none;
	}
	.advantage-grid {
		width: 80%;
		margin: 0 auto;
	}
	ul.resp-tabs-list {
		margin-left: 5em;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		width: 40%;
		float: left;
		margin-left: 0em;
	}
	.team-Info-agileits {
		padding:3em 0 0 2.5em;
		float: left;
		width: 60%;
	}
	.price-grid {
		padding: 0px 10px;
		width: 41%;
		float: left;
		margin: 0 2.02em;
	}
	.price-grid:nth-child(1),.price-grid:nth-child(2){
		margin-bottom: 2em;
	}
	.price-gd-top h4 {
		top: 12.3em;
	}
	h3.title-w3-agileits {
		font-size: 2.3em;
	}
	.w3layouts_work_grid_right {
		margin-top: 1em;
		padding: 1em 6em 0em 1em;
	}
	.contact-w3-agile2 {
		padding-left: 0;
	}
	section.contact-w3ls h4 {
		font-size: 25px;
		padding-bottom: 15px;
	}
	section.contact-w3ls .contact-agileits, .contact-w3-agile1 {
		padding: 20px 25px;
	}
	section.contact-w3ls p.contact-agile1 strong {
		font-size: 14px;
	}
	section.contact-w3ls p.contact-agile1 {
		font-size: 13px;
	}
	.contact-w3-agile1 iframe {
		height: 175px;
	}
	section.contact-w3ls p.contact-agile1 {
		padding-bottom: 4.5px;
	}
	.about-wthree {
		padding: 4em 0 16.8em 0px;
	}
	.w3ls_banner_bottom_grids {
		margin: 2.5em 0 0;
	}
	.gallery-grid {
		padding: 0;
		float: left;
		width: 33%;
	}
	.textbox h4 {
		margin-top: 4.5em;
	}
}
@media(max-width:900px){
	.callbacks_tabs {
		left: 44%;
	}
	.social-icons3 li a {
		height: 25px;
		width: 25px;
		margin-right: .5em;
		font-size: 14px;
		line-height: 26px;
	}
	ul.social-icons3 {
		margin-top: .6em;
	}
	.contact-bnr-w3-agile ul li {
		padding: 10px 14px;
	}
	.book-form {
		padding: 0 0 0 45px;
	}
	.advantage-block h4 {
		font-size: 21px;
	}
	.advantage-block .fa-credit-card, .advantage-block .fa-clock-o {
		font-size: 35px;
		margin-bottom: 3px;
	}
	ul.resp-tabs-list {
		margin-left: 4.5em;
	}
	.tpl6 .dmbutton {
		margin: 90px 5px 20px 5px;
	}
	.search_box:checked~.search_form {
		top: 43px;
	}
	.w3layouts_work_grid_right p {
		margin: 1em 0 0;
	}
	.form-group {
		margin-bottom: 0px;
	}
	section.contact-w3ls button.btn.btn-primary {
		margin: 21px 0 8px;
	}
}
@media(max-width:800px){
	.agileits-banner-info h4 {
		font-size: 2.5em;
		letter-spacing: 18px;
	}
	.agileits-banner-info p {
		letter-spacing: 6px;
		font-size: .8em;
	}
	.agileits-banner-info {
		margin-top: 1.5em;
	}
	.agileits_w3layouts_more a {
		font-size: 12px;
		margin-top: 2em;
		padding: 6px 20px;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 373px;
	}
	.callbacks_tabs {
		left: 42.85%;
		top: 51.5%;
	}
	.thim-click-to-bottom i {
		height: 40px;
		width: 25px;
		line-height: 39px;
		font-size: 15px;
	}
	.thim-click-to-bottom {
		bottom: 10%;
	}
	.book-form-left-w3layouts h2 {
		padding: 15px 0;
		font-size: 15px;
	}
	.book-form {
		padding: 0 0 0 25px;
	}
	.book-form form input[type="submit"] {
		margin-left: .3em;
	}
	.banner-bottom h3 span {
		font-size: 19px!important;
	}
	.tpl6 .dmbutton {
		margin: 78px 5px 20px 5px;
	}
	.w3layouts_work_grid_right p {
		font-size: 15px;
		line-height: 1.8em;
		letter-spacing: 0.5px;
	}
	.w3layouts_work_grid_right h4 {
		font-size: 13px;
		letter-spacing: 1px;
	}
	.w3layouts_work_grid_right {
		margin-top: 0.5em;
	}
	.w3layouts_work_grid_right h5 {
		font-size: 1.2em;
	}
	.flex-control-nav {
		top: 10%;
	}
	h3.title-w3-agileits {
		font-size: 2.1em;
	}
	.textbox h4 {
		margin-top: 4em;
		font-size: 1.2em;
	}
}
@media(max-width:768px){
	.book-form form input[type="submit"] {
		font-size: 13px;
	}
	.banner-bottom h3 span {
		font-size: 16px!important;
	}
	.banner-bottom h3 {
		font-size: 13px;
	}
	.w3_grid_effect {
		padding: 1.5em;
	}
	.cbp-ig-icon:before {
		font-size: 2.5em;
	}
	.cbp-ig-grid .cbp-ig-title {
		font-size: .8em;
	}
	p.about-para-w3ls {
		font-size: 14.5px;
	}
	.w3l-slider-img {
		top: 20.5em;
	}
	.w3ls-info-about h4 {
		font-size: 1.1em;
	}
	.w3ls-info-about p {
		font-size: 0.8em;
	}
	.w3ls-info-about {
		left: 36%;
		top: 105.5%;
		width: 64%;
	}
	.advantage-block h4 {
		font-size: 19px;
		margin: 0.8em 0em 0.2em 0em;
	}
	.advantage-block p {
		font-size: 14.5px;
		line-height: 33px;
	}
	.resp-accordion img{
		border-radius: 50%;
		   box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
		-webkit-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
		-moz-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
		-o-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
		-ms-box-shadow: 0 10px 20px rgba(0, 0, 0, 0.16);
	}
	h2.resp-accordion:first-child,h2.resp-accordion {
		border-top: none !important;
		border:none!important;
	}
	.w3layouts_work_grid_left_pos img {
		border: 7px solid #ffffff;
	}
	.team-Info-agileits p {
		font-size: 14.5px;
	}
	.team-Info-agileits h4 {
		font-size: 20px;
	}
	.w3layouts_work_grid_right p {
		font-size: 14.5px;
		line-height: 2em;
	}
	.flex-control-paging li a {
		font-size: 13px;
	}
	h3.title-w3-agileits {
		font-size: 2em;
		letter-spacing: 2px;
	}
	.w3layouts_work_grid_right h5 {
		font-size: 1.1em;
	}
	.contact-w3ls, .advantages, .banner-bottom, .w3l-visitors-agile, .plans-section, .team {
		padding: 55px 0px;
	}
	.about-wthree {
		padding: 4em 0 15.9em 0px;
	}
	.about-wthree {
		padding: 3em 0 13.9em 0px;
	}
}
@media(max-width:767px){
	.navbar-default .navbar-toggle .icon-bar {
		background-color: #fff;
	}
	.navbar-default .navbar-toggle {
		border-color: #ffce14;
		margin-top: 3px!important;
	}
	.navbar-default .navbar-toggle:hover, .navbar-default .navbar-toggle:focus {
		background-color: transparent;
	}
	.navbar-default .navbar-collapse, .navbar-default .navbar-form {
		border: none;
	}
	.nav > li > a {
		display: inline-block;
	}
	.navbar-collapse {
		box-shadow: none;
	}
	.menu__list {
		margin: 0;
		padding: 1em 0;
		background: #0a0a0a;
		text-align: center;
	}
	.menu--iris .menu__item {
		margin: 0 0 1em;
	}
	.navbar-nav .open .dropdown-menu {
		background-color:#1f7f9a;
	}
	.navbar-default .navbar-nav .open .dropdown-menu > li > a {
		color: #fff;
	}
	.navbar-nav .open .dropdown-menu > li > a, .navbar-nav .open .dropdown-menu .dropdown-header {
		padding: 10px 15px 10px 25px;
	}
	.navbar-default .navbar-collapse, .navbar-default .navbar-form {
		border: none;
		position: absolute;
		width: 100%;
		background: #a5a5a5;
		z-index: 999;
	}
	.navbar-toggle {
		margin: .8em 0 0;
	}
	.navbar-nav > li > a {
		padding: 0 3em;
	}
	.nav-tabs {
		margin: 2em 0;
	}
	.w3_tab_img_left {
		padding: 0 5px;
		width: 50%;
		float: left;
	}
	.navbar-toggle {
		margin: 0em 0 0;
		border-radius: 0;
		padding: 10px 10px;
	}
	.thim-click-to-bottom {
		left: 48%;
	}
	.price-gd-top h4 {
		top: 13.3em;
		font-size: 1.2em;
	}
	.price-selet a {
		padding: 0.3em 1.7em;
	}
	.price-gd-bottom {
		padding: 1.3em 0em 1em;
	}
	.price-selet {
		padding: .5em 0em;
	}
	.price-selet h3 {
		padding: 0em 0em 0em 0em;
	}
	.modal-dialog {
		width: 80%;
		margin: 2.5em auto 0;
	}
	.contact-w3-agile2 {
		padding: 0;
		margin-bottom:1em!important;
	}
	.contact-w3-agile2, .contact-w3-agile1 {
		width: 80%;
		margin: 0 auto;
	}
	section.contact-w3ls p.contact-agile2 {
		font-size: 14px;
		letter-spacing: 1px;
	}
	.contact-w3-agile1 iframe {
		height: 200px;
	}
}
@media(max-width:736px){
	.agileits-banner-info h4 {
		font-size: 2.1em;
		letter-spacing: 14px;
	}
	.agileits-banner-info h3 {
		font-size: 15px;
		letter-spacing: 6px;
	}
	.agileits-banner-info {
		padding: 2.5em 0em;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 340px;
	}
	.callbacks_tabs {
		left: 42.5%;
		top: 46.5%;
	}
	.book-form-left-w3layouts h2 {
		padding: 12px 0;
		font-size: 14px;
	}
	.banner-bottom h3 span {
		font-size: 15px!important;
	}
	.banner-bottom h3 {
		font-size: 12px;
	}
	.w3ls_banner_bottom_grids {
		margin: 1.55em 0 0;
	}
	.w3ls-info-about {
		left: 39%;
		top: 104.5%;
		width: 60%;
		border: 7px solid #000;
		padding: 1em 2em;
	}
	.w3ls-info-about h4 {
		font-size: 1.05em;
	}
	.about-wthree {
		padding: 4em 0 14em 0px;
	}
	.dmbutton {
		padding: 9px 13px;
	}
	a.dmbutton i {
		font-size: 15px;
	}
	.viewbox-button-next {
		right: -33px;
	}
	.viewbox-button-prev {
		left: -33px;
	}
	.viewbox-button-close {
		width: 45px;
		height: 45px;
	}
	.price-grid {
		width: 43%;
		margin: 0 1.5em;
	}
	.w3layouts_work_grid_left {
		width: 70%;
		float: none;
		margin: 0 auto;
	}
	.w3layouts_work_grid_right {
		float: none;
		width: 100%;
		margin-top: 0em;
		padding: 2em 7em 0em;
	}
	.flex-control-nav {
		top: 17%;
	}
	.textbox h4 {
		font-size: 1.1em;
		letter-spacing: 3px;
	}
}
@media(max-width:667px){
	.book-form p {
		font-size: 11px;
	}
	.fields-w3ls {
		width: 20.5%;
		margin: 1.8em .5em 0 0;
	}
	.book-form input[type="text"], .book-form input[type="date"], .book-form input[type="time"], .book-form input[type="email"], .book-form .form-control {
		font-size: 0.8em;
	}
	.book-form select.form-control {
		height: 34.8px;
	}
	.book-form form input[type="submit"] {
		font-size: 12px;
	}
	.fields-w3ls {
		width: 20.5%;
		margin: 1.2em .3em 0 0;
	}
	.book-form form input[type="submit"] {
		margin-left: .6em;
		height: 111px!important;
	}
	.w3l-slider-img {
		top: 23.5em;
		border: 6px solid rgba(255, 255, 255, 0.4);
		width: 50%;
	}
	.w3ls-info-about {
		left: 33%;
		width: 67%;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 318px;
	}
	.team-Info-agileits {
		padding: 1.8em 0 0 2em;
	}
	.viewbox-button-next {
		right: 18px;
	}
	.viewbox-button-prev {
		left: 18px;
	}
	.viewbox-button-next, .viewbox-button-prev {
		top: 54%;
		width: 90px;
		height: 90px;
	}
	.viewbox-body {
		top: 52%;
	}
	.tpl6 .dmbutton {
		margin: 67px 5px 20px 5px;
	}
	.price-grid {
		width: 48%;
		margin: 0 .3em;
	}
	.flex-control-nav {
		top: 14%;
	}
	.book-form {
		height: 111px;
	}
	.textbox h4 {
		margin-top: 3em;
	}
}
@media(max-width:640px){
	.agileits-banner-info h4 {
		font-size: 2em;
		letter-spacing: 12px;
	}
	.agileits-banner-info h3 {
		font-size: 13px;
	}
	.agileits-banner-info p {
		letter-spacing: 6px;
		font-size: .7em;
	}
	.agileits_w3layouts_more a {
		font-size: 11px;
		margin-top: 1.3em;
		padding: 5px 15px;
	}
	.callbacks_tabs a:after {
		height: 9px;
		width: 9px;
	}
	.callbacks_tabs li {
		margin: 0px 5px;
	}
	.callbacks_tabs {
		top: 49.5%;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 280px;
	}
	.agileits-banner-info {
		margin-top: 1em;
	}
	.thim-click-to-bottom {
		bottom: 6%;
	}
	.contact-bnr-w3-agile ul li i {
		font-size: 15px;
		margin-right: 9px;
	}
	.contact-bnr-w3-agile ul li {
		padding: 10px 9px;
	}
	.modal-content h4 {
		font-size: 22px;
	}
	.modal-content h5 {
		font-size: 20px;
	}
	.modal-content p {
		font-size: 14px;
		line-height: 28px;
	}
	.contact-w3ls, .advantages, .banner-bottom, .w3l-visitors-agile, .plans-section, .team {
		padding: 45px 0px;
	}
	.about-wthree {
		padding: 3em 0 13.5em 0px;
	}
	.w3ls-info-about h4 {
		font-size: 1em;
	}
	.w3ls-info-about {
		padding: 1em 1.9em;
	}
	h3.title-w3-agileits {
		font-size: 1.8em;
	}
	.advantage-block h4 {
		font-size: 18px;
	}
	.tpl6 .dmbutton {
		margin: 62px 5px 20px 5px;
	}
	.price-gd-top h4 {
		top: 12.8em;
	}
}
@media(max-width:600px){
	.thim-click-to-bottom {
		bottom: 5%;
	}
	.book-form-left-w3layouts h2 {
		padding: 10px 0;
		font-size: 12px;
	}
	.fields-w3ls {
		width: 19.5%;
	}
	.book-form p {
		font-size: 10px;
		letter-spacing: 1.5px;
	}
	.book-form {
		height: 106px;
	}
	.book-form form input[type="submit"] {
		height: 106px!important;
	}
	.banner-bottom h3 span {
		font-size: 14px!important;
		letter-spacing: 1px;
	}
	.w3l-slider-img {
		top: 18.5em;
		width: 48%;
	}
	.w3ls-info-about {
		left: 27%;
		width: 73%;
	}
	.about-wthree {
		padding: 2.6em 0 11.4em 0px;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 275px;
	}
	.advantage-block {
		padding: 1.5em 1em;
	}
	.team-Info-agileits {
		padding: 1.1em 0 0 1.9em;
	}
	.team-Info-agileits p {
		margin: .6em 0 .1em;
	}
	.tpl6 .dmbutton {
		margin: 96px 5px 20px 5px;
	}
	.price-gd-top h4 {
		top: 11.8em;
	}
	.w3layouts_work_grid_left {
		width: 80%;
	}
	.w3layouts_work_grid_right {
		padding: 2em 4em 0em;
	}
	section.contact-w3ls h4 {
		font-size: 23px;
	}
	section.contact-w3ls p.contact-agile2 {
		line-height: 15px;
	}
	.textbox h4 {
		margin-top: 5em;
		font-size: 1em;
	}
	.gallery-grid {
		padding: 0;
		float: left;
		width: 50%;
	}
	.textbox h4 {
		margin-top: 3.8em;
	}
}
@media(max-width:568px){
	.callbacks_tabs {
		left: 41.1%;
	}
	.thim-click-to-bottom i {
		height: 33px;
		width: 20px;
		line-height: 32px;
		font-size: 13px;
	}
	.fields-w3ls {
		width: 67%;
		margin: 0em auto 0;
		float: none;
	}
	.book-form {
		height: 285px;
		padding: 1.5em 0 0 0;
	}
	.book-form form input[type="submit"] {
		height: 40px!important;
		margin: 1em 0 0 14.5em;
	}
	.banner-bottom h3 {
		font-size: 11px;
	}
	#ui-datepicker-div {
		width: 215px;
	}
	.w3ls-info-about {
		left: 19.8%;
		width: 80%;
	}
	.advantage-grid {
		width: 85%;
	}
	.team-Info-agileits {
		padding: 0.2em 0 0 1.9em;
	}
	.tpl6 .dmbutton {
		margin: 89px 5px 20px 5px;
	}
	.price-grid {
		width: 100%;
		margin: 0 auto;
	}
	.priceing-table-main {
		width: 51%;
		margin: 0 auto;
	}
	.price-grid:nth-child(1), .price-grid:nth-child(2),.price-grid:nth-child(3) {
		margin-bottom: 1.5em;
	}
	.copy p {
		font-size: 13px;
	}
}
@media(max-width:480px){
	.banner-top .social-bnr-agileits {
		float: none;
		text-align: center;
		margin: 10px 0;
	}
	.search_form {
		top: 89px;
	}
	.search_box:checked~.search_form {
		top: 87px;
	}
	.contact-bnr-w3-agile ul li {
		padding: 10px 20px;
	}
	.navbar-brand {
		font-size: 20px;
	}
	p.logo_w3l_agile_caption {
		letter-spacing: 2.2px;
		line-height: 17px;
	}
	.navbar-toggle .icon-bar {
		width: 19px;
	}
	.navbar-default .navbar-toggle {
		margin-top: 5px!important;
		padding: 7px 8px;
	}
	nav.navbar.navbar-default {
		padding: .58em 0 0em 0;
	}
	.agileits-banner-info h4 {
		font-size: 1.5em;
		letter-spacing: 10px;
	}
	.agileits-banner-info p {
		margin: .5em auto;
		letter-spacing: 4px;
	}
	.agileits-banner-info {
		padding: 2em 0em;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 250px;
	}
	.callbacks_tabs {
		top: 46.5%;
		left: 39.9%;
	}
	.thim-click-to-bottom {
		left: 47.5%;
	}
	.book-form form input[type="submit"] {
		margin: .9em 0 0 11em;
	}
	.banner-bottom h3 {
		letter-spacing: 1.5px;
	}
	.cbp-ig-grid .cbp-ig-title {
		font-size: .7em;
	}
	.cbp-ig-grid .cbp-ig-category {
		font-size: .75em;
	}
	p.about-para-w3ls {
		font-size: 14px;
	}
	.w3ls-info-about {
		left: 0%;
		width: 100%;
		top: 108.5%;
	}
	.about-wthree {
		padding: 2.6em 0 12em 0px;
	}
	.advantage-block p {
		font-size: 14px;
		line-height: 30px;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 360px;
		width: 83%;
		margin: 0 auto;
		float: none;
	}
	.team-Info-agileits {
		padding: 1.5em 0 0 1.9em;
		width: 100%;
		float: none;
	}
	.team-Info-agileits p {
		font-size: 14px;
	}
	.team-Info-agileits span {
		font-size: 11px;
	}
	.team-Info-agileits h4 {
		font-size: 19px;
	}
	.tpl6 .dmbutton {
		margin: 70px 5px 20px 5px;
	}
	.viewbox-button-next, .viewbox-button-prev {
		top: 58%;
	}
	.priceing-table-main {
		width: 61%;
	}
	.price-gd-top h4 {
		top: 12.8em;
		font-size: 1.1em;
	}
	.price-selet h3 {
		font-size: 1.3em;
	}
	.price-selet h3 span {
		font-size: 27px;
	}
	.price-selet a {
		padding: 0.2em 1.5em;
	}
	.flex-control-nav li {
		margin: 9px 0;
	}
	.flex-control-nav {
		top: 13%;
	}
	h3.title-w3-agileits {
		font-size: 1.6em;
	}
	.w3layouts_work_grid_right p {
		font-size: 14px;
		letter-spacing: 0.5px;
		line-height: 30px;
	}
	.w3layouts_work_grid_right h4 {
		font-size: 12px;
	}
	section.contact-w3ls input#name, section.contact-w3ls input#email, section.contact-w3ls input#phone {
		height: 30px;
	}
	section.contact-w3ls button.btn.btn-primary {
		padding: 5px 20px;
	}
	section.contact-w3ls label.contact-p1 {
		font-size: 14px;
		padding-bottom: 2px;
	}
	.contact-w3-agile2, .contact-w3-agile1 {
		width: 100%;
	}
	.copy p {
		font-size: 13px;
		line-height: 29px;
		padding: 10px 20px;
	}
}
@media(max-width:414px){
	.contact-bnr-w3-agile ul li {
		padding: 10px 9px;
	}
	.agileits-banner-info p {
		letter-spacing: 3px;
	}
	.callbacks_tabs {
		left: 38.4%;
	}
	.thim-click-to-bottom {
		bottom: 6%;
	}
	.agileits-banner-info {
		padding: 1.8em 0em;
	}
	.book-form form input[type="submit"] {
		margin: .9em 0 0 8.5em;
	}
	.cbp-ig-grid li {
		width: 100%;
	}
	.cbp-ig-grid li:last-child {
		border-right: none;
	}
	.cbp-ig-grid li {
		border-left: none;
	}
	.cbp-ig-grid li:nth-child(2) {
		border-top: 1px solid #cfdbf3;
		border-right: none;
	}
	.w3l-slider-img {
		top: 19.5em;
		width: 70%;
		left: 3.4em;
	}
	.w3ls-info-about {
		top: 132.5%;
		padding: 1em 1em;
	}
	.about-wthree {
		padding: 2.6em 0 19em 0px;
	}
	.advantage-block {
		padding: 1.5em .8em;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 355px;
		width: 100%;
	}
	.team-Info-agileits {
		padding: 1.5em 0 0 0em;
	}
	.tpl6 .dmbutton {
		margin: 131px 5px 20px 5px;
	}
	.viewbox-button-next {
		right: 2px;
	}
	.viewbox-button-prev {
		left: 2px;
	}
	.priceing-table-main {
		width: 72%;
	}
	.flex-control-nav {
		top: 9%;
		right: 2.5%;
	}
	.w3layouts_work_grid_right {
		padding: 2em 2.5em 0em;
	}
	.w3layouts_work_grid_right h5 {
		font-size: 1em;
		letter-spacing: 1.5px;
	}
	.w3layouts_work_grid_right p:nth-child(4) {
		font-size: 13px;
		letter-spacing: 1px;
	}
	.copy p {
		padding: 10px 21px;
	}
	.contact-bnr-w3-agile ul li {
		width: 100%;
		float: none;
		text-align: center;
	}
	.search_box:checked~.search_form {
		width: 396px;
		padding: 10px 15px;
	}
	.contact-bnr-w3-agile {
		float: none;
	}
	.contact-bnr-w3-agile ul li {
		padding: 7px 0px;
	}
	.search_box:checked~.search_form {
		top: 151px;
	}
	.search_form {
		top: 152px;
	}
	.banner-top .social-bnr-agileits {
		margin: 15px 0 6px;
	}
	.textbox h4 {
		margin-top: 3.1em;
		font-size: .9em;
	}
}
@media(max-width:384px){
	.agileits-banner-info h3 {
		letter-spacing: 5px;
	}
	.agileits-banner-info p {
		letter-spacing: 2px;
	}
	.callbacks_tabs li {
		margin: 0px 4px;
	}
	.search_box:checked~.search_form {
		width: 365px;
	}
	.search_form input[type='search'] {
		width: 250px;
	}
	.search_form input[type='submit'] {
		padding: 6.2px 12px;
	}
	.book-form form input[type="submit"] {
		margin: .9em 0 0 7.3em;
	}
	.cbp-ig-grid .cbp-ig-title {
		font-size: .9em;
	}
	.cbp-ig-grid .cbp-ig-category {
		font-size: .95em;
	}
	.callbacks_tabs {
		top: 44.5%;
	}
	.fields-w3ls {
		width: 75%;
	}
	.w3ls-info-about {
		top: 120.5%;
	}
	.w3ls-info-about p {
		line-height: 1.8em;
		padding: 7px 0;
	}
	.advantage-block p {
		line-height: 28px;
	}
	.priceing-table-main {
		width: 78%;
	}
	h3.title-w3-agileits {
		font-size: 1.5em;
	}
	.w3layouts_work_grid_left_pos {
		top: 14%;
		width: 65%;
	}
	.flex-control-nav {
		top: 7%;
	}
	.advantage-block h4 {
		font-size: 16px;
	}
}
@media(max-width:375px){
	.contact-w3ls, .advantages, .banner-bottom, .w3l-visitors-agile, .plans-section, .team {
		padding: 40px 0px;
	}
	.about-wthree {
		padding: 2.2em 0 18em 0px;
	}
	.tpl6 .dmbutton {
		margin: 116px 5px 20px 5px;
	}
	.priceing-table-main {
		width: 80%;
	}
	.search_box:checked~.search_form {
		width: 357px;
		padding: 10px 10px;
	}
	.navbar-brand {
		font-size: 18px;
	}
	p.logo_w3l_agile_caption {
		letter-spacing: 1.5px;
		line-height: 14px;
	}
	.agileits-banner-info {
		margin-top: .5em;
	}
	.callbacks_tabs {
		top: 41.5%;
	}
	.advantage-block {
		padding: 1.2em .8em;
	}
	.viewbox-button-next, .viewbox-button-prev {
		top: 60%;
		width: 80px;
		height: 80px;
	}
	.flex-control-nav li {
		margin: 8px 0;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 290px;
	}
}
@media(max-width:320px){
	.search_form input[type='search'] {
		width: 190px;
	}
	.search_box:checked~.search_form {
		width: 303px;
	}
	.agileits-banner-info h4 {
		font-size: 1.3em;
		letter-spacing: 8px;
	}
	.agileits-banner-info h3 {
		letter-spacing: 3px;
		font-size: 12px;
	}
	.agileits-banner-info p {
		letter-spacing: 0.4px;
	}
	.agileits_w3layouts_more a {
		margin-top: 1.1em;
	}
	.callbacks_tabs {
		left: 36.4%;
	}
	.w3layouts-banner-top, .w3layouts-banner-top1, .w3layouts-banner-top2 {
		min-height: 230px;
	}
	.thim-click-to-bottom {
		bottom: 5%;
	}
	.book-form form input[type="submit"] {
		margin: .9em 0 0 4.6em;
	}
	.banner-bottom h3 span {
		font-size: 13px!important;
	}
	.w3l-slider-img {
		top: 21.5em;
		width: 76%;
		left: 2em;
	}
	.advantage-block p {
		padding-left: 0.5em;
	}
	.advantage-grid {
		width: 95%;
	}
	.tab1 .team-img-w3-agile, .tab2 .team-img-w3-agile, .tab3 .team-img-w3-agile, .tab4 .team-img-w3-agile {
		min-height: 245px;
	}
	.resp-tab-content {
		padding: 20px;
	}
	.tpl6 .dmbutton {
		margin: 99px 5px 20px 5px;
	}
	.priceing-table-main {
		width: 90%;
	}
	.price-gd-top h4 {
		top: 12.5em;
		font-size: 1.05em;
	}
	h3.title-w3-agileits {
		font-size: 1.4em;
		line-height: 33px;
	}
	.w3layouts_work_grid_right {
		padding: 2em 1.9em 0em;
	}
	.w3layouts_work_grid_left {
		width: 85%;
	}
	.w3layouts_work_grid_left_pos {
		top: 10%;
		width: 72%;
	}
	.flex-control-nav {
		top: 5%;
		right: 0%;
	}
	section.contact-w3ls h4 {
		font-size: 21px;
	}
	section.contact-w3ls p.contact-agile2 {
		font-size: 13px;
	}
	section.contact-w3ls .contact-agileits, .contact-w3-agile1 {
		padding: 15px 17px;
	}
	.gallery-grid {
		padding: 0;
		float: left;
		width: 100%;
	}
	.textbox h4 {
		margin-top: 5.5em;
	}
}
/*--responsive--*/

</style>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblSuccess" runat="server" Text=></asp:Label>

    <div class="banner-top">
        <br />
        <br />
			<div class="social-bnr-agileits">
				<ul class="social-icons3">
								<li><a href="https://www.facebook.com/" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="https://plus.google.com/u/0/" class="fa fa-google-plus icon-border googleplus"> </a></li> 
							</ul>
			</div>
			<div class="contact-bnr-w3-agile">
				<ul>
					<li><i class="fa fa-envelope" aria-hidden="true"></i><a href="mailto:info@example.com">SSTN.COM</a></li>
					<li><i class="fa fa-phone" aria-hidden="true"></i>+88 01677348014</li>	
					
				</ul>
			</div>
			<div class="clearfix"></div>
		</div>
	<div class="w3_navigation">
		<div class="container">
			<nav class="navbar navbar-default">
				<div class="navbar-header navbar-left">
					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<h1><a class="navbar-brand" href="UserHome.aspx">SS <span>TN</span><p class="logo_w3l_agile_caption">Your Dreamy Resort</p></a></h1>
				</div>
				<!-- Collect the nav links, forms, and other content for toggling -->
				<div class="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
					<nav class="menu menu--iris">
						<ul class="nav navbar-nav menu__list">
							<li class="menu__item menu__item--current"><a href="UserHome.aspx" class="menu__link">Explore</a></li>
							<li class="menu__item"><a href="#about" class="menu__link scroll">About</a></li>
							<li class="menu__item"><a href="#team" class="menu__link scroll">Team</a></li>
							<li class="menu__item"><a href="#gallery" class="menu__link scroll">Gallery</a></li>
							<li class="menu__item"><a href="#rooms" class="menu__link scroll">Rooms</a></li>
							<li class="menu__item"><a href="#contact" class="menu__link scroll">Contact Us</a></li>
						</ul>
					</nav>
				</div>
			</nav>

		</div>
	</div>
<!-- //header -->
		<!-- banner -->
	<div id="home" class="w3ls-banner">
		<!-- banner-text -->
		<div class="slider">
			<div class="callbacks_container">
				<ul class="rslides callbacks callbacks1" id="slider4">
					<li>
						<div class="w3layouts-banner-top">

							<div class="container">
								<div class="agileits-banner-info">
								<h4>SSTN HOTEL & RESORT</h4>
									<h3>We know what you love</h3>
										<p>Welcome to our hotels</p>
									<div class="agileits_w3layouts_more menu__item">
				<a href="#" class="menu__link" data-toggle="modal" data-target="#myModal">Learn More</a>
			</div>
								</div>	
							</div>
						</div>
					</li>
					<li>
						<div class="w3layouts-banner-top w3layouts-banner-top1">
							<div class="container">
								<div class="agileits-banner-info">
								<h4>SSTN HOTEL & RESORT</h4>
									<h3>Stay with friends & families</h3>
										<p>Come & enjoy precious moment with us</p>
									<div class="agileits_w3layouts_more menu__item">
				<a href="#" class="menu__link" data-toggle="modal" data-target="#myModal">Learn More</a>
			</div>
								</div>	
							</div>
						</div>
					</li>
					<li>
						<div class="w3layouts-banner-top w3layouts-banner-top2">
							<div class="container">
								<div class="agileits-banner-info">
								<h4>SSTN HOTEL & RESORT</h4>
								<h3>want luxurious vacation?</h3>
										<p>Get accommodation today</p>
									<div class="agileits_w3layouts_more menu__item">
											<a href="#" class="menu__link" data-toggle="modal" data-target="#myModal">Learn More</a>
										</div>
								</div>
							</div>
						</div>
					</li>
				</ul>
			</div>
			<div class="clearfix"> </div>
			<!--banner Slider starts Here-->
		</div>
		    <div class="thim-click-to-bottom">
				<a href="#about" class="scroll">
					<i class="fa fa-long-arrow-down" aria-hidden="true"></i>
				</a>
			</div>
	</div>	
	<!-- //banner --> 
<!--//Header-->
<!-- //Modal1 -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog">
						<!-- Modal1 -->
							<div class="modal-dialog">
							<!-- Modal content-->
								<div class="modal-content">
									<div class="modal-header">
										<button type="button" class="close" data-dismiss="modal">&times;</button>
										<h4>SSTN <span>HOTEL & RESORT</span></h4>
										<img src="pic/1.jpg" alt=" " class="img-responsive">
										<h5>We know what you love</h5>
										<p>Providing guests unique and enchanting views from their rooms with its exceptional amenities, makes Star Hotel one of bests in its kind.Try our food menu, awesome services and friendly staff while you are here.</p>
									</div>
								</div>
							</div>
						</div>
<!-- //Modal1 -->
<div id="availability-agileits">
<div class="col-md-12 book-form-left-w3layouts">
	<a href="RoomHome.aspx"><h2>ROOM RESERVATION</h2></a>
</div>

			<div class="clearfix"> </div>
</div>
<!-- banner-bottom -->
	<div class="banner-bottom">
		<div class="container">	
			<div class="agileits_banner_bottom">
				<h3><span>Experience a good stay, enjoy fantastic offers</span> Find our friendly welcoming reception</h3>
			</div>
			<div class="w3ls_banner_bottom_grids">
				<ul class="cbp-ig-grid">
					<li>
						<div class="w3_grid_effect">
							<span class="cbp-ig-icon w3_road"></span>
							<h4 class="cbp-ig-title">MASTER BEDROOMS</h4>
							<span class="cbp-ig-category">SSTN HOTEL & RESORT</span>
						</div>
					</li>
					<li>
						<div class="w3_grid_effect">
							<span class="cbp-ig-icon w3_cube"></span>
							<h4 class="cbp-ig-title">SEA VIEW BALCONY</h4>
							<span class="cbp-ig-category"> SSTN HOTEL & RESORT</span>
						</div>
					</li>
					<li>
						<div class="w3_grid_effect">
							<span class="cbp-ig-icon w3_users"></span>
							<h4 class="cbp-ig-title">LARGE CAFE</h4>
							<span class="cbp-ig-category">SSTN HOTEL & RESORT</span>
						</div>
					</li>
					<li>
						<div class="w3_grid_effect">
							<span class="cbp-ig-icon w3_ticket"></span>
							<h4 class="cbp-ig-title">WIFI COVERAGE</h4>
							<span class="cbp-ig-category">SSTN HOTEL & RESORT</span>
						</div>
					</li>
				</ul>
			</div>
		</div>
	</div>
<!-- //banner-bottom -->
<!-- /about -->
 	<div class="about-wthree" id="about">
		  <div class="container">
				   <div class="ab-w3l-spa">
                            <h3 class="title-w3-agileits title-black-wthree">About Our SSTN </h3> 
						   <p class="about-para-w3ls">Lorem Ipsum is simply dummy text of the printing and typesetting industry.Sed tempus vestibulum lacus blandit faucibus. Nunc imperdiet, diam nec rhoncus ullamcorper, nisl nulla suscipit ligula, at imperdiet urna</p>
						   <img src="pic/about.jpg" class="img-responsive" alt="Hair Salon">
										<div class="w3l-slider-img">
											<img src="pic/a1.jpg" class="img-responsive" alt="Hair Salon">
										</div>
                                       <div class="w3ls-info-about">
										    <h4>You'll love all the amenities we offer!</h4>
											<p>Enjoy your vacation with Us. </p>
										</div>
		          </div>
		   	<div class="clearfix"> </div>
    </div>
</div>
 	<!-- //about -->
<!--sevices-->
<div class="advantages">
	<div class="container">
		<div class="advantages-main">
				<h3 class="title-w3-agileits">Our Services</h3>
		   <div class="advantage-bottom">
			 <div class="col-md-6 advantage-grid left-w3ls wow bounceInLeft" data-wow-delay="0.3s">
			 	<div class="advantage-block ">
					<i class="fa fa-credit-card" aria-hidden="true"></i>
			 		<h4>Stay First, Pay After! </h4>
			 		<p>Enjoy your vacation</p>
					<p><i class="fa fa-check" aria-hidden="true"></i>Decorated room, proper air conditioned</p>
					<p><i class="fa fa-check" aria-hidden="true"></i>Private balcony</p>
			 		
			 	</div>
			 </div>
			 <div class="col-md-6 advantage-grid right-w3ls wow zoomIn" data-wow-delay="0.3s">
			 	<div class="advantage-block">
					<i class="fa fa-clock-o" aria-hidden="true"></i>
			 		<h4>24 Hour Restaurant</h4>
			 		<p>24 hour food available.</p>
					<p><i class="fa fa-check" aria-hidden="true"></i>24 hours room service</p>
					<p><i class="fa fa-check" aria-hidden="true"></i>24-hour Concierge service</p>
			 	</div>
			 </div>
			<div class="clearfix"> </div>
			</div>
		</div>
	</div>
</div>
<!--//sevices-->
<!-- team -->
<div class="team" id="team">
	<div class="container">
			<h3 class="title-w3-agileits title-black-wthree">Meet Our Team</h3>
			<div id="horizontalTab">
					<ul class="resp-tabs-list">
					<li>
						<img src="pic/teams1.jpg" alt=" " class="img-responsive" />
					</li>
					<li>
						<img src="pic/teams2.jpg" alt=" " class="img-responsive" />
					</li>
					<li>
						<img src="pic/teams3.jpg" alt=" " class="img-responsive" />
					</li>
					<li>
						<img src="pic/teams4.jpg" alt=" " class="img-responsive" />
					</li>
					</ul>
					<div class="resp-tabs-container">
					<div class="tab1">
						<div class="col-md-6 team-img-w3-agile">
						</div>
						<div class="col-md-6 team-Info-agileits">
							<h4>Sayeeda Saima Tulon</h4>
							<span>Manager</span>
							<p>Come to our hotel and give us the opportunity to serve you .</p>
						<div class="social-bnr-agileits footer-icons-agileinfo">
							<ul class="social-icons3">
								<li><a href="https://www.facebook.com/sayeeda.tulon" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="#" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								<li><a href="#" class="fa fa-rss icon-border rss"> </a></li>
							</ul>
						</div>							
						</div>
						<div class="clearfix"> </div>
					</div>
					<div class="tab2">
					<div class="col-md-6 team-img-w3-agile">
						</div>
						<div class="col-md-6 team-Info-agileits">
							<h4>MD Sakif Tahmid</h4>
							<span>Manager</span>
							<p>Come to our hotel and give us the opportunity to serve you .</p>	
						<div class="social-bnr-agileits footer-icons-agileinfo">
							<ul class="social-icons3">
								<li><a href="https://www.facebook.com/sakif.tahmid" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="#" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								<li><a href="#" class="fa fa-rss icon-border rss"> </a></li>
							</ul>
						</div>							
						</div>
						<div class="clearfix"> </div>
					</div>
					<div class="tab3">
						<div class="col-md-6 team-img-w3-agile">
						</div>
						<div class="col-md-6 team-Info-agileits">
							<h4>Md Jesaan Haider</h4>
							<span>Manager</span>
							<p>Come to our hotel and give us the opportunity to serve you .</p>
						<div class="social-bnr-agileits footer-icons-agileinfo">
							<ul class="social-icons3">
								<li><a href="https://www.facebook.com/Jesaan07" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="#" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								<li><a href="#" class="fa fa-rss icon-border rss"> </a></li>
							</ul>
						</div>							
						</div>
						<div class="clearfix"> </div>
					</div>
					<div class="tab4">
					<div class="col-md-6 team-img-w3-agile">
						</div>
						<div class="col-md-6 team-Info-agileits">
							<h4>Nafiz Imtiaz</h4>
							<span>Manager</span>
							<p>Come to our hotel and give us the opportunity to serve you .</p>
						<div class="social-bnr-agileits footer-icons-agileinfo">
							<ul class="social-icons3">
								<li><a href="https://www.facebook.com/dkaras3" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="https://plus.google.com/" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								<li><a href="https://www.instagram.com/" class="fa fa-rss icon-border rss"> </a></li>
							</ul>
						</div>							
						</div>
						<div class="clearfix"> </div>
					</div>
					</div>
			</div>
	</div>
</div>
<!-- //team -->
<!-- Gallery -->
<section class="portfolio-w3ls" id="gallery">
		 <h3 class="title-w3-agileits title-black-wthree">Our Gallery</h3>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g1.jpg" class="swipebox"><img src="pic/g1.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g2.jpg" class="swipebox"><img src="pic/g2.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g3.jpg" class="swipebox"><img src="pic/g3.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g4.jpg" class="swipebox"><img src="pic/g4.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g5.jpg" class="swipebox"><img src="pic/g5.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
					</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g6.jpg" class="swipebox"><img src="pic/g6.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
					   </div>
				   </a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g6.jpg" class="swipebox"><img src="pic/g7.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
					   </div>
				   </a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g6.jpg" class="swipebox"><img src="pic/g8.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
					   </div>
				   </a>
				</div>
					<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g9.jpg" class="swipebox"><img src="pic/g9.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g10.jpg" class="swipebox"><img src="pic/g10.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g4.jpg" class="swipebox"><img src="pic/g4.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="col-md-3 gallery-grid gallery1">
					<a href="pic/g2.jpg" class="swipebox"><img src="pic/g2.jpg" class="img-responsive" alt="/">
						<div class="textbox">
						<h4>SSTN</h4>
							<p><i class="fa fa-picture-o" aria-hidden="true"></i></p>
						</div>
				</a>
				</div>
				<div class="clearfix"> </div>
</section>
<!-- //gallery -->
	 <!-- rooms & rates -->
      <div class="plans-section" id="rooms">
				 <div class="container">
				 <h3 class="title-w3-agileits title-black-wthree">Rooms And Rates</h3>
						<div class="priceing-table-main">
				 <div class="col-md-3 price-grid">
					<div class="price-block agile">
						<div class="price-gd-top">
						<img src="pic/r1.jpg" alt=" " class="img-responsive" />
							<h4>Deluxe Room</h4>
						</div>
						<div class="price-gd-bottom">
							   <div class="price-list">
									<ul>
											<li><i class="fa fa-star" aria-hidden="true"></i></li>
											<li><i class="fa fa-star" aria-hidden="true"></i></li>
											<li><i class="fa fa-star" aria-hidden="true"></i></li>
											<li><i class="fa fa-star" aria-hidden="true"></i></li>
											<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
									
								     </ul>
							</div>
							<div class="price-selet">	
								<h3><span>20000</span>Tk</h3>						
								<a href="UserRoom.aspx?id=6" >Book Now</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-md-3 price-grid ">
					<div class="price-block agile">
						<div class="price-gd-top">
						<img src="pic/r2.jpg" alt=" " class="img-responsive" />
							<h4>Honeymoon suite</h4>
						</div>
						<div class="price-gd-bottom">
							<div class="price-list">
									<ul>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
								</ul>
							</div>
							<div class="price-selet">
								<h3><span>50000</span>TK</h3>
								<a href="UserRoom.aspx?id=7" >Book Now</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-md-3 price-grid lost">
					<div class="price-block agile">
						<div class="price-gd-top">
						<img src="pic/r3.jpg" alt=" " class="img-responsive" />
							<h4>Exclusive suite</h4>
						</div>
						<div class="price-gd-bottom">
							<div class="price-list">
								<ul>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
								</ul>
							</div>
							<div class="price-selet">
								<h3><span>45000</span>TK</h3>
								<a href="UserRoom.aspx?id=8" >Book Now</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-md-3 price-grid wthree lost">
					<div class="price-block agile">
						<div class="price-gd-top ">
							<img src="pic/r4.jpg" alt=" " class="img-responsive" />
							<h4>Single Room</h4>
						</div>
						<div class="price-gd-bottom">
							<div class="price-list">
								<ul>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
									<li><i class="fa fa-star-o" aria-hidden="true"></i></li>
								</ul>
							</div>
							<div class="price-selet">
								<h3><span>5000</span>TK</h3>
								<a href="UserRoom.aspx?id=1" >Book Now</a>
							</div>
						</div>
					</div>
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
	 <!--// rooms & rates -->
  
<!-- contact -->
<section class="contact-w3ls" id="contact">
	<div class="container">
		<div class="col-lg-6 col-md-6 col-sm-6 contact-w3-agile2" data-aos="flip-left">
			<div class="contact-agileits">
				<h4>Send Your Mail </h4>
				<p class="contact-agile2">Know Our Offers</p>
				<div class="control-group form-group">
                        
                            <label class="contact-p1">Full Name:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="FName" runat="server"  Width="200px"></asp:TextBox>
                            <p class="help-block"></p>                     
              </div>	
                <div class="control-group form-group">
                        
                            <label class="contact-p1">Phone Number:</label>
                            <asp:TextBox ID="PNum" runat="server" Width="200px"></asp:TextBox>
                            <p class="help-block"></p>                     
              </div>	
                  <div class="control-group form-group">
                        
                            <label class="contact-p1">Email Address:</label>&nbsp;&nbsp;
                            <asp:TextBox ID="Eadd" runat="server"  Width="200px"></asp:TextBox>
                            <p class="help-block"></p>                     
              </div>	
                <asp:Button ID="btnsend" runat="server" Class="btn btn-default navbar-btn" Text="Send" OnClick="btnsend_Click" />
				
			</div>
		</div>
		<div class="col-lg-6 col-md-6 col-sm-6 contact-w3-agile1" data-aos="flip-right">
			<h4>Connect With Us</h4>
			<p class="contact-agile1"><strong>Phone :</strong>+88 01677348014</p>
			<p class="contact-agile1"><strong>Email :</strong> <a href="mailto:name@example.com">SSTN.COM</a></p>
			<p class="contact-agile1"><strong>Address :</strong> Dhaka, Bangladesh</p>
																
			<div class="social-bnr-agileits footer-icons-agileinfo">
				<ul class="social-icons3">
								<li><a href="https://www.facebook.com" class="fa fa-facebook icon-border facebook"> </a></li>
								<li><a href="https://twitter.com/" class="fa fa-twitter icon-border twitter"> </a></li>
								<li><a href="https://plus.google.com/discover" class="fa fa-google-plus icon-border googleplus"> </a></li> 
								
							</ul>
			</div>
			<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1825.7703494622558!2d90.40579115809898!3d23.763752820450545!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3755c77decb5f845%3A0xc2eadd2f3b867792!2sAhsanullah+University+of+Science+and+Technology!5e0!3m2!1sen!2sbd!4v1542253718961" width="400" height="300" frameborder="0" style="border:0" allowfullscreen></iframe>" >
		</div>
		<div class="clearfix"></div>
	</div>
</section>


<!-- /contact -->
			<div class="copy">
		        <p>© All Rights Reserved | Design by <a href="hoome.aspx">Sayeeda saima tulon</a> </p>
		    </div>
<!--/footer -->

<!-- js -->
<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
<!-- contact form -->
<script src="js/jqBootstrapValidation.js"></script>

<!-- /contact form -->	
<!-- Calendar -->
		<script src="js/jquery-ui.js"></script>
		<script>
				$(function() {
				$( "#datepicker,#datepicker1,#datepicker2,#datepicker3" ).datepicker();
				});
		</script>
<!-- //Calendar -->
<!-- gallery popup -->
<link rel="stylesheet" href="css/swipebox.css">
				<script src="js/jquery.swipebox.min.js"></script> 
					<script type="text/javascript">
						jQuery(function($) {
							$(".swipebox").swipebox();
						});
					</script>
<!-- //gallery popup -->
<!-- start-smoth-scrolling -->
<script type="text/javascript" src="js/move-top.js"></script>
<script type="text/javascript" src="js/easing.js"></script>
<script type="text/javascript">
	jQuery(document).ready(function($) {
		$(".scroll").click(function(event){		
			event.preventDefault();
			$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
		});
	});
</script>
<!-- start-smoth-scrolling -->
<!-- flexSlider -->
				<script defer src="js/jquery.flexslider.js"></script>
				<script type="text/javascript">
				$(window).load(function(){
				  $('.flexslider').flexslider({
					animation: "slide",
					start: function(slider){
					  $('body').removeClass('loading');
					}
				  });
				});
			  </script>
			<!-- //flexSlider -->
<script src="js/responsiveslides.min.js"></script>
			<script>
						// You can also use "$(window).load(function() {"
						$(function () {
						  // Slideshow 4
						  $("#slider4").responsiveSlides({
							auto: true,
							pager:true,
							nav:false,
							speed: 500,
							namespace: "callbacks",
							before: function () {
							  $('.events').append("<li>before event fired.</li>");
							},
							after: function () {
							  $('.events').append("<li>after event fired.</li>");
							}
						  });
					
						});
			</script>
		<!--search-bar-->
		<script src="js/main.js"></script>	
<!--//search-bar-->
<!--tabs-->
<script src="js/easy-responsive-tabs.js"></script>
<script>
$(document).ready(function () {
$('#horizontalTab').easyResponsiveTabs({
type: 'default', //Types: default, vertical, accordion           
width: 'auto', //auto or any width like 600px
fit: true,   // 100% fit in a container
closed: 'accordion', // Start closed if in accordion view
activate: function(event) { // Callback function if tab is switched
var $tab = $(this);
var $info = $('#tabInfo');
var $name = $('span', $info);
$name.text($tab.text());
$info.show();
}
});
$('#verticalTab').easyResponsiveTabs({
type: 'vertical',
width: 'auto',
fit: true
});
});
</script>
<!--//tabs-->
<!-- smooth scrolling -->
	<script type="text/javascript">
		$(document).ready(function() {
		/*
			var defaults = {
			containerID: 'toTop', // fading element id
			containerHoverID: 'toTopHover', // fading element hover id
			scrollSpeed: 1200,
			easingType: 'linear' 
			};
		*/								
		$().UItoTop({ easingType: 'easeOutQuart' });
		});
	</script>
	
	<div class="arr-w3ls">
	<a href="#home" id="toTop" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>
	</div>
<!-- //smooth scrolling -->
<script type="text/javascript" src="js/bootstrap-3.1.1.min.js"></script>
</asp:Content>

