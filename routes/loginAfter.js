let express = require('express');
let router = express.Router();

const app = express();
const path = require('path');

let bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: false }));

app.set('view engine', 'ejs');
app.engine('html', require('ejs').renderFile);
// set path to public folders and view folders
app.set('views', path.join(__dirname, 'views'));
//use public folder for CSS etc.
app.use(express.static(__dirname + '/public'));

router.get('/', function (req, res, next) {
  let email = req.query.email;
  let token = req.query.token;

  //! if token is same, find email in MongoDB then register logic?
  // http://localhost:3000/verify/?email=hewas6@gmail.com&token=abcdefg
  if (token == 'abcdefg') {
    res.render('loginAfterVerify');
  }
});

module.exports = router;
