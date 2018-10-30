using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint gunTurret;
    public TurretBlueprint missileTurret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectGunTurret ()
    {
        Debug.Log("Gun Turret Purchased");
        buildManager.SelectTurretToBuild(gunTurret);
    }

    public void SelectMissleTurret()
    {
        Debug.Log("Missle Turret Purchased");
        buildManager.SelectTurretToBuild(missileTurret);
    }

}
