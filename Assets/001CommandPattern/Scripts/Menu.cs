using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Transform menuPanel;
    public Text forwardText;
    public Text backwordText;
    public Text jumpText;

    Event keyEvent;
    Text buttonText;
    KeyCode newKey;

    bool waitingForKey;

    private void Start()
    {
        menuPanel.gameObject.SetActive(false);
        waitingForKey = false;

        if (forwardText)
            forwardText.text = CommandManager.Instance.RIGHT.ToString();
        if (backwordText)
            backwordText.text = CommandManager.Instance.LEFT.ToString();
        if (jumpText)
            jumpText.text = CommandManager.Instance.JUMP.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(true);
            Subject.Instance.Notify(CustomEvent.OPENTITLE);
        }
            
        else if (Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(false);
            Subject.Instance.Notify(CustomEvent.CLOSETITLE);
        }
            
    }

    private void OnGUI()
    {
        keyEvent = Event.current;
        if(keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string keyName)
    {
        if (!waitingForKey)
            StartCoroutine(AssignKey(keyName));
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while (!keyEvent.isKey)
            yield return null;
    }

    public IEnumerator AssignKey(string keyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        switch(keyName)
        {
            case "forward":
                CommandManager.Instance.RIGHT = newKey;
                buttonText.text = CommandManager.Instance.RIGHT.ToString();
                break;
            case "backward":
                CommandManager.Instance.LEFT = newKey;
                buttonText.text = CommandManager.Instance.LEFT.ToString();
                break; 
            case "jump":
                CommandManager.Instance.JUMP = newKey;
                buttonText.text = CommandManager.Instance.JUMP.ToString();
                break;
        }
    }
}
