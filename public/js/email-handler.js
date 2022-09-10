
let submitBtn = document.getElementById("submit");
submitBtn.addEventListener('click', (e) => {

    let nameInput = document.getElementById('fullName');
    let emailInput = document.getElementById('email');
    let message = document.getElementById('message');
    

    let messagge = {
        name: nameInput.value, 
        emailInput: emailInput.value, 
        message: message.value, 
    }


    console.log(messagge);
})