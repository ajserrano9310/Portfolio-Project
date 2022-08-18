


document.getElementById("left-nav").style.display = "none";
window.onscroll = function(){
    var top = window.scrollY || document.documentElement.scrollTop;
    if(top > 100){
        document.getElementById("left-nav").style.display = "flex";
        console.log("Top is greater than 100");
    }
    else{
        document.getElementById("left-nav").style.display = "none";
        console.log("Top is less than 100");
    }
};
