
function configurarPreview(inputId) {

    const input = document.getElementById(inputId);
    const label = input.labels[0];

    input.addEventListener("change", function () {

        const arquivo = input.files[0];

        if (!arquivo) {
            return;
        }

        // Procura uma imagem que já existe no label
        let imagem = label.querySelector("img");

        // Se não existir, cria uma nova
        if (!imagem) {
            imagem = document.createElement("img");

            if (inputId === "foto_produto") {
                imagem.className = "img-preview";
                imagem.alt = "Imagem Principal";
            } else {
                imagem.className = "img-preview-extra";
                imagem.alt = "Imagem adicional";
            }

            label.prepend(imagem);
        }

        // Atualiza a prévia
        imagem.src = URL.createObjectURL(arquivo);
        imagem.style.display = "block";

        // Esconde os ícones e textos do label
        label.querySelectorAll("i, strong, span").forEach(function (elemento) {
            elemento.style.display = "none";
        });

    });
}

configurarPreview("foto_produto");
configurarPreview("foto_produto2");
configurarPreview("foto_produto3");
configurarPreview("foto_produto4");
