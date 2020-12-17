using System;
using Raylib_cs;

namespace drippinghard
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1920, 1080, "Gamestate testing");

            Random generator = new Random();
            string scene = "intro";
            int jackor = 0;
            int kategori = 0;
            int byxor = 0;

            Texture2D duckImage = Raylib.LoadTexture("body1oye.png");
            Texture2D jackan = Raylib.LoadTexture("body1realg.png");
            Texture2D jackan2 = Raylib.LoadTexture("body1realg2.png");
            Texture2D huvud = Raylib.LoadTexture("triangle.png");
            Texture2D ben = Raylib.LoadTexture("ben1oyeye.png");
            Texture2D byxa1 = Raylib.LoadTexture("ben1medbyxa.png");
            Texture2D tshirt3 = Raylib.LoadTexture("body1realg3real.png");
            Texture2D albania = Raylib.LoadTexture("body1albania.png");
            Texture2D adidas = Raylib.LoadTexture("ben1oyeyeabibas.png");
            Texture2D femboy = Raylib.LoadTexture("ben1oyeyefemboy.png");
            Texture2D insekt = Raylib.LoadTexture("insekt.png");
            Texture2D byxa4 = Raylib.LoadTexture("ben1oyeyeye.png");
            int insektx = generator.Next(100, 1700);
            int insekty = generator.Next(100, 900);

            int velocity = 1;
            int velocityY = 1;



            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (scene == "intro")
                {
                    Raylib.ClearBackground(Color.DARKGREEN);
                    Raylib.DrawRectangle(810, 400, 300, 100, Color.WHITE);
                    Raylib.DrawRectangleLines(810, 400, 300, 100, Color.BLACK);
                    Raylib.DrawText("Press SPACE to", 840, 420, 25, Color.BLACK);
                    Raylib.DrawText("Start", 910, 455, 30, Color.BLACK);
                    Raylib.DrawTexture(insekt, insektx, insekty, Color.WHITE);
                    Raylib.DrawRectangle(810, 550, 300, 100, Color.WHITE);
                    Raylib.DrawText("Press Tab for", 840, 570, 25, Color.BLACK);
                    Raylib.DrawText("help", 940, 605, 25, Color.BLACK);

                    insektx += velocity;
                    insekty += velocityY;

                    if (insektx > 1500)
                    {
                        velocity = velocity * -1;

                        System.Console.WriteLine("turn!");
                    }
                    else if (insektx < 0)
                    {
                        velocity = velocity * -1;

                        System.Console.WriteLine("turn!");
                    }
                    if (insekty > 1080)
                    {
                        velocityY = velocityY * -1;
                    }
                    if (insekty < 0)
                    {
                        velocityY = velocityY * -1;
                    }


                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = "game";
                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "help";
                    }



                }
                else if (scene == "game")
                {
                    Raylib.ClearBackground(Color.DARKBLUE);

                    Raylib.DrawText("Game screen", 100, 50, 20, Color.WHITE);
                    Raylib.DrawTexture(duckImage, 800, 170, Color.WHITE);
                    Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    Raylib.DrawTexture(ben, 40, -10, Color.WHITE);
                    Raylib.DrawText("1", 300, 300, 40, Color.WHITE);
                    Raylib.DrawText("2", 300, 550, 40, Color.WHITE);
                    Raylib.DrawText("Press < or > to change drip", 670, 100, 40, Color.WHITE);





                    if (jackor > 4)
                    {
                        jackor = 0;
                    }
                    if (byxor > 4)
                    {
                        byxor = 0;
                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
                    {
                        kategori = 1;

                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
                    {
                        kategori = 2;
                    }
                    if (kategori == 1)
                    {
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                        {
                            jackor++;
                        }
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                        {
                            jackor--;
                        }
                    }


                    else if (kategori == 2)
                    {
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                        {
                            byxor++;
                        }
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                        {
                            byxor--;
                        }

                    }
                    if (byxor == 1)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(byxa1, 40, -10, Color.WHITE);
                    }
                    if (byxor == 2)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(adidas, 40, -10, Color.WHITE);
                    }
                    if (byxor == 3)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(femboy, 40, -10, Color.WHITE);
                    }


                    if (jackor == 1)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawText("din mamma är fet", 200, 50, 20, Color.WHITE);
                        Raylib.DrawTexture(jackan, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 2)
                    {
                        Raylib.DrawTexture(jackan2, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 3)
                    {
                        Raylib.DrawTexture(albania, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 4)
                    {
                        Raylib.DrawTexture(tshirt3, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (byxor == 4)
                        Raylib.DrawTexture(byxa4, 40, -10, Color.WHITE);

                }
                if (scene == "help")
                {
                    Raylib.ClearBackground(Color.RED);
                    Raylib.DrawText("What to do in a shark attack?", 150, 150, 25, Color.WHITE);
                    Raylib.DrawText("1-Do not take your eyes off the shark", 150, 200, 25, Color.WHITE);
                    Raylib.DrawText("2-Stay calm and do not make sudden movements", 150, 250, 25, Color.WHITE);
                    Raylib.DrawText("3-If the shark attacks you hit in the gills and eyes", 150, 300, 25, Color.WHITE);



                }
                if (jackor == 2 && byxor == 3)
                {
                    scene = "game2";
                }


                if (scene == "game2")
                {
                    Console.Clear();
                    Raylib.ClearBackground(Color.RED);

                    Raylib.DrawText("Game screen", 100, 50, 20, Color.WHITE);
                    Raylib.DrawTexture(duckImage, 800, 170, Color.WHITE);
                    Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    Raylib.DrawTexture(ben, 40, -10, Color.WHITE);
                    Raylib.DrawText("1", 300, 300, 40, Color.WHITE);
                    Raylib.DrawText("2", 300, 550, 40, Color.WHITE);
                    Raylib.DrawText("Press < or > to change drip", 670, 100, 40, Color.WHITE);

                    if (byxor == 1)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(byxa1, 40, -10, Color.WHITE);
                    }
                    if (byxor == 2)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(adidas, 40, -10, Color.WHITE);
                    }
                    if (byxor == 3)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawTexture(femboy, 40, -10, Color.WHITE);
                    }


                    if (jackor == 1)
                    {
                        Raylib.ClearBackground(Color.DARKBLUE);
                        Raylib.DrawText("din mamma är fet", 200, 50, 20, Color.WHITE);
                        Raylib.DrawTexture(jackan, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 2)
                    {
                        Raylib.DrawTexture(jackan2, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 3)
                    {
                        Raylib.DrawTexture(albania, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 4)
                    {
                        Raylib.DrawTexture(tshirt3, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (byxor == 4)
                    {
                        Raylib.DrawTexture(byxa4, 40, -10, Color.WHITE);
                    }


                }

            }



            Raylib.EndDrawing();
        }
    }
}









