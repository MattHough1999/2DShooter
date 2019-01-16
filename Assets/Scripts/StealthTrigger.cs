using UnityEngine;
public class StealthTrigger : MonoBehaviour
{
    public int Detected;
    public float resetTime = 0.25f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("Detected", Detected, SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);
    }
    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}