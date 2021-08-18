using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public GameObject targetFragments;

    public void Hit(Arrow arrow)
    {
        this.gameObject.SetActive(false);
        Instantiate(targetFragments, this.transform.position, new Quaternion(-90, -90, 0, 0));
        ApplyForce(arrow.transform.forward);
        //LevelSystem.Score();
    }

    public void Hit(Pellet pellet)
    {
        ApplyMaterial();
        ApplyForce(pellet.transform.forward);
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
