﻿

window.addEventListener("load", function () {

});

if (typeof observador === 'undefined') {
    const observador = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            //console.log(entry);
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
                //} else { esse else aq faz a classe voltar dps q sair do frame, n achei legal
                //    entry.target.classList.remove('show');
            }
        });
    });

    // Seleciona todos os elementos com a classe "hidden"
    const hiddenElements = document.querySelectorAll('.hidden-below');
    hiddenElements.forEach((element) => observador.observe(element));
    function mostrarDeCimaParaBaixo(divs) {
        for (let i = divs.length - 1; i >= 0; i--) {
            const div = divs[i];
            setTimeout(() => {
                div.style.display = 'block'; // Torna a div visível
                div.style.opacity = 1; // Garante que a opacidade seja visível
            }, (divs.length - i - 1) * 500); // Diferencia o tempo de cada div
        }
    }
}

if (typeof observador === 'undefined') {
    const observador = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            console.log(entry);
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
                //} else {
                //    entry.target.classList.remove('show');
            }
        });
    });

    const hiddenElements = document.querySelectorAll('.hidden-left');
    hiddenElements.forEach((element) => observador.observe(element));
}

if (typeof observador === 'undefined') {
    const observador = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            //console.log(entry);
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
                //} else {
                //    entry.target.classList.remove('show');
            }
        });
    });

    // Seleciona todos os elementos com a classe "hidden"
    const hiddenElements = document.querySelectorAll('.hidden');
    hiddenElements.forEach((element) => observador.observe(element));
}

//o id se refere ao id do elemento html
//esses dois outros valores sao passados por parametro na chamada da funcao e sao mais sobre execucao do 
function animarNumero(id, valorFinal, duracao) {
    let elemento = document.getElementById(id);
    let valorInicial = 0; // Começar sempre do 0
    let comeco = null; // Aguardar até o elemento entrar na tela para iniciar a animação

    function atualizar() {
        if (comeco === null) return; // Espera até que comeco seja definido

        let agora = performance.now();
        let tempoDecorrido = agora - comeco;
        let progresso = tempoDecorrido / duracao;

        if (progresso < 1) {
            let easedProgress = 1 - Math.pow(1 - progresso, 3);  // Função ease-in cúbica
            let valorAtual = valorInicial + easedProgress * (valorFinal - valorInicial);
            elemento.innerText = Math.floor(valorAtual);
            requestAnimationFrame(atualizar);  // Continuar a animação
        } else {
            // Ao completar a animação, garante que o número não ultrapasse o valor final
            elemento.innerText = valorFinal;
        }
    }

    // Usando IntersectionObserver para detectar quando o elemento entra na viewport
    const observer = new IntersectionObserver((entries, observer) => {
        entries.forEach((entry) => {
            if (entry.isIntersecting) {
                if (comeco === null) {
                    comeco = performance.now();  // Marca o tempo de início da animação
                    atualizar();  // Inicia a animação
                }
                observer.unobserve(entry.target);  // Parar de observar o elemento após a animação começar
            }
        });
    }, {
        threshold: 0.2  // Certifica-se de que o elemento está totalmente visível
    });

    // Começa a observar o elemento
    observer.observe(elemento);
}

/*requestAnimationFrame(atualizar);*/

function MostraDivBaixo(id) {
    setTimeout(() => {
        let elemento = document.getElementById(id);
        elemento.classList.add("visible");
    }, 900)
}

function MostraDivBaixoClasse(classe) {
    const all = document.querySelectorAll(`.${classe}`)
    const observer = new IntersectionObserver((all, observer) => {
        all.forEach((elemento) => {
            if (elemento.isIntersecting) {
                setTimeout(() => {
                    elemento.target.classList.add("visible");
                    observer.unobserve(elemento.target)
                }, 830)
            }
        })
    }, {
        threshold: 0.1
    });

    all.forEach((elemento) => {
        observer.observe(elemento);
    });
}


