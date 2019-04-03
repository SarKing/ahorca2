
using System;

public class Pantalla{
    private static readonly string[] HANGMANGRAPHICS = {
 @"
  +---+
  |   |
      |
      |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
      |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
@"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
@"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
        };


        public static void Inicio(){
            Console.WriteLine(@"
 _                                                         
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/    ");

            Console.WriteLine("Creado por: sarking");
            Console.WriteLine("\n\n\n\n");
        }

        public static void Clear(){
            for(int i = 0; i < 28; i++){
                Console.WriteLine();
            }
        }

        public static void Resultado(int fase, string censurada){
            Console.WriteLine(HANGMANGRAPHICS[fase]);
            Console.WriteLine("Palabra: {0}", censurada);
            Console.WriteLine("Escribe una nueva letra...");
        }

        public static void Derrota(string palabra){
            Clear();
            Console.WriteLine(
                @"
DDD  EEEE FFFF EEEE  AA  TTTTTT EEEE DDD  
D  D E    F    E    A  A   TT   E    D  D 
D  D EEE  FFF  EEE  AAAA   TT   EEE  D  D 
D  D E    F    E    A  A   TT   E    D  D 
DDD  EEEE F    EEEE A  A   TT   EEEE DDD  ");

            Console.WriteLine("\n\nLa palabra era: {0}", palabra);

            bool flag = false;
            do{
                try{
                    if (Convert.ToChar(Console.ReadLine()) == 'n'){
                        // Nueva partida
                        Principal.setNuevaPartida(true);
                        Clear();
                        flag = true;
                    }
                }
                catch (System.Exception){
                    Console.WriteLine("Error, introduce 'n' para emepezar una partida nueva");
                }
            } while (flag == false);
        }


        public static void Victoria(){
            Clear();
            Console.WriteLine(@"
V     V III  CCC TTTTTT  OOO  RRRR  Y   Y 
V     V  I  C      TT   O   O R   R  Y Y  
 V   V   I  C      TT   O   O RRRR    Y   
  V V    I  C      TT   O   O R R     Y   
   V    III  CCC   TT    OOO  R  RR   Y   ");

            Console.WriteLine("\n\n\n\nPon 'n' para empezar una nueva partida");
            bool flag = false;
            do{
                try{
                    if (Convert.ToChar(Console.ReadLine()) == 'n'){
                        // Nueva partida
                        Principal.setNuevaPartida(true);
                        Clear();
                        flag = true;
                    }
                }
                catch (System.Exception){
                    Console.WriteLine("Error, introduce 'n' para emepezar una partida nueva");
                }
            } while (flag == false);
        }
}