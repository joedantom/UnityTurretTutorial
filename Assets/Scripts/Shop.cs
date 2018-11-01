using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint gunTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint laserTurret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectGunTurret ()
    {
        Debug.Log("Gun Turret Selected");
        buildManager.SelectTurretToBuild(gunTurret);
    }

    public void SelectMissleTurret()
    {
        Debug.Log("Missle Turret Selected");
        buildManager.SelectTurretToBuild(missileTurret);
    }

    public void SelectLaserTurret()
    {
        Debug.Log("Laser Turret Selected");
        buildManager.SelectTurretToBuild(laserTurret);
    }
}
