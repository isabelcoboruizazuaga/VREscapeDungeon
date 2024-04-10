using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPadController : MonoBehaviour
{
    public List<int> numberList = new List<int> ();
    public List<Toggle> toggleList = new List<Toggle> ();

    private string winningSequence = "1, 3, 6, 8";


    public string roomName;

    public void AddNumber(int number, Toggle toggle)
    {
        toggle.interactable = false;
        numberList.Add(number);
        toggleList.Add(toggle);

        if (numberList.Count == 4)
        {
            string sequence= numberList[0]+ ", "+ numberList[1]+ ", "+ numberList[2]+ ", "+ numberList[3];

            Debug.Log(sequence);

            if (sequence != winningSequence){
                StartCoroutine(IncorrectCode());
            }
            else
            {
                GameObject.Find(roomName).GetComponent<DoorsController>().OpenNextDoor();
            }     
        }
    }
    IEnumerator IncorrectCode()
    {
        numberList.Clear();

        yield return new WaitForSeconds(1f);
        Debug.Log("lista toggle: "+toggleList.Count);

        for (var i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].isOn = false;
            //Aqui se cambiaría el icono si no se esconde
            toggleList[i].interactable = true;
        }

        Debug.Log("lista toggle: " + toggleList.Count);
        Debug.Log("________________________________");

    }
    /*
    git add .
    git commit -m "added poke"
    git push

     * */
}
