using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public GameObject targetFragments;

    public void Hit(Arrow arrow)
    {
        this.gameObject.SetActive(false);
        GameObject brokenTarget = Instantiate(targetFragments, this.gameObject.transform.position, targetFragments.gameObject.transform.rotation);
        //ApplyForce(arrow.transform.forward);
    }

    public void Hit(Pellet pellet)
    {
        this.gameObject.SetActive(false);
        GameObject brokenTarget = Instantiate(targetFragments, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }

    private void ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }

    private void ApplyForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * forceAmount);
    }
}
