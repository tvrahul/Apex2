using UnityEngine;

public class StoolTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.CompareTag("Player"))
        {
            SittingController sittingController = other.GetComponent<SittingController>();
            if (sittingController != null)
            {
                //sittingController.sittingPosition = transform.parent.gameObject;
                //sittingController.sittingOffset = other.transform.position - transform.position;
            }
        }
    }
}
