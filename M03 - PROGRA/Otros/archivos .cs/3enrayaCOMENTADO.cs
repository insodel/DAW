using System;

namespace ConsoleApp85
{
    class Program
    {
        /// <summary>
        /// Crea un tablero de dimensiones 3x3 y lo rellena con espacios vacíos (' ').
        /// </summary>
        /// <returns>tablero[3,3]</returns>
        static char[,] CrearTablero()
        {
            char[,] tablero = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
            return tablero;
        }
        /// <summary>
        /// Pregunta por output en qué fila se desea posicionar la ficha.
        /// </summary>
        /// <param name="nombreJugador"></param>
        /// <returns></returns>
        static int PreguntarFila(string nombreJugador)
        {
            Console.WriteLine("¿En qué fila desea colocar la ficha?: ");
            int fila = Convert.ToInt32(Console.ReadLine()) - 1 ;
            return fila;
        }
        /// <summary>
        /// Pregunta por output en qué columna se desea posicionar la ficha.
        /// </summary>
        /// <param name="nombreJugador"></param>
        /// <returns></returns>
        static int PreguntarColumna(string nombreJugador)
        {
            Console.WriteLine("¿En qué columna desea colocar la ficha?: ");
            int columna = Convert.ToInt32(Console.ReadLine()) - 1;
            return columna;
        }
        /// <summary>
        /// Comprueba si la casilla está libre, si lo está devolverá true. En caso de no estarlo, devuelve false. Esto se usará después en Main.
        /// </summary>
        /// <param name="nombreJugador"></param>
        /// <returns></returns>
        static bool CasillaVacia(char[,] tablero, int f, int c)
        {
            if (tablero[f, c] == ' ')
                return true;
            else
                return false;
        }
        /// <summary>
        /// Si en la función anterior obtenemos true, colocamos la ficha. Toma como parámetro la ficha del jugador ('O' / 'X')
        /// </summary>
        /// <param name="tablero"></param>
        /// <param name="fichaJugador"></param>
        /// <param name="f"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static char[,] ColocarFicha(char[,] tablero, char fichaJugador, int f, int c)
        {
            tablero[f, c] = fichaJugador;
            return tablero;
        }
        /// <summary>
        /// Tras cada jugada válida, ésta función mostrará por pantalla el tablero actualizado.
        /// </summary>
        /// <param name="tablero"></param>
        /// <returns></returns>
        static char[,] MostrarTableroActualizado(char[,] tablero)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        Console.Write("| " + tablero[i, j] + " ");
                    }
                    else
                        Console.WriteLine("| " + tablero[i, j] + " |");
                }
            }
            return tablero;
        }
        /// <summary>
        /// Tras cada muestra del tablero por pantalla, comprueba si ya hay un ganador. En caso de haberlo, no seguiremos la ejecución del programa.
        /// </summary>
        /// <param name="tablero"></param>
        /// <returns></returns>
        static char DeterminarGanador(char[,] tablero)
        {
            char ganador = ' ';
            if (tablero[0, 0] == tablero[0, 1] && tablero[0, 1] == tablero[0, 2]
                || tablero[0, 0] == tablero[1, 0] && tablero[1, 0] == tablero[2, 0]
                || tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
            {
                ganador = tablero[0, 0];
                return ganador;
            }
                

            else if (tablero[1, 0] == tablero[1, 1] && tablero[1, 1] == tablero[1, 2]
                || tablero[0, 1] == tablero[1, 1] && tablero[1, 1] == tablero[2, 1]
                || tablero[2, 0] == tablero[1, 1] && tablero[1, 1] == tablero[0, 2])
            {
                ganador = tablero[1, 1];
                return ganador;
            }

            else if (tablero[2, 0] == tablero[2, 1] && tablero[2, 1] == tablero[2, 2]
                || tablero[0, 2] == tablero[1, 2] && tablero[1, 2] == tablero[2, 2])
            {
                ganador = tablero[2, 2];
                return ganador;
            }
            
            else
                return ' ';
        }

        static void Main(string[] args)
        {
            char[,] tablero = CrearTablero();
            bool casillaOcupada = false;
            int fila = 0, columna = 0;
            char[] fichasJugadores = { 'O', 'X' };

            Console.WriteLine("Introduzca el nombre del primer jugador (jugará con X):");
            string jugadorUno = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del segundo jugador (jugará con O):");
            string jugadorDos = Console.ReadLine();

            for (int i = 0; i < 9; i++)
            {
                if (i == 0 || i % 2 == 0)
                {          
                    Console.WriteLine("TURNO NÚMERO {0}", i + 1);
                    Console.WriteLine("{0}, es su turno.", jugadorUno);
                    fila = PreguntarFila(jugadorUno);
                    columna = PreguntarColumna(jugadorUno);
                    if (CasillaVacia(tablero, fila, columna) == true)
                    {
                        ColocarFicha(tablero, 'X', fila, columna);
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("La posición elegida ya está ocupada.");
                            fila = PreguntarFila(jugadorUno);
                            columna = PreguntarColumna(jugadorUno);
                        } while (casillaOcupada == false);
                        ColocarFicha(tablero, 'X', fila, columna);
                    }
                    Console.WriteLine();
                    MostrarTableroActualizado(tablero);
                    if (DeterminarGanador(tablero) == 'X')
                    {
                        Console.WriteLine("\n{0} ha ganado la partida.", jugadorUno);
                        break;
                    }   

                    else if (DeterminarGanador(tablero) == 'O')
                    {
                        Console.WriteLine("\n{0} ha ganado la partida.", jugadorDos);
                        break;
                    }              
                }
                else
                {       
                    Console.WriteLine("TURNO NÚMERO {0}", i + 1);
                    Console.WriteLine("{0}, es su turno.", jugadorDos);                                           
                    fila = PreguntarFila(jugadorDos);
                    columna = PreguntarColumna(jugadorDos);
                    if (CasillaVacia(tablero, fila, columna) == true)
                    {
                        ColocarFicha(tablero, 'O', fila, columna);
                        casillaOcupada = true;
                    }
                    else
                    {
                         do
                         {
                            Console.WriteLine("La posición elegida ya está ocupada.");
                            fila = PreguntarFila(jugadorDos);
                            columna = PreguntarColumna(jugadorDos);
                         } while (casillaOcupada == false);
                         ColocarFicha(tablero, 'O', fila, columna);
                    }
                    Console.WriteLine();
                    MostrarTableroActualizado(tablero);
                    if (DeterminarGanador(tablero) == 'X')
                    {
                        Console.WriteLine("\n{0} ha ganado la partida.", jugadorUno);
                        break;
                    }                       

                    else if (DeterminarGanador(tablero) == 'O')
                    {
                        Console.WriteLine("\n{0} ha ganado la partida.", jugadorDos);
                        break;
                    }                       
                }
            }
        }
    }
}