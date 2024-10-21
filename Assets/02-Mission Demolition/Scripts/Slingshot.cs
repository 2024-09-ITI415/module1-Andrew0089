using System.Collections;
using UnityEngine;

public class Slingshot : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject prefabProjectile;
    public float velocityMult = 8f;
    
    [Header("Set Dynamically")]
    public GameObject LaunchPoint;
    public Vector3 LaunchPos;
    public GameObject Projectile;
    public bool aimingMode;
    private Rigidbody ProjectileRigidbody;
    void Awake()
    {
        Transform LaunchPointTrans = transform.Find("LaunchPoint");
        LaunchPoint = LaunchPointTrans.gameObject;
        LaunchPoint.SetActive(false);
        LaunchPos = LaunchPointTrans.position;
    }

    void OnMouseEnter()
    {

        LaunchPoint.SetActive(true);
    }
    void OnMouseExit()
    {

        LaunchPoint.SetActive(false);
    }

    void OnMouseDown()
    {
        aimingMode = true;
        Projectile = Instantiate(prefabProjectile) as GameObject;
        Projectile.transform.position = LaunchPos;
        Projectile.GetComponent<Rigidbody>().isKinematic = true;
        ProjectileRigidbody = Projectile.GetComponent<Rigidbody>();
        ProjectileRigidbody.isKinematic = true;
    }
    void Update()
    {
        if (!aimingMode) return;
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 mouseDelta = mousePos3D - LaunchPos;
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        if (mouseDelta.magnitude > maxMagnitude)
        {
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }
        Vector3 projPos = LaunchPos + mouseDelta;
        Projectile.transform.position = projPos;
        if (Input.GetMouseButtonUp(0))
        {
            aimingMode = false;
            ProjectileRigidbody.isKinematic = false;
            ProjectileRigidbody.velocity = -mouseDelta * velocityMult;
            FollowCam1.POI = Projectile;
            Projectile = null;
        }
    }
}