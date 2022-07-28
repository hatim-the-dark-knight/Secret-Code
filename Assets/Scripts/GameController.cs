using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameController : MonoBehaviour
{
    public List<int> code = new List<int>();

    public List<int> fm = new List<int>(), nm = new List<int>();


    public GameObject wonPanel;
    public GameObject failPanel;

    // Start is called before the first frame update
    void Start()
    {
        code = GenerateCode(SceneController.difficulty);
    }

    public List<int> GenerateCode(int lvl)
    {
        int num, i = 1;
        code.Insert(0, Random.Range(1, 10));
        while (code.Count != lvl)
        {
            num = Random.Range(0, 10);
            if (!code.Contains (num))
            {
                code.Add(num);
                i += 1;
            }
        }
        string x = "";
        foreach (int k in code)
        {
            x += k.ToString();
        }
        Debug.Log(x);

        return code;
    }

    public void ValidateInput (List<int> input)
    {
        fm.Clear ();
        nm.Clear ();
        Debug.Log("Input: " + input[0].ToString() + input[1].ToString() + input[2].ToString() + input[3].ToString());
        for (int i = 0; i < code.Count; i++)
        {
            for (int j = 0; j < input.Count; j++)
            {
                if (code.ElementAt (i) == input.ElementAt(j))
                {
                    if (i == j)
                    {
                        if (!fm.Contains (input.ElementAt (j))) {
                            if (nm.Contains (input.ElementAt (j)))
                            {
                                nm.Remove(input.ElementAt (j));
                            }
                            fm.Add(input.ElementAt (j));
                            Debug.Log(input.ElementAt (j));
                        }
                    }
                    else
                    {
                        if (!fm.Contains(input.ElementAt (j)))
                        {
                            if (!nm.Contains(input.ElementAt (j)))
                            {
                                nm.Add(input.ElementAt (j));
                                Debug.Log(input.ElementAt (j));
                            }
                        }
                    }
                }
            }
        }
        
    }

    public void SetGameStatus ()
    {
        if (fm.Count == SceneController.difficulty)
        {
            wonPanel.SetActive(true);
        }

        if (PlayerInput.moves == 8 && fm.Count != SceneController.difficulty)
        {
            string x = "";
            foreach (int k in code)
            {
                x += k.ToString();
            }
            failPanel.SetActive(true);
            failPanel.GetComponentInChildren<Text>().text = "SECRET CODE WAS " + x + "!";
            PlayerInput.moves = 0;
        }
    }

}
