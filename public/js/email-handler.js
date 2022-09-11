
let submitBtn = document.getElementById("submit");
submitBtn.addEventListener('click', (e) => {
    e.preventDefault()

    let nameInput = document.getElementById('fullName');
    let emailInput = document.getElementById('email');
    let message = document.getElementById('message');
    

    let messagge = {
        name: nameInput.value, 
        emailInput: emailInput.value, 
        message: message.value, 
    }

    console.log(messagge)

    let xhr = new XMLHttpRequest(); 
    xhr.open("POST", '/');
    xhr.setRequestHeader('content-type', 'application/json'); 
    xhr.onload = function(){
        console.log(xhr.responseText); 
        if(xhr.response == 'success'){
            alert('email sent');
        }
        else{
            alert("something went wrong");
        }
    }

    xhr.send(JSON.stringify(messagge))


    console.log(messagge);
})