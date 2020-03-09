// JavaScript Document

/*
document.writeln("Hola mundo");
var numero = 10;
var texto ="Ésto es una variable string";
var float = 20.4;
var ARREGLO = [2,6,4,4]; //En JS no se puede definir el tamaño de un arreglo; solamente sus elementos.

*/

//parseInt() //La función la cambia a un entero
//prompt() //Pop up.


//------------IF---------------//

/*

if(nota>60)
    {
        document.writeln(nombre+" Estás aprobado");
    }
else{
    if(nota<20)
        {
            document.writeln("Estás reprobadísimo bro");
        }
    else{
            document.writeln(nombre+"Estás reprobado");

    }
}

*/

//---------SWTICH------------// 

/*

var valor = parseInt(prompt('Ingresar un valor del 1-5:'));

switch(valor)
{    
    case 1:
        document.write('1');
        break;
    case 2:
        document.write('2');
        break;
    case 3:
        document.write('3');
        break;
    case 4:
        document.write('4');
        break;
    case 5:
        document.write('5');
        break;
    default:
        document.write('Ingresar un numero válido');
}

*/

//-----------------for-----------//
/*
var f;
for(f=1;f<=10;f++)
{
    document.write(f+' ');
}
*/
//------------while-------------//
/*
var numero2 = 0;

while(numero2<=100)
    {
        document.write(numero);
        document.write('<br>');
        numero+=1;
    }
*/

//------------Do While---------------//
/*
do
{
    var valor = prompt('Introducir valor del 0 al 999:');
    
    if(valor<10)
        {
            document.write('el valor tiene 1 dígito.')
        }
    else
    {
        if(valor< 100)
            {
                document.write('el valor tiene 2 dígitos.');
            }
        else
            {
                document.write('el valor tiene 3 dígitos.');
            }
    }
    
    
    
}while(valor!=0);
*/


//--------------Funciones-----------//
/*
function Suma(num1,num2,num3)
{
    document.write(num1+num2*num3);
}
 Suma(4,6,50);
 */

//----------------FORUMLARIOS---------------//

(function ()
{
    var formulario = document.getElementsByName('Formulario')[0];
    var elementos = formulario.elements;
    var boton = document.getElementById('btn');
    
    var validarNombre = function(e)
    {
        if(formulario.nombre.value ==0)
            {
                alert("Completa el campo del nombre");
                e.preventDefault();
            }
    }
    
    var validarRadio = function(e)
    {
        if(formulario.genero[0].checked == true || formulario.genero[1].checked == true)
        {
                
        }
        else
        {
         alert("Seleccionar un genero");
            e.preventDefault();
        }
    }
 
    var validarTerminos = function(e)
    {
        if(formulario.terminos.checked == false)
            {
                alert("Aceptar términos y condiciones");
                e.preventDefault();
            }
    }
    
})

