const express = require('express');
const app = express();
const port = process.env.PORT || 3000;

app.use(express.static(__dirname + '/html'));

// app.get('/', (req, res) => {res.send('Hello World!')});
app.get('/', (req, res) => {res.sendFile(__dirname + '/html/index.htm')});
// app.get('/images/lang-logo.png', (req, res) => {res.sendFile(__dirname + '/html/images/lang-logo.png')});
// app.get('/css/main.css', (req, res) => {res.sendFile(__dirname + '/html/css/main.css')});



//Cau hinh tra ve cac fie tinh co trong thu muc html
app.use(express.static(__dirname + '/html'));

//Cau hinh du lieu gui len server bang phuong thuc POST
app.use(express.json());
app.use(express.urlencoded({ extended: false }));

//router: request/response
app.get("/task2", (req, res) => {res.json(req.query)});
app.post("/task2", (req, res) => {res.json(req.body["salary[value]"])});
app.use((req, res) => {res.status(404).send("Request Not Found")});
app.use((error,req,res,next) => {
    console.error(error);
    res.status(500).send("Server Error")
});
app.listen(port, () => {console.log(`Example app listening at http://localhost:${port}`)});
// app.listen(port, () => {console.log(`Example app listening at http://localhost:${port}`)});