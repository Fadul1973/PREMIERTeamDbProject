// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// IIFE


(function () {

    // variables
    var burgerMenu = document.getElementById("burgerMenu");
    var burgerMenuContainer = document.querySelector(".burgerMenuContainer");
    var navBar = document.querySelector("nav");
    var navHeight = navBar.offsetHeight;
    var navBarStatus = false;

    // mobile menu
    if (window.getComputedStyle(burgerMenuContainer).display !== "none") {
        navBar.style.height = "0px";
        burgerMenu.addEventListener("click", function () {
            if (navBarStatus) {
                navBarStatus = false;
                navBar.style.height = "0px";
                burgerMenu.setAttribute("src", "images/whiteMenu.jpg");

            } else {
                navBarStatus = true;
                navBar.style.height = navHeight + "0px";
                burgerMenu.setAttribute("src", "images/whiteClose.jpg");

            }
        })
    }
})();

