using UnityEngine;
using System.Collections;

public class GoldScript : MonoBehaviour
{

    private void Awake()
    {
        
        // Start the event listener
        EventHendler.Instance.OnClick += OnClick;
        Debug.Log("OK");
    }

    private void OnDisable()
    {
        EventHendler.Instance.OnClick -= OnClick;
        Debug.Log("Disable");
    }

    // The event that gets called
    private void OnClick(GameObject g)
    {
        // If g is THIS gameObject
        if (g == gameObject)
        {
            Debug.Log("Hide and give us money!");

            // Hide
            gameObject.active = false;
        }
    }

}
