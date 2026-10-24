const botaoadd = document.querySelector('.adicionarend')

const botaorem = document.querySelector('.removerend')

botaoadd.addEventListener('click', function()
{
    let inputs = document.querySelectorAll('.endereco2')

    inputs.forEach(function(input) {
        input.classList.remove('d-none')

        if((input.tagName == 'INPUT' || input.tagName == 'SELECT') && input.id != 'complemento2')
        {
            //PARA O REQUIRED E DIFERENTE POIS ELE E UM ATRIBUTO HTML
            input.setAttribute('required', '')
        }
        
    });
})

botaorem.addEventListener('click', function()
{
    let inputs = document.querySelectorAll('.endereco2')

    inputs.forEach(function(input){
        input.classList.add('d-none')
         // PARA O REQUIRED E DIFERENTE POIS ELE E UM ATRIBUTO HTML
         input.removeAttribute('required')
         
         if(input.tagName == 'INPUT')
         {
                input.value = ''
         }
        else if(input.tagName == 'SELECT')
        {
            input.selectedIndex = 0;
        }
    });
    
})