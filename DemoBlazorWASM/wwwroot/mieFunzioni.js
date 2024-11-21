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