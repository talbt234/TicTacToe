using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class TicTacToeManager : MonoBehaviour
{
    bool checker;  //checks whose turn is 
    int PlusOne;  //adds plus one to the winner

    bool isGameOver = false;   //checks if the game is over

    public TextMeshProUGUI btnText1 = null;
    public TextMeshProUGUI btnText2 = null;
    public TextMeshProUGUI btnText3 = null;
    public TextMeshProUGUI btnText4 = null;
    public TextMeshProUGUI btnText5 = null;
    public TextMeshProUGUI btnText6 = null;
    public TextMeshProUGUI btnText7 = null;
    public TextMeshProUGUI btnText8 = null;
    public TextMeshProUGUI btnText9 = null;

    public TextMeshProUGUI btnNewGame = null;
    public TextMeshProUGUI btnResetGame = null;

    public TextMeshProUGUI msgFeeddback = null;

    public TextMeshProUGUI txtPlayerX = null;

    public TextMeshProUGUI txtPlayerO = null;


    public void Score()
    {
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText1.text == "X" && btnText6.text == "X" && btnText7.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string


        }

        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText3.text == "X" && btnText4.text == "X" && btnText9.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            msgFeeddback.text = "Yay! The Winner is Player X";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        // ======================= Player O ==============================

        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText1.text == "O" && btnText6.text == "O" && btnText7.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string


        }

        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText3.text == "O" && btnText4.text == "O" && btnText9.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            msgFeeddback.text = "Yay! The Winner is Player O";
            isGameOver = true;

            //adds the text we have about the player in the game
            PlusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (PlusOne + 1).ToString();  //adds 1 and convert to string
        }

        // Check for a Tie (Draw)
        if (btnText1.text != "" && btnText2.text != "" && btnText3.text != "" &&
            btnText4.text != "" && btnText5.text != "" && btnText6.text != "" &&
            btnText7.text != "" && btnText8.text != "" && btnText9.text != "" &&
            !isGameOver) // Check that there isn't a winner already
        {
            msgFeeddback.text = "It's a Tie!";
            isGameOver = true;
        }
    }

    public void BtnText1Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText1.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player 'X' hasn't played yet so it's his turn
        {
            btnText1.text = "X";  //
            checker = true;  //updates that player 'X' has played

        }
        else           // it's Player 'O' turn
        {
            btnText1.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText2Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText2.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText2.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText3Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText3.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText3.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText4Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText4.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText4.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText5Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText5.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText5.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText6Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText6.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText6.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText7Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText7.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText7.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText8Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText8.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText8.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        Score();
    }

    public void BtnText9Click()
    {
        // Check if the game is over, or if the button is already marked
        if (isGameOver || btnText9.text != "")
        {
            return; // Exit the method and do nothing
        }

        if (checker == false) //Player X hasn't played yet so it's his turn
        {
            btnText9.text = "X";  //
            checker = true;  //updates that player X has played

        }
        else
        {
            btnText9.text = "O";  //it's Player O turn
            checker = false;
        }
        Score();
    }


    public void BtnResetGameClick()  //Resets the game 
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        msgFeeddback.text = "";

        isGameOver = false;  //resets the "Game Over" state
    }

    public void BtnNewGameClick()  //Starts a new game
    {
        BtnResetGameClick();
        txtPlayerX.text = "0";
        txtPlayerO.text = "0";

    }
}
