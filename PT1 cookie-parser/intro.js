// 1. HTTP 쿠키(웹 쿠키, 브라우저 쿠키)는 서버가 사용자의 웹 브라우저에 전송하는 작은 데이터 조각이다. 
// 브라우저는 그 데이터 조각들을 저장해 놓았다가, 동일한 서버에 재요청 시 저장된 데이터를 함께 전송한다. 
// 쿠키는 두 요청이 동일한 브라우저에서 들어왔는지 아닌지를 판단할 때 주로 사용한다. 
// 이를 이용하면 사용자의 로그인 상태를 유지할 수 있다. 상태가 없는(stateless) HTTP 프로토콜에서 상태 정보를 기억시켜주기 때문.

// 2. 쿠키는 주로 세 가지 목적을 위해 사용된다:

// a. 세션 관리(Session management)
// 서버에 저장해야 할 로그인, 장바구니, 게임 스코어 등의 정보 관리

// b. 개인화(Personalization)
// 사용자 선호(언어 설정), 테마 등의 세팅

// c. 트래킹(Tracking)
// 사용자 행동을 기록하고 분석하는 용도

// 과거엔 클라이언트 측에 정보를 저장할 때 쿠키를 주로 사용했었다. 쿠키를 사용하는게 데이터를 클라이언트 측에 저장할 수 있는 유일한 방법이었을 때는 이 방법이 타당했지만, 
// 지금은 modern storage APIs를 사용해 정보를 저장하는 걸 권장함. The Web Storage API provides mechanisms by which browsers can store key/value pairs, in a much more intuitive fashion than using cookies.


// 3. cookie-parser란 요청(전송)된 쿠키를 쉽게 '추출'할 수 있도록 도와주는 미들웨어다.
// npm i -s cookie-parser

let express = require('express');
let cookieParser = require('cookie-parser');

let app = express();


// express의 req 객체에 cookies 속성이 부여된다
// cookieParser(secret, options) -> Create a new cookie parser middleware function using the given secret and options.
// secret a string or array used for signing cookies. 
// This is optional and if not specified, will not parse(분석하다) signed cookies
// The middleware will parse the Cookie header on the request and expose the cookie data as the property req.cookies and, 
// if a secret was provided, as the property req.signedCookies.
app.use(cookieParser());

app.get('/', function (req, res) {
  // Cookies that have not been signed
  console.log('Cookies: ', req.cookies)

  // Cookies that have been signed
  console.log('Signed Cookies: ', req.signedCookies);
  res.send('Welcome');
});

app.listen(3000, function(){
  console.log('server 3000 is running');
});

//* curl 이용해 쿠키 전달하고 서버를 통해 확인해보기

// 4-1. curl command that sends an HTTP request with two cookies
// 아래 주소로 쿠키를 전달, 파라미터는 “name1=value1; name2=value2” 형태로 구성
// curl http://localhost:3000 --cookie "cookieName1=choco; cookieName2=strawberry1"

// 4-2. CURL 이란? cURL = Client URL, 클라이언트에서 커맨드 라인이나 소스코드로 손쉽게 웹브라우저 처럼 활동할 수 있도록 해주는 기술, 서버와 통신할 수 있는 커맨드 명령어 툴 
// 웹개발에 매우 많이 사용됨, curl의 특징은 다음과 같은 수많은 프로토콜을 지원한다는 장점이 있다. DICT, FILE, FTP, FTPS, Gopher, HTTP, HTTPS, IMAP, IMAPS, LDAP, LDAPS, POP3, POP3S, RTMP, RTSP, SCP, SFTP, SMB, SMBS, SMTP, SMTPS, Telnet, TFTP
// url을 가지고 할 수 있는 것들은 다 가능. 예를 들면, http 프로토콜을 이용해 웹 페이지의 소스를 가져온다거나 파일을 다운받을 수 있다. ftp 프로토콜을 이용해서는 파일을 받을 수 있을 뿐 아니라 올릴 수도 있다. 심지어 SMTP 프로토콜을 이용하면 메일도 보낼 수 있다
// 윈도우 10 1807 이후부터 내장됨

// curl [options...] <url> 형식으로 사용
// option 처리는 GNU getopt 를 사용하므로 하이픈 하나를 붙이는 short 형식의 옵션과 하이픈 두개로 시작되는 long 형식의 options 이 있다. -b, —cookie <name=data>



