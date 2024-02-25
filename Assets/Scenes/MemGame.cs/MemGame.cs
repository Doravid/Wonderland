using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemGame : MonoBehaviour
{
    public GameObject StackSequence;
    public GameObject yellowButton, redButton, greenButton, blueButton, child;
    public List<GameObject> buttons = new List<GameObject>();
    [SerializeField]
    public float timer, currentTimer;

    public int numButtons, maxButtons;
    
    [SerializeField]
    public bool running = false;

    public int currButtonPress = 0;
    public bool hasStarted = false;


    public void Start()
    {
        numButtons = 0;
        maxButtons = 4;
        currentTimer = 2;
        timer = 0;
        createGameturn(maxButtons);
    }
    public void startCaptcha()
    {
            hasStarted = true;
            running = true;
        child.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        if (numButtons >= maxButtons)
        {
            running = false;
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            hasStarted = true;
            running = true;
        }

        if (!hasStarted) { return; }
        if (currButtonPress == buttons.Count)
        {
            createGameturn(10);
            running = true;
            currentTimer *= 0.2f;
            currButtonPress = 0;
            numButtons = 0;
            maxButtons += 5;

        }
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0 && running)
        {
            playBack();
            timer += currentTimer;
        }
    }
    private void createGameturn(int length)
    {
        for (int i = 0; i < length; i++)
        {
            float rand = Random.Range(0f, 1f);
            if (rand < 0.25f)
            {
                buttons.Add(yellowButton);
            }
            else if (rand < 0.5f)
            {
                buttons.Add(redButton);
            }
            else if (rand < 0.75f)
            {
                buttons.Add(greenButton);
            }
            else
            {
                buttons.Add(blueButton);
            }
        }
    }
    private void playBack()
    {
        buttons[numButtons].GetComponent<CreateHighlight>().createHighlight();
        numButtons++;
    }
    public void buttonPressed(GameObject obj)
    {
        if (obj.Equals(buttons[currButtonPress]))
        {
            currButtonPress++;
        }
        else
        {
            child.SetActive(false);
            //CODE HERE
            StackSequence.SetActive(true);
        }
    }
}
