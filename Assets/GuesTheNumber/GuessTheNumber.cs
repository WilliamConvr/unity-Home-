
using TMPro;
using UnityEngine; //regle d'import (permet d'utiliser le programme si contre /

public class GuessTheNumber : MonoBehaviour //{} = un bloc pour expliquer ce qu'il y a dans la class
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;
    private object messageInput;

    private void Start()// void = permet de faire un test , ()= fonction et ce qui est a l'interieur ce sont des parametres 
    {
        //messageText.text = "Hello World!";
       
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {

            messageText.text = "Rentre un truc valide chef";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int playerNumber))
        { 
           if(playerNumber == randomNumber)
            {

                messageText.text = "Bravo a ton grand age tu joues a ça";
            }
           else if (playerNumber > randomNumber)
            {
                messageText.text = "plus petit";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "plus grand";
            }
        }
        else
        {
            messageText.text = "Rentre un truc valide chef";
        }
        numberInput.text = "";
    }

    public void ResetGame()
    { 
    
    }

}

//CLIQUE DROIT -> action rapide 