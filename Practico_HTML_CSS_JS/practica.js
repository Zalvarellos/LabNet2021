document.addEventListener("DOMContentLoaded", () => {

    function validacionDeCampos() {
        const formulario = document.querySelector('.formulario');

        formulario.addEventListener('submit', (event) => {
            const validarCampos = document.querySelectorAll('.validacionFormulario');
            let estaVacio = false;
    
            validarCampos.forEach(campo => {
                if(campo.value === '') {
                    estaVacio = true;
                    alert(`El campo ${campo.name} esta vacío`);
                }
            });
    
            if(estaVacio) {
                event.preventDefault();
            }
        });
    }

    function limpiarFormulario() {
        const botonReset = document.querySelector('.botonReset');
        
        botonReset.addEventListener('click', () => {
            const campos = document.querySelectorAll('input');

            for(let i=0; i < campos.length; i++) {
                campos[i].value = '';
            }
        });
    }

    validacionDeCampos();
    limpiarFormulario();
});