using UnityEngine;

public class GetMousePosition : MonoBehaviour
{   
    static Vector3 TargetPosition { get;  set; }
    private void Update()
    {

    }

    public static Vector3 GetPosition()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TargetPosition = Input.mousePosition;
        }

        return TargetPosition;
    }
}