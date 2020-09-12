const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');

// ES6 standard for destructuring an object
const {check, validationResult} = require('express-validator');

// set up the MongoDB connection
const mongoose = require('mongoose');
mongoose.connect('mongodb://localhost:27017/awesomestore', {
    useNewUrlParser: true,
    useUnifiedTopology: true
});

// get express session
const session = require('express-session');

// set up the model for the order
const Order = mongoose.model('Order', {
    name : String,
    email : String,
    phone : String,
    postcode : String,
    lunch : String,
    tickets : Number,    
    campus : String,
    subTotal : Number,
    tax : Number,
    total : Number
}); 

// set up the model for admin
const Admin = mongoose.model('Admin', {
    username: String,
    password: String
});

// set up variables to use packages
let myApp = express();

// set up session
myApp.use(session({
    secret: 'superrandomsecret',
    resave: false,
    saveUninitialized: true
}));

myApp.use(bodyParser.urlencoded({extended : false}));

// set path to public folders and view folders
myApp.set('views', path.join(__dirname, 'views'));
//use public folder for CSS etc.
myApp.use(express.static(__dirname+'/public'));
myApp.set('view engine', 'ejs');

// set up different routes (pages) of the website

// ------ validation functions --------
// positive number
let positiveNum = /^[1-9][0-9]*$/;
// phone regex for 123-123-1234 or 1231231234
let phoneRegex = /^[0-9]{3}\-?[0-9]{3}\-?[0-9]{4}$/;

// function to check a string using regular expressions
function checkRegex(userInput, regex){
    if(regex.test(userInput)){
        return true;
    } 
    else{
        return false;
    }
}

// custom phone validation function
function customPhoneValidation(value){
    if(!checkRegex(value, phoneRegex)){
        throw new Error("Phone should be in the format xxx-xxx-xxxx");
    }
    return true;
}

/* custom validation for tickets and lunch
    1. tickets should be a number
    2. users has to buy lunch if they buy less than 3 tickets
*/
function customLunchTicketsValidations(value, {req}){ // destructure req
    let tickets = req.body.tickets;
    if(checkRegex(value, positiveNum)){
        throw new Error('Please select tickets. It must be a positive');
    } 
    else{
        tickets = parseInt(tickets);
        if(tickets < 3 && value != 'yes'){
            throw new Error('Lunch is required if you buy less than 3 tickets');
        }
    }
    return true;
}

// home page
myApp.get('/', function(req, res){
    res.render('form'); // no need to add .ejs to the file name
});

myApp.post('/', [
    check('name', 'name is required').notEmpty(),
    check('email', 'email is required').isEmail(),
    check('phone', '').custom(customPhoneValidation),
    check('lunch').custom(customLunchTicketsValidations)

], function(req, res){
    const errors = validationResult(req);
    console.log(errors);
    // fetching
    if(!errors.isEmpty()){
        res.render('form', { // form.ejs
            errors : errors.array()
        })
    } 
    else{ // if no errors
        let name = req.body.name;
        let email = req.body.email;
        let phone = req.body.phone;
        let postcode = req.body.postcode;
        let tickets = req.body.tickets;
        let lunch = req.body.lunch;
        let campus = req.body.campus;

        let subTotal = tickets * 20;
        if(lunch == 'yes'){
            subTotal += 15;
        }
        let tax = subTotal * 0.13;
        let total = subTotal + tax;
        
        // now we need to send all of these fields to 'form.ejs' template 
        // to display the reciept(pageData)
        let pageData = {
            name : name,
            email : email,
            phone : phone,
            postcode : postcode,
            tickets : tickets,
            lunch : lunch,
            campus : campus,
            subTotal : subTotal,
            tax : tax,
            total : total
        }
        // store the order to the db
        let newOrder = new Order(pageData);
        // save the order
        newOrder.save().then(function(){
            console.log('New order created')
        });
        // display the reciept
        res.render('form', pageData);
    }    
});

// all orders page
myApp.get('/allorders', function(req, res){
    // check if the user is logged in
    if(req.session.userLoggedIn){
        Order.find({}).exec(function(err,orders){
            console.log(err);
            res.render('allorders',{orders: orders});
        });
    }
    else{ // otherwise send the user to the login page
        res.redirect('/login');
    }
});

// login page
myApp.get('/login', function(req, res) {
    res.render('login')
});

// login form post
myApp.post('/login', function(req, res) {
    let user = req.body.username;
    let pass = req.body.password;

    Admin.findOne({username: user, password: pass}).exec(function(err, admin) {
        // log any errors
        console.log(`Error: ${err}`);
        console.log(`Admin: ${admin}`);

        if(admin){ // == if admin is not null
            // store username in session and set logged in true
            req.session.username = admin.username;
            req.session.userLoggedIn = true;
            // redirect to the dashboard
            res.redirect('/allorders');
        } 
        else{
            res.render('login', {error: 'Sorry! Cannot login'});
        }        
    });
});

// logout page
myApp.get('/logout', function(req, res){
    req.session.username = '';
    req.session.userLoggedIn = false;
    res.render('login', {error: 'Successfully logged out'});
});

// delete page
myApp.get('/delete/:orderid', function(req, res){
    if(req.session.userLoggedIn){
        //delete
        let id = req.params.orderid;
        console.log(id);
        Order.findByIdAndDelete({_id: id}).exec(function(err, order){
            console.log(`Error: ${err}`);
            console.log(`Order: ${order}`);
            if(order){
                res.render('delete', {message: "Successfully deleted"});
            }
            else{
                res.render('delete', {message: "Sorry, couldn't delete"});
            }
        });
    }
    else{
        res.redirect('/login');
    }
});

// author page
myApp.get('/author', function(req, res){
    res.render('author', {
        name : 'Davneet Chawla', // can pass anything like function, string etc to author.ejs
        studentNumber : '123123'
    });
});

// start the server and listen at a port
myApp.listen(8080);

//tell everything was ok
console.log('Everything executed fine.. website at port 8080....');
