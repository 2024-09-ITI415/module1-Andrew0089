using System.Collections;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    static private Slingshot S;
    [Header("Set in Inspector")]
    public GameObject prefabProjectile;
public float velocityMult = 8f;

[Header("Set Dynamically")]
public GameObject launchPoint;
public Vector3 launchPos;
public GameObject Projectile;
public bool aimingMode;
private Rigidbody ProjectileRigidbody;
static public Vector3 LaunchPos 
    {
        get 
    {
        if (S == null) return Vector3.zero;
        return S.launchPos;
  }
   }         
    void Awake()
{
        S = this;
    Transform launchPointTrans = transform.Find("LaunchPoint");
    launchPoint = launchPointTrans.gameObject;
    launchPoint.SetActive(false);
    launchPos = launchPointTrans.position;
}

void OnMouseEnter()
{

    launchPoint.SetActive(true);
}
void OnMouseExit()
{

    launchPoint.SetActive(false);
}

void OnMouseDown()
{
    aimingMode = true;
    Projectile = Instantiate(prefabProjectile) as GameObject;
    Projectile.transform.position = launchPos;
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
    Vector3 mouseDelta = mousePos3D - launchPos;
    float maxMagnitude = this.GetComponent<SphereCollider>().radius;
    if (mouseDelta.magnitude > maxMagnitude)
    {
        mouseDelta.Normalize();
        mouseDelta *= maxMagnitude;
    }
    Vector3 projPos = launchPos + mouseDelta;
    Projectile.transform.position = projPos;
    if (Input.GetMouseButtonUp(0))
    {
        aimingMode = false;
        ProjectileRigidbody.isKinematic = false;
        ProjectileRigidbody.velocity = -mouseDelta * velocityMult;
        FollowCam1.POI = Projectile;
        Projectile = null;
        MissionDemolition.ShotFired();
        ProjectileLine.S.poi = Projectile;
    }
    
}
}