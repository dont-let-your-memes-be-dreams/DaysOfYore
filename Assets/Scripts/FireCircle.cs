using UnityEngine;
using System.Collections;

public class FireCircle : MonoBehaviour
{
    public bool IsSelected = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(IsSelected == true)
        {
            OnSelected();
        }

    }
    void OnSelected()
    {
        Camera camera = GetComponent<Camera>();
        Vector3 p = camera.ScreenToWorldPoint(new Vector3(100, 100, camera.nearClipPlane));
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(p, 0.1F);
        if(Input.GetMouseButtonDown(0))
        {

        }
    }
}