using UnityEngine;
using System.Collections;

public class resourceCard : MonoBehaviour {

    public string Name;
    public Object resourceCardImg;
    public string function1 = null;
    public string function2 = null;

}
public class ResourceCardInformation : MonoBehaviour
{
   static public resourceCard resourceCard1;

    void start()
    {
        resourceCard1.Name = "";
        resourceCard1.resourceCardImg = GameObject.Find("");
        resourceCard1.function1 = "";
        resourceCard1.function2 = "";
        

    }
}

