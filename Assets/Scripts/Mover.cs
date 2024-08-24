using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveDistance = 3f;
    public float moveSpeed  = 1f;
    public float waitTime = 1f;

    private Vector3 originalPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition;
        StartCoroutine(MoveBackAndForth());
    }

    private void Update()
    {
        GetPosition();
    }

    private Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(GetMousePosition.GetPosition());
        RaycastHit hit;
        Vector3 hitPoint = Vector3.zero;

        if(Physics.Raycast(ray, out hit) )
        {
            hitPoint = hit.point;
        }

        return hitPoint;
    }

    private IEnumerator MoveBackAndForth()
    {
        while(true)
        {
            
            // Move to the right
            yield return StartCoroutine(MoveObject(transform.position, GetPosition()));

            // Wait for a while
            yield return new WaitForSeconds(waitTime);

            //Move back to the original position
            yield return StartCoroutine(MoveObject(transform.position, originalPosition));

            //Wait again
            yield return new WaitForSeconds(waitTime);  
        }

        IEnumerator MoveObject(Vector3 startPos, Vector3 endPos)
        {
            float elapsedTime = 0f;

            while(elapsedTime < moveSpeed)
            {
                transform.position = Vector3.Lerp(startPos, endPos, elapsedTime / moveSpeed);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = endPos;
        }
    }
}
