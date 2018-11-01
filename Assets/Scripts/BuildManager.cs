using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    

    private void Awake()
    {
        if (instance !=null)
        {
            Debug.LogError("More than one Build manager in scene!");
            return;
        }
        instance = this;
    }


    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }    

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log ("Not Enough Money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPostion(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPostion(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret built. Money Left" + PlayerStats.Money);
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
