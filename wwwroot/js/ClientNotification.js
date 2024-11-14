"user strict"
var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
connection.on("ReceiveMsg", function (msg) {
    var li = document.createElement("li");
    li.textContent = msg;
    document.getElementById("msgList").appendChild(li);
})
//"use strict"; // Corrected "user strict" to "use strict"
//var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

//// Start the connection and log a success or error message
//connection.start()
//    .then(() => console.log("Connected to SignalR Hub"))
//    .catch(err => console.error("Error connecting to SignalR Hub:", err));

//// Set up the listener for receiving messages from the server
//connection.on("ReceiveMsg", function (msg) {
//    var li = document.createElement("li");
//    li.textContent = msg; 
//    document.getElementById("msgList").appendChild(li);
//});
