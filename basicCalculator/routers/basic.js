let express = require('express');
let basicCalRouter = express.Router();

basicCalRouter.get('/', function(req, res) { 
    res.render('basicCal')   
});

module.exports = basicCalRouter;