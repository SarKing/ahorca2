using System;

public class Pregunta{

    Random rnum = new Random();

    //bool fallo = false;

    private string palabra;
    private string palabraTratada;
    private string censurada;
    private string substituida;


    // singapur significas servilleta salvaremos salieras sacudir sacad sabrian rompecabezas rogo rodeos rindes rezamos retuvo respetamos resolvemos resolucion repitelo rejilla rei recupere radical quemadas procesamos previa presidente presentacion preguntarles preferible praga porte portarte ponganle pondrian pompeyo polonia polar polaco plantado pise pescando perseguimos perseguia perrita permitirse permitiremos percibe pedacito paraste panaderia osas ogros ofenda ocupen observe noten neblina movi monitores modificar microfonos metetelo metete metera metafora mensajeros mejorara marioneta marinas marcial mantendran mandara manchado malta maldigo maine luchen luchara locamente lloran llevate llenado llegaban supiese supermercado sumar sugieren sufra subid 

    private string[] listaPreguntas = "ejecutado dormiremos donante disputa diabetes detengas despreciable desnudos desconocidos desafortunado demandas curado culturas cuidadosamente convertiría contenía constitución conejos conectada comunicarme comerte católica castigar campesinos burdel brazalete beban banana avergüenza aula aterrizó asustas aspectos arruina aprobó apartamentos amén amarga alimentando alimentan alejar ahorros ahogó aduana acerco acelerar vuelas vergonzoso vengarse valdrá vagina usemos trataría trabajes tiramos tardan sustituto suspender suavemente sintiera sellar reúna quedaban quebrado pulmón protesta promoción prestarme poste podra pillar permito pedirá pasadas paramédicos ordinario olvidarás olvidan ocultos muevo muevete muéstreme moverme miligramos mexicanos".Split(' ');
 
    
    public void setNewPalabra(){
        // Nos genera una nueva palabra aleatoria
        // Esta es con acentos/mayusculas
        palabra = listaPreguntas[rnum.Next(0,listaPreguntas.Length)];
        


        palabraTratada = palabra.ToLower();
        char[] arrayPalTratada = palabraTratada.ToCharArray();

        for(int i = 0; i < arrayPalTratada.Length; i++){
            switch (arrayPalTratada[i]){
                
                case 'á':
                    arrayPalTratada[i] = 'a';
                    break;
                case 'é':
                    arrayPalTratada[i] = 'e';
                    break;
                case 'í':
                    arrayPalTratada[i] = 'i';
                    break;
                case 'ó':
                    arrayPalTratada[i] = 'o';
                    break;
                case 'ú':
                    arrayPalTratada[i] = 'u';
                    break;
            }
        }
        palabraTratada = new string(arrayPalTratada);

        // Tambien nos genera la palabra censurada
        censurada = Censura(palabraTratada);
    }

    // Genera la palabra censurada
    private string Censura(string pr){
        string censurada = "";
        for(int i = 0; i < pr.Length; i++){
            censurada += "-";
        }
        
        return censurada;
    }

    public bool Substituir(char letra){

        char[] arrayCensurada = substituida.ToCharArray();

        // true -> acierto
        bool flag = false;

        for(int i = 0; i < palabra.Length; i++){
            if (letra == palabraTratada[i]){
                // arrayCensurada[i] = letra;    
                arrayCensurada[i] = palabra[i];
                flag = true;            
            }
        }

        if(flag == true){
            // Acierto
            substituida = new string(arrayCensurada);
            return true;
        } else {
            // Fallo
            return false;
        }
    }
    public string getPalabra(){
        return palabra;
    }
    public string getPalabraTratada(){
        return palabraTratada;
    }
    public string getCensurada(){
        return censurada;
    }
    public void setCensurada(string censurada){
        this.censurada = censurada;
    }
    public string getSubstituida(){
        return substituida;
    }
    
    public void setSubstituida(string substituida){
        this.substituida = substituida;
    }

}