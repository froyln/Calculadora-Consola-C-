using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGrandeIdk
{
    internal class Program
    {
        static string[] num0 =
    {
        "   ___   ",
        @"  / _ \  ",
        " | | | | ",
        " | | | | ",
        " | |_| | ",
        @"  \___/  "
    };

        static string[] num1 =
        {
        "  __     ",
        " /_ |    ",
        "  | |    ",
        "  | |    ",
        "  | |    ",
        "  |_|    ",
    };

        static string[] num2 =
        {
        "  ___    ",
        @" |__ \   ",
        "    | |  ",
        "   / /   ",
        "  / /_   ",
        " |____|  ",
    };

        static string[] num3 =
        {
        "  ____   ",
        @" |___ \  ",
        "   __) | ",
        "  |__ <  ",
        "  ___) | ",
        " |____/  "
    };

        static string[] num4 =
        {
        "  _  _   ",
        " | || |  ",
        " | || |_ ",
        " |__   _|",
        "    | |  ",
        "    |_|  "
    };

        static string[] num5 =
        {
        "  _____  ",
        " | ____| ",
        " | |__   ",
        @" |___ \  ",
        "  ___) | ",
        " |____/  "
    };

        static string[] num6 =
        {
        "    __   ",
        "   / /   ",
        "  / /_   ",
        @" | '_ \  ",
        " | (_) | ",
        @"  \___/  "
    };

        static string[] num7 =
        {
        "  ______ ",
        " |____  |",
        "     / / ",
        "    / /  ",
        "   / /   ",
        "  /_/    "
    };

        static string[] num8 =
        {
        "   ___   ",
        @"  / _ \  ",
        " | (_) | ",
        "  > _ <  ",
        " | (_) | ",
        @"  \___/  "
    };

        static string[] num9 =
        {
        "   ___   ",
        @"  / _ \  ",
        " | (_) | ",
        @"  \__, | ",
        "    / /  ",
        "   /_/   "
    };

        static string[] coma =
        {
        "    ",
        "    ",
        "    ",
        "  _ ",
        " ( )",
        " |/ "
    };

        static string[] punto =
        {
        "    ",
        "    ",
        "    ",
        "    ",
        "  _ ",
        " (_)"
    };

        static string[] multiplicacion =
        {
        " __   __ ",
        @" \ \ / / ",
        @"  \ V /  ",
        "   > <   ",
        @"  / . \  ",
        @" /_/ \_\ "
    };

        static string[] restar =
        {
        "         ",
        @"         ",
        @"  ______ ",
        " |______|",
        @"         ",
        @"         "
    };

        static string[] sumar =
        {
        "         ",
        @"    _    ",
        @"  _| |_  ",
        " |_   _| ",
        @"   |_|   ",
        @"         "
    };

        static string[] resultado =
        {
        "         ",
        @"  ______ ",
        @" |______|",
        "  ______ ",
        @" |______|",
        @"         "
    };
        static string[] numVacio = 
        {
            "         ",
            "         ",
            "         ",
            "         ",
            "         ",
            "         ",
        };
        static void Main(string[] args)
        {
            while (true)
            {
                Calculadora();
            }
        }
        static void Calculadora()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("C A L C U L A D O R A");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Instrucciones: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Teclea el primer numero, teclea la operacion y luego teclea el segundo numero, para realizar la operacion teclea enter.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Operaciones disponibles (Presiona la tecla correspondiente): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("S (Sumar), R (Restar), M (Multiplicar), D (Dividir).");

            char operacion = ' ';
            string numero1 = "vacio";
            string numero2 = "vacio";
            char salir = 'N';
            while (salir == 'N')
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.S:
                        operacion = 'S';
                        if (numero1 != "vacio")
                        {
                            salir = 'S';
                            break;
                        }
                        break;
                    case ConsoleKey.R:
                        operacion = 'R';
                        if (numero1 != "vacio")
                        {
                            salir = 'S';
                            break;
                        }
                        break;
                    case ConsoleKey.M:
                        operacion = 'M';
                        if (numero1 != "vacio")
                        {
                            salir = 'S';
                            break;
                        }
                        break;
                    case ConsoleKey.D:
                        operacion = 'D';
                        if (numero1 != "vacio")
                        {
                            salir = 'S';
                            break;
                        }
                        break;
                    case ConsoleKey.D1:
                        if (numero1 == "vacio")
                            numero1 = "1";
                        else
                            numero1 += "1";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D2:
                        if (numero1 == "vacio")
                            numero1 = "2";
                        else
                            numero1 += "2";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D3:
                        if (numero1 == "vacio")
                            numero1 = "3";
                        else
                            numero1 += "3";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D4:
                        if (numero1 == "vacio")
                            numero1 = "4";
                        else
                            numero1 += "4";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D5:
                        if (numero1 == "vacio")
                            numero1 = "5";
                        else
                            numero1 += "5";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D6:
                        if (numero1 == "vacio")
                            numero1 = "6";
                        else
                            numero1 += "6";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D7:
                        if (numero1 == "vacio")
                            numero1 = "7";
                        else
                            numero1 += "7";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D8:
                        if (numero1 == "vacio")
                            numero1 = "8";
                        else
                            numero1 += "8";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D9:
                        if (numero1 == "vacio")
                            numero1 = "9";
                        else
                            numero1 += "9";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.D0:
                        if (numero1 == "vacio")
                            numero1 = "0";
                        else
                            numero1 += "0";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.Decimal:
                        if (numero1 == "vacio")
                        {
                            numero1 = "0";
                        }
                        if (!numero1.Contains('.'))
                        {
                            numero1 += ".";
                        }
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.OemPeriod:
                        if (numero1 == "vacio")
                        {
                            numero1 = "0";
                        }
                        if (!numero1.Contains('.'))
                        {
                            numero1 += ".";
                        }
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.Delete:
                        numero1 = "vacio";
                        VerNumero(numero1, 11, 6);
                        break;
                    case ConsoleKey.Backspace:
                        if (numero1 != "vacio" && numero1.Length > 0)
                        {
                            numero1 = numero1.Substring(0, numero1.Length - 1);
                            if (numero1.Length == 0)
                                numero1 = "vacio";
                            string numeroVacio = "%";
                            VerNumero(numero1 + numeroVacio, 11, 6);
                        }
                        break;
                }
            }
            salir = 'N';
            VerNumero(operacion.ToString(), 0, 9);
            while (salir == 'N')
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        salir = 'S';
                        break;
                    case ConsoleKey.D1:
                        if (numero2 == "vacio")
                            numero2 = "1";
                        else
                            numero2 += "1";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D2:
                        if (numero2 == "vacio")
                            numero2 = "2";
                        else
                            numero2 += "2";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D3:
                        if (numero2 == "vacio")
                            numero2 = "3";
                        else
                            numero2 += "3";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D4:
                        if (numero2 == "vacio")
                            numero2 = "4";
                        else
                            numero2 += "4";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D5:
                        if (numero2 == "vacio")
                            numero2 = "5";
                        else
                            numero2 += "5";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D6:
                        if (numero2 == "vacio")
                            numero2 = "6";
                        else
                            numero2 += "6";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D7:
                        if (numero2 == "vacio")
                            numero2 = "7";
                        else
                            numero2 += "7";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D8:
                        if (numero2 == "vacio")
                            numero2 = "8";
                        else
                            numero2 += "8";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D9:
                        if (numero2 == "vacio")
                            numero2 = "9";
                        else
                            numero2 += "9";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.D0:
                        if (numero2 == "vacio")
                            numero2 = "0";
                        else
                            numero2 += "0";
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.Decimal:
                        if (numero2 == "vacio")
                        {
                            numero2 = "0";
                        }
                        if (!numero2.Contains('.'))
                        {
                            numero2 += ".";
                        }
                        VerNumero(numero2, 11, 12);
                        break;
                    case ConsoleKey.OemPeriod:
                        if (numero2 == "vacio")
                        {
                            numero2 = "0";
                        }
                        if (!numero2.Contains('.'))
                        {
                            numero2 += ".";
                        }
                        VerNumero(numero2, 11, 12);
                        break;
                }
            }
            string linea;
            if (numero1.Length > numero2.Length)
            {
                int lineaSize = numero1.Length * 9 + 6;
                linea = new string('-', lineaSize);
            }
            else
            {
                int lineaSize = numero2.Length * 9 + 11;
                linea = new string('-', lineaSize);
            }
            Console.SetCursorPosition(5, 18);
            Console.WriteLine(linea);
            int val1, val2, resultadoFinal;
            switch (operacion)
            {
                case 'S':
                    int.TryParse(numero1, out val1);
                    int.TryParse(numero2, out val2);
                    resultadoFinal = val1 + val2;
                    VerNumero(resultadoFinal.ToString(), 11, 19);
                    //Console.ReadKey();
                    break;
                case 'M':
                    int.TryParse(numero1, out val1);
                    int.TryParse(numero2, out val2);
                    resultadoFinal = val1 * val2;
                    VerNumero(resultadoFinal.ToString(), 11, 19);
                    //Console.ReadKey();
                    break;
                case 'R':
                    int.TryParse(numero1, out val1);
                    int.TryParse(numero2, out val2);
                    resultadoFinal = val1 - val2;
                    VerNumero(resultadoFinal.ToString(), 11, 19);
                    break;
                case 'D':
                    int.TryParse(numero1, out val1);
                    int.TryParse(numero2, out val2);
                    if (val2 == 0)
                    {
                        VerNumero(0.ToString(), 11, 19);
                    }
                    else
                    {
                        resultadoFinal = val1 / val2;
                        VerNumero(resultadoFinal.ToString(), 11, 19);
                    }
                    break;
            }
            Console.SetCursorPosition(0, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = true;
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
        static void VerNumero(string numero, int posX, int posY)
        {
            for (int i  = 0; i < numero.Length; i++)
            {
                if (posX < Console.WindowWidth - 9)
                {
                    switch (numero[i])
                    {
                        case '0':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num0.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num0[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '1':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num1.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num1[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '2':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num2.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num2[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '3':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num3.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num3[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '4':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num4.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num4[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '5':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num5.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num5[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '6':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num6.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num6[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '7':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num7.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num7[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '8':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num8.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num8[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case '9':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < num9.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(num9[j]);
                            }
                            posX += 9; // Ancho de cada número
                            break;
                        case 'S':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < sumar.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(sumar[j]);
                            }
                            posX += 9; // Ancho de cada operación
                            break;
                        case 'M':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < multiplicacion.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(multiplicacion[j]);
                            }
                            posX += 9; // Ancho de cada operación
                            break;
                        case 'R':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < restar.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(restar[j]);
                            }
                            posX += 9; // Ancho de cada operación
                            break;
                        case 'D':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < resultado.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(resultado[j]);
                            }
                            posX += 9; // Ancho de cada operación
                            break;
                        case '.':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < punto.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(punto[j]);
                            }
                            posX += 9; // Ancho de cada operación
                            break;
                        case '%':
                            Console.SetCursorPosition(posX, posY);
                            for (int j = 0; j < numVacio.Length; j++)
                            {
                                Console.SetCursorPosition(posX, posY + j);
                                Console.WriteLine(numVacio[j]);
                            }
                            posX += 9;
                            break;
                    }
                }
                
            }
        }
    }
}
