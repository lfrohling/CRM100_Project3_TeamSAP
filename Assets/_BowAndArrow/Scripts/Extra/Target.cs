using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public GameObject targetFragments;
    public GameObject levelStart;

    public void Hit(Arrow arrow)
    {
        this.gameObject.SetActive(false);
        LevelSystem score = levelStart.GetComponent<LevelSystem>();
        score.Score();
        Instantiate(targetFragments, this.transform.position, new Quaternion(-90, -90, 0, 0));
        ApplyForce(arrow.transform.forward, targetFragments);
    }

    public void Hit(Pellet pellet)
    {
        ApplyMaterial();
        ApplyForce(pellet.transform.forward, targetFragments);
    }

    private void ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }

    private void ApplyForce(Vector3 direction, GameObject target)
    {
        Rigidbody rigidbody = target.GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * forceAmount);
    }
}
