using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour
{
    private int i = 0;
    void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
        Debug.Log("delete Event");
    }

    void OnDestroy()
    {
        Debug.Log("distroy Event");
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
        i++;
        if (i == 5)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            
        }
    }
}