using UnityEngine;
using UnityEngine.Events;


//Dit object beheert het event en voegt een listener toe
//Invoke wilt zeggen dat het event wordt uitgevoerd
//met alle listeners.
public class MyTestEvent : MonoBehaviour
{
    //Unity event 
    [SerializeField] UnityEvent testEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (testEvent == null)
        {
            testEvent = new UnityEvent();
        }
        testEvent.AddListener(LocalListener);

        testEvent.Invoke();

    }

    void LocalListener()
    {
        print("Ik ben toegevoegd via code.");
    }


}