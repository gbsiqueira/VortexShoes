   const tagimgfun = document.querySelector('.img-funcionario-inserir')

    const inputimgfun = document.querySelector('#fotoinput')

    const btnRemoeverFoto = document.querySelector('#btnRemoverFoto')

    const apagarimg = document.querySelector('#remover_foto')

    inputimgfun.addEventListener('change', function(){

        let img = inputimgfun.files[0]

        tagimgfun.src = URL.createObjectURL(img)

        apagarimg.value = '0'
    })



  btnRemoeverFoto.addEventListener('click', function(){

    tagimgfun.src = '../../assets/img/placeholder-funcionario.png';
    inputimgfun.value = '';
    apagarimg.value = '1';

    console.log(apagarimg.value);
    console.log(btnRemoeverFoto);
    console.log(apagarimg);
});