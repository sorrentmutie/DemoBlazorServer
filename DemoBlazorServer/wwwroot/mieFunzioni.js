window.miaSomma = function (a, b) {
    return a + b;
}

window.miaMoltiplicazione =  (a, b) => {
    const x = a * b;
    console.log(x);
}

window.miaFunzioneSpeciale = (a, b) => {
    DotNet.invokeMethodAsync("DemoBlazorWASM", "CalcolaSommaSpeciale", a, b)
        .then(risultato => console.log(risultato));
}

window.sayHello = (dotNetObject) => {
    console.log(dotNetObject);
    dotNetObject.invokeMethodAsync("SayHello")
        .then(saluto => console.log(saluto));        ;
}


let myModal; 

window.showModal = (id) => {
    console.log("buuuu" + id);
    myModal = new bootstrap.Modal(document.getElementById(id));
    myModal.show();
}


window.hideModal = () => {
    if (myModal) {
        myModal.hide();
    }
}
