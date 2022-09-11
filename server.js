
const express = require('express');
const app = express();
const nodemailer = require("nodemailer");

require('dotenv').config();

const PORT = process.env.PORT || 5000;
envEmail = process.env.EMAIL;
pass = process.env.PASS; 

app.use(express.static('public'));
app.use(express.json());

app.get('/', (req, res) => {
    res.sendFile(__dirname + '/public/index.html');
})

app.post('/', (req, res) => {
    const transporter = nodemailer.createTransport({
        service: 'gmail', 
        auth: {
            user: envEmail, 
            pass: pass
        }
    }); 

    console.log("here is what we are getting");
    console.log(req.body); 
    const mailOptions = {
        from: req.body.email, 
        to: envEmail, 
        subject: 'message', 
        text: req.body.message
    }

    transporter.sendMail(mailOptions, (error, info) => {
        if(error){
            console.log(error);
            res.send('error', error); 
        }
        else 
        {
            res.send('success');
        }
    })
} )

app.listen(PORT, ()=> {
    console.log("server running");
})