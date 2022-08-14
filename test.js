

alert("I've been imported");

window.onscroll = function(){
    var top = window.scrollY || document.documentElement.scrollTop;
    if(top > 100){
        console.log("Top is greater than 100");
    }
    else{
        console.log("Top is less than 100");
    }
};
