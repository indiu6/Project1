let express = require('express');
let app = express() ;

app.use(express.static('public'));
app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');



let basicRouter = require('./routers/basic');
app.use('/', basicRouter);



app.listen(3000, function() {
    console.log('Example app listening on port 3000!')
});
