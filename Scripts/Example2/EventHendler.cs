using UnityEngine;
using System.Collections;

public class EventHendler : MonoBehaviour
{

    // Singleton 	
    private static EventHendler instance;

    public delegate void OnClickEvent(GameObject g);
    public event OnClickEvent OnClick;

    // Construct 	
    private EventHendler()
    {
    }

    //  Instance 	
    public static EventHendler Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof (EventHendler)) as EventHendler;
            return instance;
        }
    }

    // Handle our Ray and Hit
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider)
        {
            Debug.Log(hit.transform.gameObject.name);
            // If we click it
            if (Input.GetMouseButtonUp(0))
            {
                // Notify of the event!
                OnClick(hit.transform.gameObject);
            }
        }
    }
}
