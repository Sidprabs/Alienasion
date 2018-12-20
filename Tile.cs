using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tile : MonoBehaviour {

    public Text DescText;
    public static float Oil;
    public static float Water;
    public static float Construction;
    public static float Gold;
    public static float Farm;
    public static float Shop;
    public static float Cloth;
    public static float Pharmaceuticals;
    public static float Trading;
    public static float Business;
    private float a;
    private float b;
    private float c;
    private float d;
    private float e;
    private float f;
    private float g;
    public static float PlayerResources;
    public static float Money;
    public static float WorldResources;
    public Text PlayerR;
    public Text PMoney;
    public Text World;

    void Start ()
    {

        a = 10;
        b = 20;
        c = 30;
        d = 40;
        e = 50;
        f = 60;
        g = 70;
        WorldResources = 5000;
        Money = 2000;
        PlayerResources = 500;
    }

    private void Update()
    {
        PlayerR.text = "" + PlayerResources;
        PMoney.text = "$" + Money;
        World.text = "" + WorldResources;
        endGame();
    }

    private void FixedUpdate()
    {
        WorldResources -= 1 * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "Oil")
        {
            
            DescText.text = "Oil Brig. Used to pump out oil from the ground for use as resources. Requires money to produce resources. $70 for 10 Units.";
            PlayerResources = PlayerResources + a;
            Money = Money - g;
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Water")
        {

            DescText.text = "Water treatment facility. Used to treat water for use as resources. Requires money to produce resources. $10 for 10 Units.";
            PlayerResources = PlayerResources + a;
            Money = Money - a;
            Debug.Log(Money);

        }

       else if (gameObject.tag == "Construction")
        {
            Money = Money + e;
            PlayerResources = PlayerResources - a;
            WorldResources = WorldResources + a;
            DescText.text = "Construction Company. Used to build buildings in return for money. Requires resources to earn money. 10 Units for $50.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Gold")
        {
            PlayerResources = PlayerResources + a;
            Money = Money - f;
            DescText.text = "Gold Mine. Used to dig out gold from the ground for use as resources. Requires money to produce resources. $60 for 10 Units.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Farm")
        {
            PlayerResources = PlayerResources + a;
            Money = Money - a;
            DescText.text = "Farm. Used to Cultivate crops for use as resources and food. Requires money to produce resources. $10 for 10 Units.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Shop")
        {
            Money = Money + b;
            PlayerResources = PlayerResources - a;
            WorldResources = WorldResources + a;
            DescText.text = "Shop. Used to sell items and resources in return for money. Requires resources to earn money. 10 Units for $20.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Cloth")
        {
            PlayerResources = PlayerResources + a;
            Money = Money - b;
            DescText.text = "Cloth. Used to produce textiles as resources and for sale. Requires money to produce resources. $20 for 10 Units.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Pharmaceuticals")
        {
            PlayerResources = PlayerResources + a;
            Money = Money - b;
            DescText.text = "Pharmaceutical. Used to produce medicines and drugs as resources and for sale. Requires money to produce resources. $20 for 10 Units.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Trading")
        {
            Money = Money + c;
            PlayerResources = PlayerResources - a;
            WorldResources = WorldResources + a;
            DescText.text = "Trade Centre. Used to sell items and resources in return for money. Requires resources to earn money. 1 Units for $3.";
            Debug.Log(Money);
        }

        else if (gameObject.tag == "Business")
        {
            Money = Money + d;
            PlayerResources = PlayerResources - a;
            WorldResources = WorldResources + a;
            DescText.text = "Business. Used to own business and sell items and resources in return for money. Requires resources to earn money. 1 Units for $4.";
            Debug.Log(Money);
        }

    }

    private void endGame()
    {
        if(WorldResources < 0)
        {
            SceneManager.LoadScene(4);
        }

        if(PlayerResources < 0)
        {
            SceneManager.LoadScene(4);
        }

        if(Money < 0)
        {
            SceneManager.LoadScene(4);
        }

        if(WorldResources > 10000)
        {
            if(Money > 5000)
            {
                SceneManager.LoadScene(5);
            }
            if(Money > 7500)
            {
                SceneManager.LoadScene(6);
            }
            if(Money > 10000)
            {
                SceneManager.LoadScene(7);
            }
        }
    }

}
