using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    // Is this a mine ?
    public bool mine;
    // different textures 
    public Sprite[] emptyTextures;
    public Sprite mineTexture;
    public static int score;
    public Text scoretext;
    public Text pointtext;
    public GameObject gamepanel;

    // Use this for initialisation
    void Start()
    {
        score = 0;
        // randomly decide if it is a mine or not
        mine = Random.value < SAVESELECTEDTOGGLE.togglevalue;
        // Register in Grid
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Playfield.elements[x, y] = this;
        //test
        // loadTexture(1);
    }
    // load another texture
    public void loadTexture(int adjacentCount)
    {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
        {
            score = score + 1;
            scoretext.text = "Score : " + score.ToString();
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];

        }
    }
    // Is it still covered?
    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }
    void OnMouseUpAsButton()
    {
        // It's a mine
        if (mine)
        {
            // TODO: uncover all mines
            Playfield.uncoverMines();

            // game over
            print("you lose");
            pointtext.text = score.ToString() + "POINTS";
            gamepanel.SetActive(true);
        }
        // It's not a mine
        else
        {
            // TODO: show adjacent mine number
            //loadTexture(...);
            timer.countstart1 = 300;
            timer.countstart2 = 180;
            timer.countstart3 = 120;
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            loadTexture(Playfield.adjacentMines(x, y));
            score--;
            // uncover area without mines
            Playfield.FFuncover(x, y, new bool[Playfield.w, Playfield.h]);
            if (Playfield.isFinished())
                print("you win");

        }
    }

}