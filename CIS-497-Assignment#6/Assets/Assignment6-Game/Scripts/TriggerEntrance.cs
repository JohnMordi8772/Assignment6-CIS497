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
            text.text = "You win!";
        }
        if(other.CompareTag("ScoreCollectable"))
        {
            score++;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("SkillCollectable"))
        {
            skillPoints++;
            Destroy(other.gameObject);
        }
    }
}
