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

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock1 = new Block(new MatrixCoords(startRow, i));
                Block currBlock2 = new Block(new MatrixCoords(startRow + 1, i));
                Block currBlock3 = new Block(new MatrixCoords(startRow + 2, i));
                GiftBlock currBlock4 = new GiftBlock(new MatrixCoords(startRow + 5, i + 1));
                engine.AddObject(currBlock1);
                engine.AddObject(currBlock2);
                engine.AddObject(currBlock3);
                engine.AddObject(currBlock4);
            }

            for (int i = startCol; i < endCol; i += 5)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 3, i));
                GiftBlock currBlock2 = new GiftBlock(new MatrixCoords(startRow + 4, i + 1));
                engine.AddObject(currBlock);
                engine.AddObject(currBlock2);
            }

            for (int i = 0; i <= WorldRows; i++)
            {
                IndestructibleBlock leftIndBlock = new IndestructibleBlock(new MatrixCoords(i, 0));
                IndestructibleBlock rightIndBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));

                engine.AddObject(leftIndBlock);
                engine.AddObject(rightIndBlock);
            }

            for (int i = 0; i <= WorldCols; i++)
            {
                IndestructibleBlock topIndBlock = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(topIndBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            //Replacing ordinary ball with MeteoriteBall
            //MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1), 3);

            engine.AddObject(theBall);

            //TrailObject trail = new TrailObject(new MatrixCoords(WorldRows / 3, WorldCols / 3), new char[,] { { '.' } }, 5);
            //engine.AddObject(trail);

            //Testing UnstoppableBall and UnpassableBlock
            //Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theUnstopableBall);

            //for (int i = 2; i < WorldCols; i += 8)
            //{
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            //}

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            EngineShootingRacket gameEngine = new EngineShootingRacket(renderer, keyboard, 100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
