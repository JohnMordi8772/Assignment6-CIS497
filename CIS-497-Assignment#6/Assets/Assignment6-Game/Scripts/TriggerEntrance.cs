/*
 John Mordi
 Assignment #6
 Checks what the player comes into contact with and performs the appropriate instruction.
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEntrance : MonoBehaviour
{
    private int score = 0, skillPoints = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            text.text = "You win! \nScore: " + score + "\nSkill Points: " + skillPoints;
        }
        if(other.CompareTag("ScoreCollectable"))
        {
            //score += other.gameObject.GetComponent<Collectable>().points;
            score += 2;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("SkillCollectable"))
        {
            //skillPoints += other.gameObject.GetComponent<Collectable>().points; ;
            skillPoints += 1;
            Destroy(other.gameObject);
        }
    }
}
