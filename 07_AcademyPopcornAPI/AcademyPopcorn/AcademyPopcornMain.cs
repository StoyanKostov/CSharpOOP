using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            // init Blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    Block currBlock = new Block(new MatrixCoords(startRow, i));

            //    engine.AddObject(currBlock);
            //}

            // init Ball
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(theBall);

            // init Racket
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);

            // Task 1   ->    Init Frame (Walls, Cieling)
            for (int col = 0; col < WorldCols; col++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(startRow - 1, col))); // Cieling
            }

            for (int row = startRow; row < WorldRows; row++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, 0))); // Left Wall
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, endCol + 1))); // Right Wall
            }

            // Task 5 -> Init TrailObject and test it
            //engine.AddObject(new TrailObject(new MatrixCoords(5, 12), 5));

            // Task 6 and 7 - > MeteorBall with trail
            //engine.AddObject(new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1)));

            // Task 8 and 9 - > Implement an UnstoppableBall and an UnpassableBlock
            engine.AddObject(new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1)));
            for (int i = startCol; i < endCol; i++)
            {
                UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }

            // task 10 -> ExplodingBlock
            for (int i = startCol; i < endCol / 2; i++)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 2, i));
                engine.AddObject(currBlock);
            }

            // Task 11 - 12
            for (int i = startCol; i < endCol / 2; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 4, i));
                engine.AddObject(currBlock);
            }

        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 150);
            //ShootingRocketEngine gameEngine = new ShootingRocketEngine(renderer, keyboard, 150);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            // Shooting rocket
            //keyboard.OnActionPressed += (sender, eventInfo) =>
            //{
            //    gameEngine.ShootPlayerRacket();
            //};

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
