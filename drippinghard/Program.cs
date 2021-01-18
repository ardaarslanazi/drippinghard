using System;
using Raylib_cs;

namespace drippinghard
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1920, 1080, "Gamestate testing");

            Random generator = new Random();
            // string scene = "intro";
            int jackor = 0;
            int kategori = 0;
            int byxor = 0;
            int scene = 0;

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
            Texture2D tshirt1 = Raylib.LoadTexture("body2oye.png");
            Texture2D tshirt2 = Raylib.LoadTexture("body2oyeye.png");
            Texture2D tshirt32 = Raylib.LoadTexture("body1oyeyeye.png");
            Texture2D pant1 = Raylib.LoadTexture("ben2oye.png");
            Texture2D pant2 = Raylib.LoadTexture("ben2oyeye.png");
            Texture2D pant3 = Raylib.LoadTexture("ben3oyeyeye.png");
            Texture2D bakgrund = Raylib.LoadTexture("barbie.png");
            Texture2D bakgrund2 = Raylib.LoadTexture("barbie2.png");
            Texture2D stage = Raylib.LoadTexture("stage.png");
            Texture2D furry = Raylib.LoadTexture("furry.png");
            Texture2D bild = Raylib.LoadTexture("bild.png");

            int insektx = generator.Next(100, 1700);
            int insekty = generator.Next(100, 900);
            int jackorright = generator.Next(1, 4);
            int byxorright = generator.Next(1, 4);
            int byxorright2 = generator.Next(1, 3);
            int jackorright2 = generator.Next(1, 3);

            int velocity = 1;
            int velocityY = 1;



            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                // scen 1 intro
                if (scene == 0)
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawTexture(bakgrund, 0, 0, Color.WHITE);
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
                    // SCENE BYTNING

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = scene + 1;
                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = scene - 1;
                    }



                }
                //scen 2 början av spelet
                if (scene == -1)
                {
                    Raylib.ClearBackground(Color.RED);
                    Raylib.DrawText("What to do in a shark attack?", 150, 150, 25, Color.WHITE);
                    Raylib.DrawText("1-Do not take your eyes off the shark", 150, 200, 25, Color.WHITE);
                    Raylib.DrawText("2-Stay calm and do not make sudden movements", 150, 250, 25, Color.WHITE);
                    Raylib.DrawText("3-If the shark attacks you hit in the gills and eyes", 150, 300, 25, Color.WHITE);



                }
                if (scene == 1)
                {
                    Raylib.ClearBackground(Color.DARKBLUE);
                    Raylib.DrawTexture(bakgrund2, 0, 0, Color.WHITE);
                    Raylib.DrawText("Game screen", 100, 50, 20, Color.WHITE);
                    Raylib.DrawTexture(duckImage, 800, 170, Color.WHITE);
                    Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    Raylib.DrawTexture(ben, 40, -10, Color.WHITE);
                    Raylib.DrawText("1", 300, 300, 40, Color.WHITE);
                    Raylib.DrawText("2", 300, 550, 40, Color.WHITE);
                    Raylib.DrawText("Press < or > to change drip", 670, 100, 40, Color.WHITE);




                    // KLÄDER
                    if (jackor > 4)
                    {
                        jackor = 0;
                    }
                    if (byxor > 4)
                    {
                        byxor = 0;
                    }
                    // BYTA KATEGORIER
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
                        //BYTA KLÄDER
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                        {
                            jackor++;
                        }
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                        {
                            jackor--;
                        }
                    }

                    if (kategori == 2)
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
                    if (byxor == 4)
                    {
                        Raylib.DrawTexture(byxa4, 40, -10, Color.WHITE);
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


                }
                if (jackor == jackorright && byxor == byxorright)
                {
                    Raylib.DrawText("PRESS SPACE TO CONTINUE", 50, 50, 50, Color.BLACK);
                    if (scene == 1 && (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)))
                    {
                        scene = 2;
                        byxor = 0;
                        jackor = 0;
                    }


                }
                // scen 3 
                if (scene == 2)
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawTexture(bakgrund, 0, 0, Color.WHITE);
                    Raylib.DrawTexture(duckImage, 800, 170, Color.WHITE);
                    Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    Raylib.DrawTexture(ben, 40, -10, Color.WHITE);
                    Raylib.DrawText("1", 300, 300, 40, Color.WHITE);
                    Raylib.DrawText("2", 300, 550, 40, Color.WHITE);
                    Raylib.DrawText("da drip were right", 670, 100, 40, Color.BLACK);


                    if (jackor > 3)
                    {
                        jackor = 0;
                    }
                    if (byxor > 3)
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

                    if (kategori == 2)
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
                        Raylib.DrawTexture(pant1, 40, -10, Color.WHITE);

                    }
                    if (byxor == 2)
                    {

                        Raylib.DrawTexture(pant2, 40, -10, Color.WHITE);
                    }
                    if (byxor == 3)
                    {

                        Raylib.DrawTexture(pant3, 40, -10, Color.WHITE);
                    }


                    if (jackor == 1)
                    {
                        Raylib.DrawTexture(tshirt1, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 2)
                    {

                        Raylib.DrawTexture(tshirt2, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (jackor == 3)
                    {
                        Raylib.DrawTexture(tshirt32, 800, 170, Color.WHITE);
                        Raylib.DrawTexture(huvud, 623, 111, Color.WHITE);
                    }
                    if (byxorright <= 1)
                    {
                        byxorright = byxorright + 1;
                    }
                    if (jackor == jackorright2 && byxor == byxorright2)
                    {
                        Raylib.DrawText("PRESS ENTER TO CONTINUE", 50, 50, 50, Color.BLACK);
                        if (scene == 2 && (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)))
                        {
                            scene = 3;
                        }
                    }

                }
                // scen 3
                if (scene == 3)
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawTexture(stage, 0, 0, Color.WHITE);
                    Raylib.DrawTexture(furry, 726, 127, Color.WHITE);
                    Raylib.DrawText("you became a Furry LOL", 650, 100, 50, Color.BLACK);
                }
                if ( scene == 3 && (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)))
                {
                    scene = 4;
                }
                if (scene == 4)
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawTexture(bild, 0, 0, Color.WHITE);

                }








                Raylib.EndDrawing();
            }




        }
    }
}











