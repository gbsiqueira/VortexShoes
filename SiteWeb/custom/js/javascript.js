const menuicon = document.querySelector('.menu-mobile');

const menufull = document.querySelector('#menu-principal');


menuicon.addEventListener('click', function(){
    menufull.classList.toggle('open')

    document.body.classList.toggle('menu-aberto')
})


window.addEventListener('scroll', function()
{
    if(window.scrollY >= 15)
    {
        document.querySelector('.MENU-NAVEGACAO').classList.add('fixed-scroll')
    }
    else
    {
        document.querySelector('.MENU-NAVEGACAO').classList.remove('fixed-scroll')
    }
})

const spantamanho = document.querySelector('.tamanhospan')  ;

spantamanho.addEventListener('click', function()
{
    spantamanho.classList.toggle('tamanhoclick')
})