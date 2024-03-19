using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPadController : MonoBehaviour
{
    public List<int> numberList = new List<int> ();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddNumber(int number)
    {
        numberList.Add(number);
        if(numberList.Count == 4)
        {
            Debug.Log(numberList[0]+ ", "+ numberList[1]+ ", "+ numberList[2]+ ", "+ numberList[3]);
        }
    }
    /*
    git add .
    git commit -m "added poke"
    git push

     * */
}
