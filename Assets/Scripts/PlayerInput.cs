using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public static int moves = 1;

    public static List<int> input = new List<int>();

    public GameController gameController;

    public Result result;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerInputCode ()
    {
        List<int> input = new List<int> ();
        foreach (Text text in gameObject.GetComponentsInChildren<Text>())
        {
            if (text.text == "-") {
                input.Add(-1);
                continue;
            }
            input.Add (Convert.ToInt32 (text.text));
        }
        gameController.ValidateInput(input);
        result.ShowResult();
        gameController.SetGameStatus();
        moves += 1;
    }
}
