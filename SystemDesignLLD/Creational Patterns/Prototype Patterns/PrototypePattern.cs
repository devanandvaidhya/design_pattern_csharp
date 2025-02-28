using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.Creational_Patterns.Prototype_Patterns
{

    // achieve the copying of object like game previous state/checkpoint
    public class PrototypePattern
    {

        public  void MainMethod()
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.addGamePeaces(new GamePiece("Red", 1));
            gameBoard.addGamePeaces(new GamePiece("Blue", 5));
            gameBoard.showBoardState();

            //Checkpoint this state
            GameBoard copiedBoard = gameBoard.Clone();

            Console.WriteLine("Copied Board");
            copiedBoard.showBoardState();
        }
    }

    public interface Prototype<T>
    {
        T Clone();
    }

    public class GamePiece : Prototype<GamePiece>
    {
        private string Color { get; set; }
        private int Position { get; set; }


        public string getColor()
        {
            return Color;
        }
        public int getPosition()
        {
            return Position;
        }

        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public void setPosition(int Position)
        {
            this.Position = Position;
        }

        public GamePiece(string Color,int Position) 
        {
            this.Color = Color;
            this.Position = Position;
        }

        public GamePiece Clone()
        {
            return new GamePiece(this.Color, this.Position);
        }

        public string toString()
        {
            return "GamePiece{" +
                  "color='" + Color + '\'' +
                  ", position=" + Position +
                  '}';
        }

    }

    public class GameBoard : Prototype<GameBoard>
    {
        List<GamePiece> Pieces = new List<GamePiece>();

        public void addGamePeaces(GamePiece gamePiece)
        {
            Pieces.Add(gamePiece);
        }

        public List<GamePiece> getPieces()
        {
            return Pieces;
        }

        public void showBoardState()
        {
            foreach (GamePiece piece in Pieces)
            {
                Console.WriteLine(piece.getColor());
                Console.WriteLine(piece.getPosition());
            }
        }

        public GameBoard Clone()
        {
            GameBoard newBoard = new GameBoard();
            foreach (GamePiece piece in Pieces)
            {
                newBoard.addGamePeaces(piece.Clone());
            }
            return newBoard;
        }

    }

}
