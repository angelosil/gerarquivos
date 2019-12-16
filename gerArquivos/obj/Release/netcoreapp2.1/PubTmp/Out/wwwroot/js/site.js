

var firebaseConfig = {
    apiKey: "AIzaSyCN5SuzDlV8EoMw-_DShSttTi8yo5ErEtw",
    authDomain: "gerarquivos-1576111445209.firebaseapp.com",
    databaseURL: "https://gerarquivos-1576111445209.firebaseio.com",
    projectId: "gerarquivos-1576111445209",
    storageBucket: "gerarquivos-1576111445209.appspot.com",
    messagingSenderId: "777740536075",
    appId: "1:777740536075:web:71c00b0b663b6a70d8ba0e"
};

function LoginGoogle(login) {
    try {        


        if (!login) {
            if (!window.localStorage.getItem("accessToken")) {
                location.href = '/Usuario/Login';
                return;
            }
            else {
                return;
            }
        }
        
            firebase.initializeApp(firebaseConfig);

            var provider = new firebase.auth.GoogleAuthProvider();

            firebase.auth().setPersistence(firebase.auth.Auth.Persistence.SESSION).then(function () {

                firebase.auth().signInWithPopup(provider).then(function (result) {
                    var token = result.credential.accessToken;
                    var user = result.user;
                    
                    window.localStorage.setItem("accessToken", token);
                    window.localStorage.setItem("user.email", user.email);

                    location.href = '/Arquivo/Index';
                }).catch(function (error) {
                    var errorCode = error.code;
                    var errorMessage = error.message;
                    var email = error.email;
                    var credential = error.credential;

                    alert("erro" + errorMessage);
                });
            });
        
    }
    catch (e) {
        alert(e);
    }
}

function desconectarGoogle() {
    window.localStorage.clear();
    document.getElementById("loginGoogle").style.display = '';
    document.getElementById("logoutGoogle").style.display = 'none';
    document.getElementById("infoUser").innerHTML = "Entre com seu login do Google";



    firebase.initializeApp(firebaseConfig);
    var provider = new firebase.auth.GoogleAuthProvider();
    firebase.auth().signOut().then(function () {
        window.localStorage.clear();
        document.getElementById("loginGoogle").style.display = '';
        document.getElementById("logoutGoogle").style.display = 'none';
        document.getElementById("infoUser").innerHTML = "Entre com seu login do Google";       
    }).catch(function (error) {
        alert('Erro: ' + error);
    });
}