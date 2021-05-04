function validarNombre() {
    var nombre;
    var apellido;
  
    // Get the value of the input field with id="numb"
    nombre = document.getElementById("nombre").value;
    apellido = document.getElementById("apellido").value;
    form = document.getElementById("formulario");
  
    // If x is Not a Number or less than one or greater than 10
    if((apellido == null || apellido == '') && (nombre == null || nombre == '')) {
        alert("Ingrese un nombre y apellido"); 
        form.reset();
    }
    else if (nombre == null || nombre == '') {
        alert("Ingrese un nombre");   
        form.reset(); 
    }
    else if(apellido == null || apellido == '') {
        alert("Ingrese un apellido");
        form.reset();   
    }


    
}

function limpiarFormulario() {
    document.getElementById(form).reset();
  }