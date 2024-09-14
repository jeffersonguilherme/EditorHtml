namespace EditorHtml {
    public static class Menu{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
        }

        public static void DrawScreen(){
            Console.Write("+");
            for(int i = 0; i<30; i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int linha = 0; linha <= 10; linha++){
                Console.Write("|");

                for(int i = 0; i<30; i++){
                    Console.Write(" ");
            }

                Console.Write("|");
                Console.Write("\n");
            }
            
                Console.Write("+");
                for(int i = 0; i<30; i++){
                    Console.Write("-");
                }
                Console.Write("+");
                Console.Write("\n");
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
        }
    }
}