using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    // Gezegenin etrafýnda döneceði merkez obje (Güneþ)
    public Transform targetObject;

    // Yörünge hýzýný belirler. Her gezegen için farklý olmalýdýr.
    public float orbitSpeed = 10f;

    // Yörünge ekseni (Genellikle Y ekseni, yani Vector3.up)
    public Vector3 rotationAxis = Vector3.up;

    // Her oyun karesinde çaðrýlýr
    void Update()
    {
        if (targetObject == null) return; // Güvenlik kontrolü

        // Kendi objesini (gezegen) hedef objenin (Güneþ) etrafýnda döndürür.
        transform.RotateAround(
            targetObject.position,
            rotationAxis,
            orbitSpeed * Time.deltaTime
        );
    }
}
