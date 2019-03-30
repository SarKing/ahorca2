
using System;

public class Graficos{
    private readonly string[] HANGMANGRAPHICS = {
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


        public void Inicio(){
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

        public void Clear(){
            for(int i = 0; i < 28; i++){
                Console.WriteLine();
            }
        }

        public void Resultado(int fase, string censurada){
            Console.WriteLine(HANGMANGRAPHICS[fase]);
            Console.WriteLine("Palabra: {0}", censurada);
            Console.WriteLine("Escribe una nueva letra...");
        }

        public void Derrota(){
            Clear();
            Console.WriteLine(
                @"
DDD  EEEE FFFF EEEE  AA  TTTTTT EEEE DDD  
D  D E    F    E    A  A   TT   E    D  D 
D  D EEE  FFF  EEE  AAAA   TT   EEE  D  D 
D  D E    F    E    A  A   TT   E    D  D 
DDD  EEEE F    EEEE A  A   TT   EEEE DDD  ");

            Console.WriteLine("\n\n\n\nPon 'n' para empezar una nueva partida");
            if(Convert.ToChar(Console.ReadLine()) == 'n'){
                // Nueva partida
                Principal.setNuevaPartida(true);
            }
        }


        public void Victoria(){
            Clear();
            Console.WriteLine(@"
V     V III  CCC TTTTTT  OOO  RRRR  Y   Y 
V     V  I  C      TT   O   O R   R  Y Y  
 V   V   I  C      TT   O   O RRRR    Y   
  V V    I  C      TT   O   O R R     Y   
   V    III  CCC   TT    OOO  R  RR   Y   ");

            Console.WriteLine("\n\n\n\nPon 'n' para empezar una nueva partida");
            if (Convert.ToChar(Console.ReadLine()) == 'n')
            {
                // Nueva partida
                Principal.setNuevaPartida(true);
                Clear();
            }
        }
}