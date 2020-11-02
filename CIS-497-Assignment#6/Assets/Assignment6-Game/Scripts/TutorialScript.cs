using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public Text tutorialText;

    // Start is called before the first frame update
    private void Awake()
    {
                StartCoroutine(TutorialFuntions());
    }


    IEnumerator TutorialFuntions()
    {
        tutorialText.text = "Welcome to the tutorial please press the left-mouse button to procede through the tutorial.";
        while(!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "As you can see, you are able to look around by moving the mouse.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Moving on, you are able to move by using the W, A, S, and D keys. Mess around with these controls before continuing the tutorial.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "In addition to basic movement, you can also jump by pressing the space bar.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "If you click the P button, it will open up the pause menu where you are able to go back to the main menu or restart a level.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "And lastly, the goal of the game is to gather as many collectables as you can on your way to the large elevated platform without falling.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "The collectables will look either like cylinders or spheres.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Spheres simply increase your score, while cylinders give you points for upgrades if you beat the level after collecting them.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "If you do fall, you will have to go to the pause menu and click restart to try again.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "So have fun, beat this level, and make your way into the actual game.";

        while (!Input.GetButtonDown("Fire1"))
        {
            yield return null;
        }

        tutorialText.text = "";

        yield break;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
