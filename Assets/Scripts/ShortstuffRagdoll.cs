using UnityEngine;

public class ShortstuffRagdoll : MonoBehaviour
{
    //references
    [SerializeField] private Rigidbody2D torso;
    [SerializeField] private Rigidbody2D[] bodyParts;

    //setup
    private void Start()
    {
        Debug.Log("Ragdoll Ready");
    }

    public void Activate(Vector2 initialVelocity, Vector2 explosionImpulse)
    {
        foreach (Rigidbody2D part in bodyParts)
        {
            if(part != null)
            {
                part.linearVelocity = initialVelocity;
            }
        }

        //apply explosion force to chest
        torso.AddForce(explosionImpulse, ForceMode2D.Impulse);
    }
}
