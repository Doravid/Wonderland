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

    public int curButton, Buttons;
    
    [SerializeField]
    public bool running = false;

    public int currButtonPress = 0;
    public bool hasStarted = false;


    public void Start()
    {
        curButton = 0;
        Buttons = 1;
        currentTimer = 1;
        timer = 3;
        addTurns(Buttons);
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
        if (Input.GetKeyDown(KeyCode.F10))
        {
            startCaptcha();
        }
        if (curButton >= Buttons)
        {
            running = false;
        }

        if (!hasStarted) { return; }
        if (currButtonPress == buttons.Count)
        {
            Debug.Log("Finished Round");
            addTurns(2);
            running = true;
            timer += 1;
            currentTimer *= 0.5f;
            currButtonPress = 0;
            curButton = 0;
            Buttons += 2;

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
    private void addTurns(int length)
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
        buttons[curButton].GetComponent<CreateHighlight>().createHighlight();
        curButton++;
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
            StackSequence.SetActive(true);
        }
    }
}
