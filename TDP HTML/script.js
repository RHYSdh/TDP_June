function check() {

    userin = document.getElementById("userName");

    if (userin.value.length <= 5) {
        userin.style.background = "#FF9999";
    }
    else {
        userin.style.background = "#99FF99";
    }
}

function sum(type) {
    let no1, no2, no3;
    no1 = document.getElementById("first");
    no2 = document.getElementById("second");

    if (no1.value.length < 1) {
        no1.style.background = "#FF9999";
        no1.focus();
    }
    else if(no2.value.length < 1) {
        no2.style.background = "#FF9999";
        no2.focus();
    }
    else {

        if (type == "+") {
            no3 = parseInt(no1.value) + parseInt(no2.value);
        } else if (type == "-") {
            no3 = parseInt(no1.value) - parseInt(no2.value);
        }
        else if (type == "/") {
            no3 = parseInt(no1.value) / parseInt(no2.value);
        }
        else if (type == "*") {
            no3 = parseInt(no1.value) * parseInt(no2.value);
        }
        document.getElementById("result").value = no3;
    }    
}
var num = 100000;
box = document.getElementById("box");
function mouseMove(){
       
    num = Math.floor(Math.random()*100000);
    box.style.background = "#"+num;
}

function mouseIn(){

    box.style.background = "#000000";
}

function mouseOut(){

    box.style.background = "#FFFFFF";
}


function logMouse(){
    document.getElementById("mouse").value = event.clientX + " x " + event.clientY;
    
    
}

