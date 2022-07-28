using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public GameController gameController;

    public GameObject fullMoon;
    public GameObject newMoon;

    Text moveNo;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        moveNo = gameObject.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResult ()
    {
        moveNo.text = PlayerInput.moves.ToString() + ".";

        for (int i = 0; i < gameController.fm.Count; i++)
        {
            Instantiate(fullMoon, gameObject.transform.transform.GetChild(1));
        }
        for (int i = 0; i < gameController.nm.Count; i++)
        {
            Instantiate(newMoon, gameObject.transform.transform.GetChild(1));
        }

    }
}
