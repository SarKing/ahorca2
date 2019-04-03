using System;
using System.Collections;

/*
    TODO:

    * Control de errores en la entrada de la letra
    * Rechazar las letras ya dichas
    * Que la consola haga un sonidito cuando falle??
    * Ignorar mayúsculas y acentos
    - Metodos estaticos?
    - https://es.wiktionary.org/wiki/Ap%C3%A9ndice:Palabras_m%C3%A1s_frecuentes_del_espa%C3%B1ol
      En ese link hay un huevo de palabras aleatorias para poner aquí
      como son muchas mi idea es ponerlas en un .txt aparte y elegir una
      pero aún no se como andar con los ficheros asi que lo dejo para un futuro
 */

public class Principal{

    // true -> Nueva partida
    static bool nueva = true;

    public static void Main(){
        
        ArrayList dichas = new ArrayList();
        dichas.Add(' ');

        int fase = 0;

        // Iniciamos con el mensaje de bienvenida
        Pantalla.Clear();
        Pantalla.Inicio();


        // Main loop
        while(true){

            if(nueva == true){
                fase = 0;
                dichas.Clear();
                Pregunta.setNewPalabra();
                Pregunta.setSubstituida(Pregunta.getCensurada());
                Pantalla.Resultado(fase, Pregunta.getCensurada());            
                nueva = false;
            }


            // Hacer el control de fallos try...catch
            char respuesta = ' ';
            // true -> dicha
            bool flag = false;
            try{

                respuesta = Convert.ToChar(Console.ReadLine());
                
                for (int i = 0; i < dichas.Count; i++){
                    if (respuesta == Convert.ToChar(dichas[i])){
                        Console.WriteLine("Ya has dicho la letra {0}, prueba con otra", respuesta);
                        flag = true;
                        break;
                    }                
                }
                dichas.Add(respuesta);
            }
            catch (System.Exception){ 
                Console.WriteLine("Solo puedes meter letras y de una en una.");
                continue;
            }

            if (flag == true){
                flag = false;
                continue;
            }

            if (Pregunta.Substituir(respuesta) == false){
                // Fallo

                Console.WriteLine("\a");

                fase++;

                if(fase >= 6){
                   Pantalla.Derrota(Pregunta.getPalabra()); 
                }
                Pantalla.Clear();
                Pantalla.Resultado(fase, Pregunta.getSubstituida());
                
            }  else {
                // Acierto

                if(Pregunta.getSubstituida() == Pregunta.getPalabra()){
                    Pantalla.Victoria();
                } else {
                    Pantalla.Clear();
                    Pantalla.Resultado(fase, Pregunta.getSubstituida());
                }

            }
        }   

    }

    public static void setNuevaPartida(bool n){
        nueva = n;
    }
    
}
