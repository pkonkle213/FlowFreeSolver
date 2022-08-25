using FlowFreeSolver.Models;
using System;
using System.Collections.Generic;

namespace FlowFreeSolver
{
    public class NewBoard //This will only be viable as a console app. I plan on moving this to a web app to have a more dynamic set up
    {
        List<List<int>> board = new List<List<int>>();
        int _width;
        int _height;

        public List<List<int>> MakeNewBoard()
        {
            Console.Clear();
            _width = Size("Width");
            _height = Size("Height");
            List<Color> spots = GetSpots();
            board = MakeBoard(spots, _height, _width);
            return board;
        }

        public int Size(string side)
        {
            int length = 0;

            while (length == 0)
            {
                Console.Write($"{side}: ");
                string widthString = Console.ReadLine();
                try
                {
                    length = int.Parse(widthString);
                    if (length < 3)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer greater than 3.");
                }
            }

            return length;
        }

        public List<Color> GetSpots()
        {
            Spot start = new Spot();
            Spot end = new Spot();
            List<Color> colors = new List<Color>();
            bool cont = true;

            Console.WriteLine("With (1,1) being the top left most corner");
            Console.WriteLine($"And ({_height},{_width}) being the bottom right most corner,");

            while (cont)
            {
                Color color = new Color();
                int colorCount;
                try
                {
                    colorCount = colors.Count + 1;
                }
                catch // haha I didn't realize I did this. I should definitely have it defined with an exception
                {
                    colorCount = 1;
                }

                start = Prompt("start", colorCount);
                end = Prompt("end", colorCount);

                if (start.X + start.Y + end.X + end.Y == 0)
                {
                    cont = false;
                }
                else
                {
                    color.Start = start;
                    color.End = end;
                    colors.Add(color);
                }
            }

            return colors;
        }

        public Spot Prompt(string text, int colorCount)
        {
            Spot spot = new Spot();

            bool loop = true;

            while (loop)
            {
                Console.Write($"what is the {text}ing coordinate (row, column) for color {colorCount}: ");
                string answerStart = Console.ReadLine();

                try
                {
                    spot = BuildSpot(answerStart);
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an appropriate value");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter an appropriate value");
                }
            }

            return spot;
        }

        public Spot BuildSpot(string answer)
        {
            Spot spot = new Spot();
            string[] answerSplit = answer.Split(",");
            spot.X = int.Parse(answerSplit[0]);
            spot.Y = int.Parse(answerSplit[1]);

            if (spot.X < 0 || spot.X > _width)
            {
                throw new IndexOutOfRangeException();
            }

            if (spot.Y < 0 || spot.Y > _height)
            {
                throw new IndexOutOfRangeException();
            }

            return spot;
        }

        public List<List<int>> MakeBoard(List<Color> spots, int height, int width)
        {
            List<List<int>> newBoard = new List<List<int>>();
            for (int row = 0; row < height; row++)
            {
                List<int> newRow = new List<int>();
                for (int column = 0; column < width; column++)
                {
                    newRow.Add(0);
                }

                newBoard.Add(newRow);
            }

            for (int i = 0; i < spots.Count; i++)
            {
                newBoard[spots[i].Start.X - 1][spots[i].Start.Y - 1] = i + 1;
                newBoard[spots[i].End.X - 1][spots[i].End.Y - 1] = i + 1;
            }

            return newBoard;
        }
    }
}
