function TocaSom(idElementoAudio) {

    document.querySelector(idElementoAudio).play(); //Seleciona um elemento no meu html
}
const ListaDeTeclas = document.querySelectorAll('.tecla');

for (let i = 0; i < ListaDeTeclas.length; i++) {

    const tecla = ListaDeTeclas[i];
    const instrumento = tecla.classList[1];

    const idAudio = `#som_${instrumento}`;
    console.log(instrumento);

    tecla.onclick = function() {
        TocaSom(idAudio);
    }

    tecla.onkeydown = function() {
        tecla.classList.add('ativa');
    }

    tecla.onkeyup = function() {
        tecla.classList.remove('ativa');
    }
}