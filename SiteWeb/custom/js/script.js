
document.addEventListener('DOMContentLoaded', function () {

    const promocao = document.querySelector('#promocao');
    const desconto_produto = document.querySelector('#desconto_produto');
    const valor_promocao = document.querySelector('#valor_promocao');

    const custo_produto = document.querySelector('#custo_produto');
    const lucro = document.querySelector('#lucro');
    const valor_produto = document.querySelector('#valor_produto');

    // Converte valores do formulário para número
    function pegarNum(input) {
        if (!input || !input.value) return 0;

        let valor = input.value.toString().trim().replace(',', '.');
        let numero = parseFloat(valor);

        return Number.isFinite(numero) ? numero : 0;
    }

    // Formata valores para exibição no formulário
    function formatarValor(valor) {
        return valor.toFixed(2).replace('.', ',');
    }

    // Ativa ou desativa a promoção
    function verificarPromo() {
        if (!promocao || !desconto_produto || !valor_promocao) return;

        if (promocao.value === '1') {
            desconto_produto.disabled = false;
            atualizarPromocao(false);
        } else {
            desconto_produto.disabled = true;
            desconto_produto.value = '';
            valor_promocao.value = '';
        }
    }

    // Calcula o preço normal de venda
    function atualizarValor() {
        if (!custo_produto || !lucro || !valor_produto) return;

        let custo = pegarNum(custo_produto);
        let percentualLucro = pegarNum(lucro);

        if (custo < 0) {
            custo = 0;
            custo_produto.value = '0,00';
        }

        if (percentualLucro < 0) {
            percentualLucro = 0;
            lucro.value = '0';
        }

        if (percentualLucro > 100) {
            percentualLucro = 100;
            lucro.value = '100';
        }

        const valorVenda = custo + (custo * percentualLucro / 100);

        valor_produto.value = formatarValor(valorVenda);

        if (promocao && promocao.value === '1') {
            atualizarPromocao(false);
        }
    }

    // Calcula o preço promocional e valida o desconto
    function atualizarPromocao(mostrarAlerta = false) {
        if (
            !custo_produto ||
            !valor_produto ||
            !desconto_produto ||
            !valor_promocao ||
            !promocao
        ) {
            return;
        }

        const custo = pegarNum(custo_produto);
        const valorVenda = pegarNum(valor_produto);
        let desconto = pegarNum(desconto_produto);

        if (desconto < 0) {
            desconto = 0;
            desconto_produto.value = '0';
        }

        if (desconto > 100) {
            desconto = 100;
            desconto_produto.value = '100';
        }

        if (promocao.value !== '1') {
            valor_promocao.value = '';
            return;
        }

        if (desconto === 0) {
            valor_promocao.value = valor_produto.value;
            return;
        }

        const valorComDesconto =
            valorVenda - (valorVenda * desconto / 100);

        // Impede que o preço promocional fique abaixo do custo
        if (valorComDesconto < custo && custo > 0) {

            if (mostrarAlerta) {
                alert(
                    'O preço com desconto não pode ser menor que o preço de custo!'
                );
            }

            // Limpa o desconto inválido
            desconto_produto.value = '';

            // Restaura o preço normal de venda
            valor_promocao.value = valor_produto.value;

            return;
        }

        // Atualiza o preço promocional quando o desconto é válido
        valor_promocao.value = formatarValor(valorComDesconto);
    }

    // Atualização em tempo real, sem alerta durante a digitação
    if (custo_produto) {
        custo_produto.addEventListener('input', atualizarValor);
    }

    if (lucro) {
        lucro.addEventListener('input', atualizarValor);
    }

    if (valor_produto) {
        valor_produto.addEventListener('input', function () {
            atualizarPromocao(false);
        });
    }

    if (desconto_produto) {
        desconto_produto.addEventListener('input', function () {
            atualizarPromocao(false);
        });
    }

    // Validação quando o usuário termina de preencher o campo
    ['change', 'blur'].forEach(function (evento) {

        if (desconto_produto) {
            desconto_produto.addEventListener(evento, function () {
                atualizarPromocao(true);
            });
        }

        if (custo_produto) {
            custo_produto.addEventListener(evento, function () {
                atualizarPromocao(true);
            });
        }
    });

    // Detecta a ativação ou desativação da promoção
    if (promocao) {
        promocao.addEventListener('change', verificarPromo);
    }

    // Inicialização da página
    verificarPromo();

    if (custo_produto && lucro && valor_produto) {
        atualizarValor();
    }

});
