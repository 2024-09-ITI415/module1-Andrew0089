using System.Collections;
using UnityEngine;

public class Slingshot : MonoBehaviour
[Header("Set in Inspector")]
public GameObject PreProjectile;
public float velocityMult = 8f;
[Header("Set Dynamically")]
public GameObject LaunchPoint; 
public Vector3 LaunchPos;
public GameObject Projectile;
public bool aimingMode;
private Rigibody ProjectileRigitbody;

void Awake() {
    Transfrom LaunchPointTrans = transform.FindChild("LaunchPoint");
    LaunchPoint = LaunchPointTrans.gameObject;
    LaunchPoint.SetActive(false);
    LaunchPointTrans = LaunchPointTrans.Posistion;
}

{ //  public GameObject   LaunchPoint;
//void Awake() {
    //Transform LaunchPointTrans = transform.Find("LaunchPoint");
   // LaunchPoint.SetActive(false);
}
    void OnMouseEnter()
    {
        //print("Slingshot:OnMouseEnter()");
        LaunchPoint.SetActive(true);
    }
    void OnMouseExit()
    {
        //print("Slingshot:OnMousueExit()");
        LaunchPoint.SetActive(false);
    }
void OnMouseDown(){
    aimingMode = true; 
    projectile = Instantiatie(prefabProjectile) as GameObject;
    projectile.transform.position = launchPos;
    projectile.GetComponent<Rigibody>().isKinematic = true;
    ProjectileRigibody = Projectile.GetComponent<Rigibody>();
    ProjectileRigibody.isKinematic = true;
}
void Update(){
    if (!aimingMode) return;
    Vector3 mousePos2D = Input.mousePosition;
    mousePos2D.z = -Camera.main.transform.position.z;
    Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
    Vector3 mouse3D = mousePos3D-LaunchPos;
    float maxMagintude = this.GetComponent<SphereCollider>().radius; 
    if (mouseDelta.magnitude > maxMaginitude) {
        mouseDelta.Normalize();
        mouseDelta *= maxMagintude;
    }
    Vector3 projPos = LaunchPos + mouseDelta;
    projectile.transform.position = projPos;
    if (Input.GetMouseButtonUp(0)) {
        aimingMode = false;
        ProjectileRigidbody.isKinematic = false;
        ProjectileRigidbody.velocity = -mouseDelta * velocityMult;
        FollowCam.POI = Projectile;
        projectile = null;
    }
}
