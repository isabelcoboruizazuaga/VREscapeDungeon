using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NumberPadController : MonoBehaviour
{
    public List<int> numberList = new List<int> ();
    public List<Toggle> toggleList = new List<Toggle> ();

    public string winningSequence = "1, 3, 6, 8";


    public string roomName;

    public void AddNumber(int number, Toggle toggle)
    {
        if (toggleList.Count < 4)
        {
            toggle.interactable = false;
            numberList.Add(number);
            toggleList.Add(toggle);
            numberList = numberList.Distinct().ToList();
            toggleList = toggleList.Distinct().ToList();

            if (numberList.Count == 4)
            {
                string sequence = numberList[0] + ", " + numberList[1] + ", " + numberList[2] + ", " + numberList[3];

                Debug.Log(sequence);

                if (sequence != winningSequence)
                {
                    StartCoroutine(IncorrectCode());
                }
                else
                {
                    GameObject.Find(roomName).GetComponent<DoorsController>().OpenNextDoor();
                }
            }
        }
        else
        {
            toggleList.Clear();
        }
    }
    IEnumerator IncorrectCode()
    {
        Debug.Log("lista toggle: " + toggleList.Count);

        var miList = new List<Toggle>(toggleList);

        numberList.Clear();
       // toggleList.Clear();



        yield return new WaitForSeconds(1f);

        for (var i = 0; i < miList.Count; i++)
        {
            miList[i].isOn = false;
            //Aqui se cambiaría el icono si no se esconde
            miList[i].interactable = true;
        }

        Debug.Log("lista toggle: " + miList.Count);
        Debug.Log("________________________________");

    }
    /*
    git add .
    git commit -m "added poke"
    git push

     * */
}
