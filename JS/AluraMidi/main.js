function TocaSom(SeletorAudio) {

    const elemento = document.querySelector(SeletorAudio).play(); //Seleciona um elemento no meu html

    if (elemento && elemento != null && elemento === 'audio') {

        elemento.play();

    } else {
        console.log('Elemento não encontrado ou Seletor invalido!');
    }


}

const ListaDeTeclas = document.querySelectorAll('.tecla');

for (let i = 0; i < ListaDeTeclas.length; i++) {

    const tecla = ListaDeTeclas[i];
    const instrumento = tecla.classList[1];

    const idAudio = `#som_${instrumento}`;

    tecla.onclick = function() {

        TocaSom(idAudio);
    }

    tecla.onkeydown = function(evento) {

        console.log(evento.code);
        if (evento.code === 'Enter' || evento.code === 'Space') {

            tecla.classList.add('ativa');
        }
    }

    tecla.onkeyup = function() {
        tecla.classList.remove('ativa');
    }
}